using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RedirectGenerator
{
    using System.Text.RegularExpressions;
    using FileHelpers;

    /// <summary>
    /// The main form
    /// </summary>
    public partial class RedirectGenerator : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChainUrlFixer"/> class.
        /// </summary>
        public RedirectGenerator()
        {
            InitializeComponent();

            RedirectTypeComboBox.DataSource = GetRedirectTypes();
            CreateForEveryComboBox.SelectedIndex = 10;
            PostmanGenerator.Load();
        }

        /// <summary>
        /// Determines whether this instance we can generate .
        /// </summary>
        /// <returns><c>true</c> if this instance [can start generation]; otherwise, <c>false</c>.</returns>
        private bool CanStartGeneration()
        {
            return !string.IsNullOrWhiteSpace(FileTextBox.Text.Trim());
        }

        /// <summary>
        /// Handles the Click event of the GenerateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (CanStartGeneration())
            {
                var ignoreLine1 = IgnoreLine1CheckBox.Checked;

                GenerateFiles(CsvOpenDialog.FileNames, ignoreLine1);
            }
        }

        /// <summary>
        /// Generates the files.
        /// </summary>
        /// <param name="csvFiles">The CSV files.</param>
        /// <param name="ignoreLine1">if set to <c>true</c> ignore line 1.</param>
        private void GenerateFiles(string[] csvFiles, bool ignoreLine1)
        {
            ClearControls();

            var redirectList = new List<Redirect>();

            foreach (var csvFile in csvFiles)
            {
                redirectList.AddRange(LoadRedirects(csvFile, ignoreLine1));
            }

            var redirectType = (RedirectType)RedirectTypeComboBox.SelectedItem;

            if (GenerateRedirectsCheckBox.Checked)
            {
                RulesTextBox.Text = GenerateRewriteRule(redirectList.ToArray(), redirectType);
            }

            if (GeneratePostmanTestsCheckBox.Checked)
            {
                PostmanTextBox.Text = GeneratePostmanCollection(redirectList.ToArray(), redirectType);
            }

            if (GeneratePostmanTestsCheckBox.Checked)
            {
                if (string.IsNullOrWhiteSpace(CollectionNameTextBox.Text.Trim()))
                {
                    MessageBox.Show("You must set the collection name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PostmanTextBox.Text = GeneratePostmanCollection(redirectList.ToArray(), redirectType);
                }
            }
;
        }

        /// <summary>
        /// Clears the controls.
        /// </summary>
        private void ClearControls()
        {
            RulesTextBox.Clear();
            PostmanTextBox.Clear();
        }

        /// <summary>
        /// Loads the redirects.
        /// </summary>
        /// <param name="csvFile">The CSV file.</param>
        /// <param name="ignoreLine1">if set to <c>true</c> [ignore line1].</param>
        /// <returns>Redirect[].</returns>
        private Redirect[] LoadRedirects(string csvFile, bool ignoreLine1)
        {
            var engine = new FileHelperEngine<Redirect>
            {
                Options =
                {
                    IgnoreFirstLines = ignoreLine1 ? 1 : 0
                }
            };

            return engine.ReadFile(csvFile);
        }

        /// <summary>
        /// Generates the rewrite rule.
        /// </summary>
        /// <param name="redirects">The redirects.</param>
        /// <param name="redirectType"></param>
        /// <returns>System.String.</returns>
        private string GenerateRewriteRule(Redirect[] redirects, RedirectType redirectType)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<rules>");
            var index = int.TryParse(RuleNameStartIndexTextBox.Text, out var parsedInt) ? parsedInt : 1;
            var ruleNamePrefix = string.IsNullOrWhiteSpace(RuleNamePrefixTextBox.Text)
                ? "Rule"
                : RuleNamePrefixTextBox.Text;


            foreach (var redirect in redirects)
            {
                var domainInfo = Helpers.GetDomainInfo(redirect.OldUrl);
                var oldUrl = redirect.OldUrl.Trim(',', '"').Replace("\\", "/").Replace("\"", "").Replace("&", "&amp;").Replace("–", "-").Replace(" ", "%20").Trim();
                var newUrl = redirect.NewUrl.Trim(',', '"').Replace("\\", "/").Replace("\"", "").Replace("&", "&amp;").Replace("–", "-").Replace(" ", "%20").Trim();
                var domainInfoPath = domainInfo.Path.Trim(',', '"').Replace("&", "&amp;").Replace("–", "-").Replace(" ", "%20").Trim();

                if (string.IsNullOrEmpty(oldUrl) || string.IsNullOrEmpty(domainInfoPath))
                    continue;

                //newUrl = newUrl.TrimEnd('/');
                newUrl = string.IsNullOrEmpty(newUrl) ? "/" : newUrl;

                if (!newUrl.StartsWith("http://") && !newUrl.StartsWith("https://"))
                {
                    var targetSiteUrl = "https://{HTTP_HOST}";
                    newUrl = targetSiteUrl + newUrl;
                }

                var oldUrlParts = domainInfoPath.Split('?');
                sb.AppendLine("<rule name=\"" + ruleNamePrefix + index + "\" stopProcessing=\"true\">");
                sb.Append("<match url=\"^");

                var matchUrl = oldUrlParts[0];

                matchUrl = Regex.Escape(matchUrl).Replace("]", "\\]").Replace("%20", " ");

                if (!matchUrl.Contains('.') && !matchUrl.Contains('?'))
                {
                    matchUrl = matchUrl.TrimEnd('/');
                    matchUrl = $"{matchUrl}(/)?";
                }
                sb.AppendLine(matchUrl + "$\" />");

                if (oldUrlParts.Length > 1 || MatchDomainCheckBox.Checked)
                {
                    sb.AppendLine("<conditions>");
                    
                    if (MatchDomainCheckBox.Checked)
                    {
                        var domainPattern = domainInfo.Domain.StartsWith("www.")
                            ? $"^{domainInfo.Domain}$"
                            : $"^(www.)?{domainInfo.Domain}$";


                        sb.AppendLine("<add input=\"{HTTP_HOST}\" pattern=\"" + domainPattern + "\" />");                        
                    }

                    if (oldUrlParts.Length > 1)
                    {
                        sb.AppendLine("<add input=\"{QUERY_STRING}\" pattern=\"^" + Regex.Escape(oldUrlParts[1]).Replace("]", "\\]") + "$\" />");
                    }
                    else
                    {
                        sb.AppendLine("<add input=\"{QUERY_STRING}\" pattern=\"^$\" />");
                    }

                    sb.AppendLine("</conditions>");
                }

                sb.AppendLine("<action type=\"Redirect\" url=\"" + newUrl + "\" appendQueryString=\"false\" redirectType=\"" + redirectType.StatusCode + "\"/>");                

                sb.AppendLine("</rule>");
                index++;
            }

            sb.AppendLine("</rules>");
            return sb.ToString();
        }

        /// <summary>
        /// Generates the postman collection.
        /// </summary>
        /// <param name="redirects">The redirects.</param>
        /// <param name="redirectType"></param>
        /// <returns>System.String.</returns>
        private string GeneratePostmanCollection(Redirect[] redirects, RedirectType redirectType)
        {
            var jsonItemList = new List<PostmanCollectionItemJsonData>();
            var index = 0;
            var selectedSkipValue = CreateForEveryComboBox.SelectedIndex;

            foreach (var redirect in redirects)
            {
                if (selectedSkipValue == 10 || selectedSkipValue == index)
                {
                    var oldUrl = redirect.OldUrl.Replace("\\", "/").Replace("\"", "");
                    var newUrl = redirect.NewUrl.Replace("\\", "/").Replace("\"", "");
                    var domainInfo = Helpers.GetDomainInfo(oldUrl);
                    var hostSegments = domainInfo.Domain.Split('.');
                    var urlSegments = domainInfo.Path.Split('/');                    

                    newUrl = string.IsNullOrEmpty(newUrl) ? "/" : newUrl;
                    if (!newUrl.StartsWith("http://") && !newUrl.StartsWith("https://"))
                    {
                        var targetSiteUrl = $"https://{domainInfo.Domain}";

                        newUrl = targetSiteUrl + newUrl;
                    }

                    jsonItemList.Add(new PostmanCollectionItemJsonData
                    {
                        Name = oldUrl,
                        Guid = Guid.NewGuid().ToString("D"),
                        StatusCode = redirectType.StatusCode,
                        FullToUrl = newUrl,
                        FullFromUrl = oldUrl,
                        Protocol = domainInfo.HttpMode,
                        Hosts = hostSegments,
                        Paths = urlSegments
                    });
                }

                if (index == 9)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }

            var data = new PostmanCollectionJsonData
            {
                Name = CollectionNameTextBox.Text.Trim(),
                Guid = Guid.NewGuid().ToString("D"),
                Items = jsonItemList
            };

            return PostmanGenerator.GetCollectionJson(data);
        }

        /// <summary>
        /// Handles the Click event of the CopyButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RulesTextBox.Text);
        }

        /// <summary>
        /// Files the select button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            if (CsvOpenDialog.ShowDialog() == DialogResult.OK)
            {
                var fileNameList = new List<string>();

                foreach (var file in CsvOpenDialog.FileNames)
                {
                    var fileInfo = new FileInfo(file);
                    fileNameList.Add(fileInfo.Name);
                }

                FileTextBox.Text = string.Join(", ", fileNameList);
            }
        }

        /// <summary>
        /// Gets the redirect types.
        /// </summary>
        /// <returns>IEnumerable&lt;RedirectType&gt;.</returns>
        private IEnumerable<RedirectType> GetRedirectTypes()
        {
            return new[]
            {
                new RedirectType {Name = "301 – Permanent", Value = "Permanent", StatusCode = "301"},
                new RedirectType {Name = "302 – Found", Value = "Found", StatusCode = "302"},
                new RedirectType {Name = "303 – See other", Value = "See other", StatusCode = "303"},
                new RedirectType {Name = "307 – Temporary", Value = "Temporary", StatusCode = "307"}
            };
        }

        /// <summary>
        /// Handles the Click event of the CopyPostmanRules control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CopyPostmanRules_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PostmanTextBox.Text.Trim());
        }

        /// <summary>
        /// Handles the Click event of the SavePostmanButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SavePostmanButton_Click(object sender, EventArgs e)
        {
            if (PostmanSave.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(PostmanSave.FileName, PostmanTextBox.Text.Trim());
            }
        }
    }
}
