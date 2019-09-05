namespace RedirectGenerator
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
            this.CsvOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RulesTextBox = new System.Windows.Forms.TextBox();
            this.CopyRulesButton = new System.Windows.Forms.Button();
            this.RedirectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
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
            this.FileTextBox.Location = new System.Drawing.Point(110, 32);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(581, 20);
            this.FileTextBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(8, 158);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(1526, 23);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RulesTextBox
            // 
            this.RulesTextBox.Location = new System.Drawing.Point(8, 187);
            this.RulesTextBox.Multiline = true;
            this.RulesTextBox.Name = "RulesTextBox";
            this.RulesTextBox.Size = new System.Drawing.Size(754, 587);
            this.RulesTextBox.TabIndex = 2;
            // 
            // CopyRulesButton
            // 
            this.CopyRulesButton.Location = new System.Drawing.Point(8, 780);
            this.CopyRulesButton.Name = "CopyRulesButton";
            this.CopyRulesButton.Size = new System.Drawing.Size(754, 23);
            this.CopyRulesButton.TabIndex = 3;
            this.CopyRulesButton.Text = "Copy To Clipboard";
            this.CopyRulesButton.UseVisualStyleBackColor = true;
            this.CopyRulesButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // RedirectTypeComboBox
            // 
            this.RedirectTypeComboBox.DisplayMember = "Name";
            this.RedirectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RedirectTypeComboBox.FormattingEnabled = true;
            this.RedirectTypeComboBox.Location = new System.Drawing.Point(110, 67);
            this.RedirectTypeComboBox.Name = "RedirectTypeComboBox";
            this.RedirectTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.RedirectTypeComboBox.TabIndex = 7;
            this.RedirectTypeComboBox.ValueMember = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Redirect Type";
            // 
            // GeneralGroupBox
            // 
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
            this.GeneralGroupBox.Location = new System.Drawing.Point(8, 12);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(760, 140);
            this.GeneralGroupBox.TabIndex = 9;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "General";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(605, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rule name prefix";
            // 
            // RuleNamePrefixTextBox
            // 
            this.RuleNamePrefixTextBox.Location = new System.Drawing.Point(697, 102);
            this.RuleNamePrefixTextBox.Name = "RuleNamePrefixTextBox";
            this.RuleNamePrefixTextBox.Size = new System.Drawing.Size(57, 20);
            this.RuleNamePrefixTextBox.TabIndex = 17;
            this.RuleNamePrefixTextBox.Text = "Rule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rule name start index";
            // 
            // RuleNameStartIndexTextBox
            // 
            this.RuleNameStartIndexTextBox.Location = new System.Drawing.Point(697, 69);
            this.RuleNameStartIndexTextBox.Name = "RuleNameStartIndexTextBox";
            this.RuleNameStartIndexTextBox.Size = new System.Drawing.Size(57, 20);
            this.RuleNameStartIndexTextBox.TabIndex = 15;
            this.RuleNameStartIndexTextBox.Text = "1";
            // 
            // MatchDomainCheckBox
            // 
            this.MatchDomainCheckBox.AutoSize = true;
            this.MatchDomainCheckBox.Location = new System.Drawing.Point(455, 69);
            this.MatchDomainCheckBox.Name = "MatchDomainCheckBox";
            this.MatchDomainCheckBox.Size = new System.Drawing.Size(95, 17);
            this.MatchDomainCheckBox.TabIndex = 14;
            this.MatchDomainCheckBox.Text = "Match Domain";
            this.MatchDomainCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenerateRedirectsCheckBox
            // 
            this.GenerateRedirectsCheckBox.AutoSize = true;
            this.GenerateRedirectsCheckBox.Location = new System.Drawing.Point(331, 69);
            this.GenerateRedirectsCheckBox.Name = "GenerateRedirectsCheckBox";
            this.GenerateRedirectsCheckBox.Size = new System.Drawing.Size(118, 17);
            this.GenerateRedirectsCheckBox.TabIndex = 13;
            this.GenerateRedirectsCheckBox.Text = "Generate Redirects";
            this.GenerateRedirectsCheckBox.UseVisualStyleBackColor = true;
            // 
            // IgnoreLine1CheckBox
            // 
            this.IgnoreLine1CheckBox.AutoSize = true;
            this.IgnoreLine1CheckBox.Location = new System.Drawing.Point(237, 69);
            this.IgnoreLine1CheckBox.Name = "IgnoreLine1CheckBox";
            this.IgnoreLine1CheckBox.Size = new System.Drawing.Size(88, 17);
            this.IgnoreLine1CheckBox.TabIndex = 13;
            this.IgnoreLine1CheckBox.Text = "Ignore Line 1";
            this.IgnoreLine1CheckBox.UseVisualStyleBackColor = true;
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(697, 30);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(57, 23);
            this.FileSelectButton.TabIndex = 12;
            this.FileSelectButton.Text = "Select";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(10, 35);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(23, 13);
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
            this.PostmanGroupBox.Location = new System.Drawing.Point(774, 12);
            this.PostmanGroupBox.Name = "PostmanGroupBox";
            this.PostmanGroupBox.Size = new System.Drawing.Size(760, 140);
            this.PostmanGroupBox.TabIndex = 11;
            this.PostmanGroupBox.TabStop = false;
            this.PostmanGroupBox.Text = "Postman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
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
            this.CreateForEveryComboBox.Location = new System.Drawing.Point(110, 67);
            this.CreateForEveryComboBox.Name = "CreateForEveryComboBox";
            this.CreateForEveryComboBox.Size = new System.Drawing.Size(52, 21);
            this.CreateForEveryComboBox.TabIndex = 17;
            // 
            // CreateForEveryLabel
            // 
            this.CreateForEveryLabel.AutoSize = true;
            this.CreateForEveryLabel.Location = new System.Drawing.Point(10, 70);
            this.CreateForEveryLabel.Name = "CreateForEveryLabel";
            this.CreateForEveryLabel.Size = new System.Drawing.Size(86, 13);
            this.CreateForEveryLabel.TabIndex = 16;
            this.CreateForEveryLabel.Text = "Create For Every";
            // 
            // CollectionNameLabel
            // 
            this.CollectionNameLabel.AutoSize = true;
            this.CollectionNameLabel.Location = new System.Drawing.Point(10, 106);
            this.CollectionNameLabel.Name = "CollectionNameLabel";
            this.CollectionNameLabel.Size = new System.Drawing.Size(84, 13);
            this.CollectionNameLabel.TabIndex = 12;
            this.CollectionNameLabel.Text = "Collection Name";
            // 
            // GeneratePostmanTestsCheckBox
            // 
            this.GeneratePostmanTestsCheckBox.AutoSize = true;
            this.GeneratePostmanTestsCheckBox.Location = new System.Drawing.Point(19, 34);
            this.GeneratePostmanTestsCheckBox.Name = "GeneratePostmanTestsCheckBox";
            this.GeneratePostmanTestsCheckBox.Size = new System.Drawing.Size(143, 17);
            this.GeneratePostmanTestsCheckBox.TabIndex = 0;
            this.GeneratePostmanTestsCheckBox.Text = "Generate Postman Tests";
            this.GeneratePostmanTestsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CollectionNameTextBox
            // 
            this.CollectionNameTextBox.Location = new System.Drawing.Point(110, 103);
            this.CollectionNameTextBox.Name = "CollectionNameTextBox";
            this.CollectionNameTextBox.Size = new System.Drawing.Size(644, 20);
            this.CollectionNameTextBox.TabIndex = 11;
            // 
            // CopyPostmanRules
            // 
            this.CopyPostmanRules.Location = new System.Drawing.Point(774, 780);
            this.CopyPostmanRules.Name = "CopyPostmanRules";
            this.CopyPostmanRules.Size = new System.Drawing.Size(542, 23);
            this.CopyPostmanRules.TabIndex = 13;
            this.CopyPostmanRules.Text = "Copy To Clipboard";
            this.CopyPostmanRules.UseVisualStyleBackColor = true;
            this.CopyPostmanRules.Click += new System.EventHandler(this.CopyPostmanRules_Click);
            // 
            // PostmanTextBox
            // 
            this.PostmanTextBox.Location = new System.Drawing.Point(774, 187);
            this.PostmanTextBox.Multiline = true;
            this.PostmanTextBox.Name = "PostmanTextBox";
            this.PostmanTextBox.Size = new System.Drawing.Size(758, 587);
            this.PostmanTextBox.TabIndex = 12;
            // 
            // SavePostmanButton
            // 
            this.SavePostmanButton.Location = new System.Drawing.Point(1322, 780);
            this.SavePostmanButton.Name = "SavePostmanButton";
            this.SavePostmanButton.Size = new System.Drawing.Size(210, 23);
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
            // RedirectGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 815);
            this.Controls.Add(this.SavePostmanButton);
            this.Controls.Add(this.CopyPostmanRules);
            this.Controls.Add(this.PostmanTextBox);
            this.Controls.Add(this.PostmanGroupBox);
            this.Controls.Add(this.GeneralGroupBox);
            this.Controls.Add(this.CopyRulesButton);
            this.Controls.Add(this.RulesTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Name = "RedirectGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redirect Generator";
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
    }
}

