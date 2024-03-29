﻿namespace RedirectGenerator
{
    partial class RedirectGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CsvOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RulesTextBox = new System.Windows.Forms.TextBox();
            this.CopyRulesButton = new System.Windows.Forms.Button();
            this.RedirectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.AppendQueryStringCheckBox = new System.Windows.Forms.CheckBox();
            this.IgnoreQueryStringMatchCheckBox = new System.Windows.Forms.CheckBox();
            this.DuplicateSpaceWithPlusCheckBox = new System.Windows.Forms.CheckBox();
            this.LinuxCheckBox = new System.Windows.Forms.CheckBox();
            this.StarWildcardCheckBox = new System.Windows.Forms.CheckBox();
            this.ForceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddTrailingFromSlashCheckBox = new System.Windows.Forms.CheckBox();
            this.EndWildCardMatch = new System.Windows.Forms.CheckBox();
            this.ForcedDomainLabel = new System.Windows.Forms.Label();
            this.ForcedDomainTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RuleNamePrefixTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RuleNameStartIndexTextBox = new System.Windows.Forms.TextBox();
            this.MatchDomainCheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateRedirectsCheckBox = new System.Windows.Forms.CheckBox();
            this.IgnoreLine1CheckBox = new System.Windows.Forms.CheckBox();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.PostmanGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateForEveryComboBox = new System.Windows.Forms.ComboBox();
            this.CreateForEveryLabel = new System.Windows.Forms.Label();
            this.CollectionNameLabel = new System.Windows.Forms.Label();
            this.GeneratePostmanTestsCheckBox = new System.Windows.Forms.CheckBox();
            this.CollectionNameTextBox = new System.Windows.Forms.TextBox();
            this.CopyPostmanRules = new System.Windows.Forms.Button();
            this.PostmanTextBox = new System.Windows.Forms.TextBox();
            this.SavePostmanButton = new System.Windows.Forms.Button();
            this.PostmanSave = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CopyRulesWithoutRuleNodeButton = new System.Windows.Forms.Button();
            this.AdditionalMatchDomains = new System.Windows.Forms.Label();
            this.AdditionalMatchDomainsTextBox = new System.Windows.Forms.TextBox();
            this.GeneralGroupBox.SuspendLayout();
            this.PostmanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CsvOpenDialog
            // 
            this.CsvOpenDialog.FileName = "openFileDialog1";
            this.CsvOpenDialog.Filter = "CSV Files|*.csv";
            this.CsvOpenDialog.Multiselect = true;
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(165, 49);
            this.FileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(870, 26);
            this.FileTextBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(7, 533);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(2289, 35);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RulesTextBox
            // 
            this.RulesTextBox.Location = new System.Drawing.Point(12, 578);
            this.RulesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesTextBox.Multiline = true;
            this.RulesTextBox.Name = "RulesTextBox";
            this.RulesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RulesTextBox.Size = new System.Drawing.Size(1129, 758);
            this.RulesTextBox.TabIndex = 2;
            // 
            // CopyRulesButton
            // 
            this.CopyRulesButton.Location = new System.Drawing.Point(12, 1347);
            this.CopyRulesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyRulesButton.Name = "CopyRulesButton";
            this.CopyRulesButton.Size = new System.Drawing.Size(568, 35);
            this.CopyRulesButton.TabIndex = 3;
            this.CopyRulesButton.Text = "Copy To Clipboard (With Rules Wrapper)";
            this.CopyRulesButton.UseVisualStyleBackColor = true;
            this.CopyRulesButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // RedirectTypeComboBox
            // 
            this.RedirectTypeComboBox.DisplayMember = "Name";
            this.RedirectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RedirectTypeComboBox.FormattingEnabled = true;
            this.RedirectTypeComboBox.Location = new System.Drawing.Point(165, 103);
            this.RedirectTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedirectTypeComboBox.Name = "RedirectTypeComboBox";
            this.RedirectTypeComboBox.Size = new System.Drawing.Size(180, 28);
            this.RedirectTypeComboBox.TabIndex = 7;
            this.RedirectTypeComboBox.ValueMember = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Redirect Type";
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.AdditionalMatchDomains);
            this.GeneralGroupBox.Controls.Add(this.AppendQueryStringCheckBox);
            this.GeneralGroupBox.Controls.Add(this.IgnoreQueryStringMatchCheckBox);
            this.GeneralGroupBox.Controls.Add(this.DuplicateSpaceWithPlusCheckBox);
            this.GeneralGroupBox.Controls.Add(this.LinuxCheckBox);
            this.GeneralGroupBox.Controls.Add(this.StarWildcardCheckBox);
            this.GeneralGroupBox.Controls.Add(this.ForceTypeComboBox);
            this.GeneralGroupBox.Controls.Add(this.AddTrailingFromSlashCheckBox);
            this.GeneralGroupBox.Controls.Add(this.EndWildCardMatch);
            this.GeneralGroupBox.Controls.Add(this.ForcedDomainLabel);
            this.GeneralGroupBox.Controls.Add(this.ForcedDomainTextBox);
            this.GeneralGroupBox.Controls.Add(this.label4);
            this.GeneralGroupBox.Controls.Add(this.RuleNamePrefixTextBox);
            this.GeneralGroupBox.Controls.Add(this.label3);
            this.GeneralGroupBox.Controls.Add(this.RuleNameStartIndexTextBox);
            this.GeneralGroupBox.Controls.Add(this.MatchDomainCheckBox);
            this.GeneralGroupBox.Controls.Add(this.GenerateRedirectsCheckBox);
            this.GeneralGroupBox.Controls.Add(this.IgnoreLine1CheckBox);
            this.GeneralGroupBox.Controls.Add(this.FileSelectButton);
            this.GeneralGroupBox.Controls.Add(this.FileLabel);
            this.GeneralGroupBox.Controls.Add(this.FileTextBox);
            this.GeneralGroupBox.Controls.Add(this.label1);
            this.GeneralGroupBox.Controls.Add(this.RedirectTypeComboBox);
            this.GeneralGroupBox.Location = new System.Drawing.Point(12, 18);
            this.GeneralGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GeneralGroupBox.Size = new System.Drawing.Size(1140, 505);
            this.GeneralGroupBox.TabIndex = 9;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "General";
            // 
            // AppendQueryStringCheckBox
            // 
            this.AppendQueryStringCheckBox.AutoSize = true;
            this.AppendQueryStringCheckBox.Location = new System.Drawing.Point(356, 257);
            this.AppendQueryStringCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppendQueryStringCheckBox.Name = "AppendQueryStringCheckBox";
            this.AppendQueryStringCheckBox.Size = new System.Drawing.Size(266, 24);
            this.AppendQueryStringCheckBox.TabIndex = 28;
            this.AppendQueryStringCheckBox.Text = "Append Querstring On Redirects";
            this.toolTip1.SetToolTip(this.AppendQueryStringCheckBox, "When checked the querystring will be passed through on the redirect");
            this.AppendQueryStringCheckBox.UseVisualStyleBackColor = true;
            this.AppendQueryStringCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // IgnoreQueryStringMatchCheckBox
            // 
            this.IgnoreQueryStringMatchCheckBox.AutoSize = true;
            this.IgnoreQueryStringMatchCheckBox.Location = new System.Drawing.Point(694, 257);
            this.IgnoreQueryStringMatchCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IgnoreQueryStringMatchCheckBox.Name = "IgnoreQueryStringMatchCheckBox";
            this.IgnoreQueryStringMatchCheckBox.Size = new System.Drawing.Size(280, 24);
            this.IgnoreQueryStringMatchCheckBox.TabIndex = 27;
            this.IgnoreQueryStringMatchCheckBox.Text = "Don\'t Match On Empty Querystring";
            this.toolTip1.SetToolTip(this.IgnoreQueryStringMatchCheckBox, "When checked the rule will match with or without querystring params");
            this.IgnoreQueryStringMatchCheckBox.UseVisualStyleBackColor = true;
            // 
            // DuplicateSpaceWithPlusCheckBox
            // 
            this.DuplicateSpaceWithPlusCheckBox.AutoSize = true;
            this.DuplicateSpaceWithPlusCheckBox.Location = new System.Drawing.Point(110, 207);
            this.DuplicateSpaceWithPlusCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DuplicateSpaceWithPlusCheckBox.Name = "DuplicateSpaceWithPlusCheckBox";
            this.DuplicateSpaceWithPlusCheckBox.Size = new System.Drawing.Size(222, 24);
            this.DuplicateSpaceWithPlusCheckBox.TabIndex = 26;
            this.DuplicateSpaceWithPlusCheckBox.Text = "Duplicate Space With Plus";
            this.toolTip1.SetToolTip(this.DuplicateSpaceWithPlusCheckBox, "If this is selected a second rule will be added for any spaces that works with a " +
        "plus");
            this.DuplicateSpaceWithPlusCheckBox.UseVisualStyleBackColor = true;
            // 
            // LinuxCheckBox
            // 
            this.LinuxCheckBox.AutoSize = true;
            this.LinuxCheckBox.Location = new System.Drawing.Point(949, 207);
            this.LinuxCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LinuxCheckBox.Name = "LinuxCheckBox";
            this.LinuxCheckBox.Size = new System.Drawing.Size(70, 24);
            this.LinuxCheckBox.TabIndex = 25;
            this.LinuxCheckBox.Text = "Lixux";
            this.toolTip1.SetToolTip(this.LinuxCheckBox, "If the application is running on linux or the DXP");
            this.LinuxCheckBox.UseVisualStyleBackColor = true;
            // 
            // StarWildcardCheckBox
            // 
            this.StarWildcardCheckBox.AutoSize = true;
            this.StarWildcardCheckBox.Location = new System.Drawing.Point(694, 207);
            this.StarWildcardCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StarWildcardCheckBox.Name = "StarWildcardCheckBox";
            this.StarWildcardCheckBox.Size = new System.Drawing.Size(238, 24);
            this.StarWildcardCheckBox.TabIndex = 24;
            this.StarWildcardCheckBox.Text = "End Replace * With Wildcard";
            this.toolTip1.SetToolTip(this.StarWildcardCheckBox, "When checked replaces a star at end of URL for a wildcard match that matches any " +
        "end of url and added to the end of the redirect URL");
            this.StarWildcardCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForceTypeComboBox
            // 
            this.ForceTypeComboBox.DisplayMember = "Name";
            this.ForceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForceTypeComboBox.FormattingEnabled = true;
            this.ForceTypeComboBox.Items.AddRange(new object[] {
            "Both",
            "From",
            "To"});
            this.ForceTypeComboBox.Location = new System.Drawing.Point(949, 301);
            this.ForceTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForceTypeComboBox.Name = "ForceTypeComboBox";
            this.ForceTypeComboBox.Size = new System.Drawing.Size(180, 28);
            this.ForceTypeComboBox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.ForceTypeComboBox, "Either match both or the to and from");
            this.ForceTypeComboBox.ValueMember = "Value";
            // 
            // AddTrailingFromSlashCheckBox
            // 
            this.AddTrailingFromSlashCheckBox.AutoSize = true;
            this.AddTrailingFromSlashCheckBox.Location = new System.Drawing.Point(356, 207);
            this.AddTrailingFromSlashCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddTrailingFromSlashCheckBox.Name = "AddTrailingFromSlashCheckBox";
            this.AddTrailingFromSlashCheckBox.Size = new System.Drawing.Size(280, 24);
            this.AddTrailingFromSlashCheckBox.TabIndex = 22;
            this.AddTrailingFromSlashCheckBox.Text = "Add Trailing From Slash On Old Url";
            this.toolTip1.SetToolTip(this.AddTrailingFromSlashCheckBox, "When checked adds a training slash on to the old URL. Used if missing in sheet");
            this.AddTrailingFromSlashCheckBox.UseVisualStyleBackColor = true;
            // 
            // EndWildCardMatch
            // 
            this.EndWildCardMatch.AutoSize = true;
            this.EndWildCardMatch.Location = new System.Drawing.Point(496, 159);
            this.EndWildCardMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndWildCardMatch.Name = "EndWildCardMatch";
            this.EndWildCardMatch.Size = new System.Drawing.Size(177, 24);
            this.EndWildCardMatch.TabIndex = 21;
            this.EndWildCardMatch.Text = "End Wildcard Match";
            this.toolTip1.SetToolTip(this.EndWildCardMatch, "When checked adds a wildcard match that matches any end of url and added to the e" +
        "nd of the redirect URL");
            this.EndWildCardMatch.UseVisualStyleBackColor = true;
            // 
            // ForcedDomainLabel
            // 
            this.ForcedDomainLabel.AutoSize = true;
            this.ForcedDomainLabel.Location = new System.Drawing.Point(16, 304);
            this.ForcedDomainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForcedDomainLabel.Name = "ForcedDomainLabel";
            this.ForcedDomainLabel.Size = new System.Drawing.Size(286, 20);
            this.ForcedDomainLabel.TabIndex = 20;
            this.ForcedDomainLabel.Text = "Force Domain (Including HTTP/HTTPS)";
            this.toolTip1.SetToolTip(this.ForcedDomainLabel, "When domain is force it replaces the set domain on a line based on set type of Bo" +
        "th, Old or New");
            // 
            // ForcedDomainTextBox
            // 
            this.ForcedDomainTextBox.Location = new System.Drawing.Point(486, 301);
            this.ForcedDomainTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ForcedDomainTextBox.Name = "ForcedDomainTextBox";
            this.ForcedDomainTextBox.Size = new System.Drawing.Size(455, 26);
            this.ForcedDomainTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.ForcedDomainTextBox, "If forced the domain will be used for a match even if the sheet contains none");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(908, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rule name prefix";
            // 
            // RuleNamePrefixTextBox
            // 
            this.RuleNamePrefixTextBox.Location = new System.Drawing.Point(1046, 157);
            this.RuleNamePrefixTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RuleNamePrefixTextBox.Name = "RuleNamePrefixTextBox";
            this.RuleNamePrefixTextBox.Size = new System.Drawing.Size(84, 26);
            this.RuleNamePrefixTextBox.TabIndex = 17;
            this.RuleNamePrefixTextBox.Text = "Rule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rule name start index";
            // 
            // RuleNameStartIndexTextBox
            // 
            this.RuleNameStartIndexTextBox.Location = new System.Drawing.Point(1046, 106);
            this.RuleNameStartIndexTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RuleNameStartIndexTextBox.Name = "RuleNameStartIndexTextBox";
            this.RuleNameStartIndexTextBox.Size = new System.Drawing.Size(84, 26);
            this.RuleNameStartIndexTextBox.TabIndex = 15;
            this.RuleNameStartIndexTextBox.Text = "1";
            // 
            // MatchDomainCheckBox
            // 
            this.MatchDomainCheckBox.AutoSize = true;
            this.MatchDomainCheckBox.Location = new System.Drawing.Point(356, 158);
            this.MatchDomainCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MatchDomainCheckBox.Name = "MatchDomainCheckBox";
            this.MatchDomainCheckBox.Size = new System.Drawing.Size(138, 24);
            this.MatchDomainCheckBox.TabIndex = 14;
            this.MatchDomainCheckBox.Text = "Match Domain";
            this.toolTip1.SetToolTip(this.MatchDomainCheckBox, "When checked the rule will only match the set domain, otherwise it will be relati" +
        "ve");
            this.MatchDomainCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateRedirectsCheckBox
            // 
            this.GenerateRedirectsCheckBox.AutoSize = true;
            this.GenerateRedirectsCheckBox.Location = new System.Drawing.Point(496, 106);
            this.GenerateRedirectsCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateRedirectsCheckBox.Name = "GenerateRedirectsCheckBox";
            this.GenerateRedirectsCheckBox.Size = new System.Drawing.Size(175, 24);
            this.GenerateRedirectsCheckBox.TabIndex = 13;
            this.GenerateRedirectsCheckBox.Text = "Generate Redirects";
            this.toolTip1.SetToolTip(this.GenerateRedirectsCheckBox, "If to create the rediect rules");
            this.GenerateRedirectsCheckBox.UseVisualStyleBackColor = true;
            // 
            // IgnoreLine1CheckBox
            // 
            this.IgnoreLine1CheckBox.AutoSize = true;
            this.IgnoreLine1CheckBox.Location = new System.Drawing.Point(356, 106);
            this.IgnoreLine1CheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IgnoreLine1CheckBox.Name = "IgnoreLine1CheckBox";
            this.IgnoreLine1CheckBox.Size = new System.Drawing.Size(128, 24);
            this.IgnoreLine1CheckBox.TabIndex = 13;
            this.IgnoreLine1CheckBox.Text = "Ignore Line 1";
            this.toolTip1.SetToolTip(this.IgnoreLine1CheckBox, "If the first line contains headings check to ignore");
            this.IgnoreLine1CheckBox.UseVisualStyleBackColor = true;
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(1046, 46);
            this.FileSelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(86, 35);
            this.FileSelectButton.TabIndex = 12;
            this.FileSelectButton.Text = "Select";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(15, 54);
            this.FileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(34, 20);
            this.FileLabel.TabIndex = 10;
            this.FileLabel.Text = "File";
            // 
            // PostmanGroupBox
            // 
            this.PostmanGroupBox.Controls.Add(this.label2);
            this.PostmanGroupBox.Controls.Add(this.CreateForEveryComboBox);
            this.PostmanGroupBox.Controls.Add(this.CreateForEveryLabel);
            this.PostmanGroupBox.Controls.Add(this.CollectionNameLabel);
            this.PostmanGroupBox.Controls.Add(this.GeneratePostmanTestsCheckBox);
            this.PostmanGroupBox.Controls.Add(this.CollectionNameTextBox);
            this.PostmanGroupBox.Location = new System.Drawing.Point(1161, 18);
            this.PostmanGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostmanGroupBox.Name = "PostmanGroupBox";
            this.PostmanGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostmanGroupBox.Size = new System.Drawing.Size(1140, 505);
            this.PostmanGroupBox.TabIndex = 11;
            this.PostmanGroupBox.TabStop = false;
            this.PostmanGroupBox.Text = "Postman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lines";
            // 
            // CreateForEveryComboBox
            // 
            this.CreateForEveryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreateForEveryComboBox.FormattingEnabled = true;
            this.CreateForEveryComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "All"});
            this.CreateForEveryComboBox.Location = new System.Drawing.Point(165, 103);
            this.CreateForEveryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateForEveryComboBox.Name = "CreateForEveryComboBox";
            this.CreateForEveryComboBox.Size = new System.Drawing.Size(76, 28);
            this.CreateForEveryComboBox.TabIndex = 17;
            // 
            // CreateForEveryLabel
            // 
            this.CreateForEveryLabel.AutoSize = true;
            this.CreateForEveryLabel.Location = new System.Drawing.Point(15, 108);
            this.CreateForEveryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateForEveryLabel.Name = "CreateForEveryLabel";
            this.CreateForEveryLabel.Size = new System.Drawing.Size(128, 20);
            this.CreateForEveryLabel.TabIndex = 16;
            this.CreateForEveryLabel.Text = "Create For Every";
            // 
            // CollectionNameLabel
            // 
            this.CollectionNameLabel.AutoSize = true;
            this.CollectionNameLabel.Location = new System.Drawing.Point(15, 163);
            this.CollectionNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CollectionNameLabel.Name = "CollectionNameLabel";
            this.CollectionNameLabel.Size = new System.Drawing.Size(124, 20);
            this.CollectionNameLabel.TabIndex = 12;
            this.CollectionNameLabel.Text = "Collection Name";
            // 
            // GeneratePostmanTestsCheckBox
            // 
            this.GeneratePostmanTestsCheckBox.AutoSize = true;
            this.GeneratePostmanTestsCheckBox.Location = new System.Drawing.Point(28, 52);
            this.GeneratePostmanTestsCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GeneratePostmanTestsCheckBox.Name = "GeneratePostmanTestsCheckBox";
            this.GeneratePostmanTestsCheckBox.Size = new System.Drawing.Size(213, 24);
            this.GeneratePostmanTestsCheckBox.TabIndex = 0;
            this.GeneratePostmanTestsCheckBox.Text = "Generate Postman Tests";
            this.toolTip1.SetToolTip(this.GeneratePostmanTestsCheckBox, "If to create the postman tests using v3 version");
            this.GeneratePostmanTestsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CollectionNameTextBox
            // 
            this.CollectionNameTextBox.Location = new System.Drawing.Point(165, 158);
            this.CollectionNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CollectionNameTextBox.Name = "CollectionNameTextBox";
            this.CollectionNameTextBox.Size = new System.Drawing.Size(964, 26);
            this.CollectionNameTextBox.TabIndex = 11;
            // 
            // CopyPostmanRules
            // 
            this.CopyPostmanRules.Location = new System.Drawing.Point(1161, 1347);
            this.CopyPostmanRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyPostmanRules.Name = "CopyPostmanRules";
            this.CopyPostmanRules.Size = new System.Drawing.Size(813, 35);
            this.CopyPostmanRules.TabIndex = 13;
            this.CopyPostmanRules.Text = "Copy To Clipboard";
            this.CopyPostmanRules.UseVisualStyleBackColor = true;
            this.CopyPostmanRules.Click += new System.EventHandler(this.CopyPostmanRules_Click);
            // 
            // PostmanTextBox
            // 
            this.PostmanTextBox.Location = new System.Drawing.Point(1161, 578);
            this.PostmanTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostmanTextBox.Multiline = true;
            this.PostmanTextBox.Name = "PostmanTextBox";
            this.PostmanTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PostmanTextBox.Size = new System.Drawing.Size(1135, 758);
            this.PostmanTextBox.TabIndex = 12;
            // 
            // SavePostmanButton
            // 
            this.SavePostmanButton.Location = new System.Drawing.Point(1983, 1347);
            this.SavePostmanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavePostmanButton.Name = "SavePostmanButton";
            this.SavePostmanButton.Size = new System.Drawing.Size(315, 35);
            this.SavePostmanButton.TabIndex = 14;
            this.SavePostmanButton.Text = "Save JSON";
            this.SavePostmanButton.UseVisualStyleBackColor = true;
            this.SavePostmanButton.Click += new System.EventHandler(this.SavePostmanButton_Click);
            // 
            // PostmanSave
            // 
            this.PostmanSave.Filter = "Postman Collection|*.postman_collection.json";
            this.PostmanSave.Title = "Save Postman Collection";
            // 
            // CopyRulesWithoutRuleNodeButton
            // 
            this.CopyRulesWithoutRuleNodeButton.Location = new System.Drawing.Point(588, 1347);
            this.CopyRulesWithoutRuleNodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CopyRulesWithoutRuleNodeButton.Name = "CopyRulesWithoutRuleNodeButton";
            this.CopyRulesWithoutRuleNodeButton.Size = new System.Drawing.Size(564, 35);
            this.CopyRulesWithoutRuleNodeButton.TabIndex = 15;
            this.CopyRulesWithoutRuleNodeButton.Text = "Copy To Clipboard (Rules Only)";
            this.CopyRulesWithoutRuleNodeButton.UseVisualStyleBackColor = true;
            this.CopyRulesWithoutRuleNodeButton.Click += new System.EventHandler(this.CopyRulesWithoutRuleNodeButton_Click);
            // 
            // AdditionalMatchDomains
            // 
            this.AdditionalMatchDomains.AutoSize = true;
            this.AdditionalMatchDomains.Location = new System.Drawing.Point(16, 353);
            this.AdditionalMatchDomains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdditionalMatchDomains.Name = "AdditionalMatchDomains";
            this.AdditionalMatchDomains.Size = new System.Drawing.Size(447, 20);
            this.AdditionalMatchDomains.TabIndex = 29;
            this.AdditionalMatchDomains.Text = "Additional Match Domains (One per line without HTTP/HTTPS)";
            this.toolTip1.SetToolTip(this.AdditionalMatchDomains, "When domain is force it replaces the set domain on a line based on set type of Bo" +
        "th, Old or New");
            this.AdditionalMatchDomains.Click += new System.EventHandler(this.AdditionalMatchDomains_Click);
            // 
            // AdditionalMatchDomainsTextBox
            // 
            this.AdditionalMatchDomainsTextBox.Location = new System.Drawing.Point(498, 368);
            this.AdditionalMatchDomainsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdditionalMatchDomainsTextBox.Multiline = true;
            this.AdditionalMatchDomainsTextBox.Name = "AdditionalMatchDomainsTextBox";
            this.AdditionalMatchDomainsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AdditionalMatchDomainsTextBox.Size = new System.Drawing.Size(643, 145);
            this.AdditionalMatchDomainsTextBox.TabIndex = 16;
            // 
            // RedirectGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2316, 1428);
            this.Controls.Add(this.AdditionalMatchDomainsTextBox);
            this.Controls.Add(this.CopyRulesWithoutRuleNodeButton);
            this.Controls.Add(this.SavePostmanButton);
            this.Controls.Add(this.CopyPostmanRules);
            this.Controls.Add(this.PostmanTextBox);
            this.Controls.Add(this.PostmanGroupBox);
            this.Controls.Add(this.GeneralGroupBox);
            this.Controls.Add(this.CopyRulesButton);
            this.Controls.Add(this.RulesTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RedirectGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redirect Generator";
            this.Load += new System.EventHandler(this.RedirectGenerator_Load);
            this.GeneralGroupBox.ResumeLayout(false);
            this.GeneralGroupBox.PerformLayout();
            this.PostmanGroupBox.ResumeLayout(false);
            this.PostmanGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog CsvOpenDialog;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox RulesTextBox;
        private System.Windows.Forms.Button CopyRulesButton;
        private System.Windows.Forms.ComboBox RedirectTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GeneralGroupBox;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.GroupBox PostmanGroupBox;
        private System.Windows.Forms.Label CollectionNameLabel;
        private System.Windows.Forms.CheckBox GeneratePostmanTestsCheckBox;
        private System.Windows.Forms.TextBox CollectionNameTextBox;
        private System.Windows.Forms.Button CopyPostmanRules;
        private System.Windows.Forms.TextBox PostmanTextBox;
        private System.Windows.Forms.CheckBox IgnoreLine1CheckBox;
        private System.Windows.Forms.CheckBox GenerateRedirectsCheckBox;
        private System.Windows.Forms.CheckBox MatchDomainCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CreateForEveryComboBox;
        private System.Windows.Forms.Label CreateForEveryLabel;
        private System.Windows.Forms.TextBox RuleNameStartIndexTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RuleNamePrefixTextBox;
        private System.Windows.Forms.Button SavePostmanButton;
        private System.Windows.Forms.SaveFileDialog PostmanSave;
        private System.Windows.Forms.Label ForcedDomainLabel;
        private System.Windows.Forms.TextBox ForcedDomainTextBox;
        private System.Windows.Forms.CheckBox EndWildCardMatch;
        private System.Windows.Forms.CheckBox AddTrailingFromSlashCheckBox;
        private System.Windows.Forms.ComboBox ForceTypeComboBox;
        private System.Windows.Forms.CheckBox StarWildcardCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox LinuxCheckBox;
        private System.Windows.Forms.CheckBox DuplicateSpaceWithPlusCheckBox;
        private System.Windows.Forms.CheckBox AppendQueryStringCheckBox;
        private System.Windows.Forms.CheckBox IgnoreQueryStringMatchCheckBox;
        private System.Windows.Forms.Button CopyRulesWithoutRuleNodeButton;
        private System.Windows.Forms.Label AdditionalMatchDomains;
        private System.Windows.Forms.TextBox AdditionalMatchDomainsTextBox;
    }
}

