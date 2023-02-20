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
            var forceDomain = ForcedDomainTextBox.Text.Trim().TrimEnd('/');
            var hasForceDomain = !string.IsNullOrWhiteSpace(forceDomain);
            var isLinux = LinuxCheckBox.Checked;
            var duplicateSpacesWithPlusRule = DuplicateSpaceWithPlusCheckBox.Checked;
            var appendQsString = AppendQueryStringCheckBox.Checked ? "true" : "false";

            foreach (var redirect in redirects)
            {
                var oldUrl = redirect.OldUrl.CleanUrl(isLinux);
                var newUrl = redirect.NewUrl.CleanUrl(isLinux);

                if (string.IsNullOrEmpty(oldUrl) || string.IsNullOrEmpty(newUrl) || newUrl.Equals("#N/A", StringComparison.InvariantCultureIgnoreCase))
                    continue;

                if (hasForceDomain)
                {
                    var forceType = ForceTypeComboBox.SelectedItem.ToString();

                    if (forceType == "Both" || forceType == "From")
                    {
                        var currentOldDomainInfo = Helpers.GetDomainInfo(oldUrl);
                        if (!string.IsNullOrWhiteSpace(currentOldDomainInfo.Domain))
                        {
                            oldUrl = "/" + currentOldDomainInfo.Path + currentOldDomainInfo.QueryString;
                        }
                        oldUrl = forceDomain + oldUrl;
                    }

                    if (forceType == "Both" || forceType == "To")
                    {
                        var currentNewDomainInfo = Helpers.GetDomainInfo(newUrl);
                        if (!string.IsNullOrWhiteSpace(currentNewDomainInfo.Domain))
                        {
                            newUrl = "/" + currentNewDomainInfo.Path + currentNewDomainInfo.QueryString;
                        }
                        newUrl = forceDomain + newUrl;
                    }
                }

                if (AddTrailingFromSlashCheckBox.Checked)
                {
                    oldUrl += "/";
                }

                var oldDomainInfo = Helpers.GetDomainInfo(oldUrl, StarWildcardCheckBox.Checked);
                var newDomainInfo = Helpers.GetDomainInfo(newUrl);

                if (!string.IsNullOrWhiteSpace(newDomainInfo.Domain))
                {
                    newUrl = newUrl.Replace(newDomainInfo.Domain, "{HTTP_HOST}"); // Replace to match any domain
                }

                var handleWildCards = EndWildCardMatch.Checked ||
                                      (StarWildcardCheckBox.Checked && oldDomainInfo.PathEndsWithStar);

                var ruleStringBuilder = new StringBuilder();

                // Create rule header
                ruleStringBuilder.AppendLine("<rule name=\"" + ruleNamePrefix + index + "\" stopProcessing=\"true\">");

                // Create match rule
                ruleStringBuilder.Append("<match url=\"^");

                ruleStringBuilder.Append(duplicateSpacesWithPlusRule ? oldDomainInfo.Path.Replace(" ", "[%20\\+]+") : oldDomainInfo.Path);

                if (handleWildCards)
                {
                    ruleStringBuilder.Append("(.*)");
                }

                ruleStringBuilder.AppendLine("$\" />");

                if (MatchDomainCheckBox.Checked || oldDomainInfo.HasQueryString)
                {
                    ruleStringBuilder.AppendLine("<conditions>");

                    if (MatchDomainCheckBox.Checked)
                    {
                        ruleStringBuilder.AppendLine("<add input=\"{HTTP_HOST}\" pattern=\"^(" + oldDomainInfo.Domain + ")\" />");
                    }

                    if (!IgnoreQueryStringMatchCheckBox.Checked)
                    {
                        if (oldDomainInfo.HasQueryString)
                        {
                            var querystringParts = oldDomainInfo.QueryString.Split('&');

                            foreach (var querystringPart in querystringParts)
                            {
                                ruleStringBuilder.AppendLine("<add input=\"{QUERY_STRING}\" pattern=\"(.*)" +
                                                             querystringPart + "(.*)\" />");
                            }

                        }
                        else
                        {
                            ruleStringBuilder.AppendLine("<add input=\"{QUERY_STRING}\" pattern=\"^$\" />");
                        }
                    }

                    ruleStringBuilder.AppendLine("</conditions>");
                }

                var wildCardPattern = handleWildCards ? "{R:1}" : string.Empty;
                ruleStringBuilder.AppendLine("<action type=\"Redirect\" url=\"" + newUrl + wildCardPattern + "\" appendQueryString=\"" + appendQsString + "\" redirectType=\"" + redirectType.Value + "\"/>");

                ruleStringBuilder.AppendLine("</rule>");

                sb.Append(ruleStringBuilder);

                if (oldDomainInfo.Path.EndsWith("index.htm"))
                {
                    sb.Append(ruleStringBuilder.ToString().Replace("\" stopProcessing", "-indexpath\" stopProcessing")
                        .Replace("index.htm", string.Empty));
                }

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

        private void RedirectGenerator_Load(object sender, EventArgs e)
        {
            ForceTypeComboBox.SelectedIndex = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
