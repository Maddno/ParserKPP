namespace ParserKupiProday
{
    partial class Form1
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
            this.StartPoint = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.NumericStart = new System.Windows.Forms.NumericUpDown();
            this.NumericEnd = new System.Windows.Forms.NumericUpDown();
            this.EndPoint = new System.Windows.Forms.Label();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonLinkStart = new System.Windows.Forms.Button();
            this.DataTitles = new System.Windows.Forms.ListBox();
            this.ButtonClean = new System.Windows.Forms.Button();
            this.CategorySelector = new System.Windows.Forms.ComboBox();
            this.LoadingVisLinks = new System.Windows.Forms.ProgressBar();
            this.SelectCategory = new System.Windows.Forms.Label();
            this.LinksSavePath = new System.Windows.Forms.TextBox();
            this.LinksSavesPathLable = new System.Windows.Forms.Label();
            this.LinksSavePathSelect = new System.Windows.Forms.Button();
            this.DataParsePathSelect = new System.Windows.Forms.Button();
            this.DataParsePathLable = new System.Windows.Forms.Label();
            this.DataLoadPath = new System.Windows.Forms.TextBox();
            this.DataSavePathSelect = new System.Windows.Forms.Button();
            this.DataSavesPathLable = new System.Windows.Forms.Label();
            this.DataSavePath = new System.Windows.Forms.TextBox();
            this.StartParseDataFrom = new System.Windows.Forms.NumericUpDown();
            this.ParseDataFrom = new System.Windows.Forms.Label();
            this.LoadingVisData = new System.Windows.Forms.ProgressBar();
            this.StopParseDataOn = new System.Windows.Forms.NumericUpDown();
            this.ParseDataTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubCategorySelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OblastSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartParseDataFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopParseDataOn)).BeginInit();
            this.SuspendLayout();
            // 
            // StartPoint
            // 
            this.StartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(474, 56);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(56, 13);
            this.StartPoint.TabIndex = 0;
            this.StartPoint.Text = "Start Point";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(477, 441);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(137, 40);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ListTitles
            // 
            this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(12, 99);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(456, 225);
            this.ListTitles.TabIndex = 2;
            // 
            // NumericStart
            // 
            this.NumericStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericStart.Location = new System.Drawing.Point(477, 72);
            this.NumericStart.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericStart.Name = "NumericStart";
            this.NumericStart.Size = new System.Drawing.Size(137, 20);
            this.NumericStart.TabIndex = 2;
            this.NumericStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericEnd
            // 
            this.NumericEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEnd.Location = new System.Drawing.Point(477, 115);
            this.NumericEnd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEnd.Name = "NumericEnd";
            this.NumericEnd.Size = new System.Drawing.Size(137, 20);
            this.NumericEnd.TabIndex = 5;
            this.NumericEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndPoint
            // 
            this.EndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndPoint.AutoSize = true;
            this.EndPoint.Location = new System.Drawing.Point(474, 99);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(53, 13);
            this.EndPoint.TabIndex = 4;
            this.EndPoint.Text = "End Point";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStop.Location = new System.Drawing.Point(477, 533);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(137, 40);
            this.ButtonStop.TabIndex = 6;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonLinkStart
            // 
            this.ButtonLinkStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLinkStart.Location = new System.Drawing.Point(477, 487);
            this.ButtonLinkStart.Name = "ButtonLinkStart";
            this.ButtonLinkStart.Size = new System.Drawing.Size(137, 40);
            this.ButtonLinkStart.TabIndex = 7;
            this.ButtonLinkStart.Text = "Link Parse";
            this.ButtonLinkStart.UseVisualStyleBackColor = true;
            this.ButtonLinkStart.Click += new System.EventHandler(this.ButtonLinkStart_Click);
            // 
            // DataTitles
            // 
            this.DataTitles.AllowDrop = true;
            this.DataTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTitles.FormattingEnabled = true;
            this.DataTitles.Location = new System.Drawing.Point(12, 330);
            this.DataTitles.Name = "DataTitles";
            this.DataTitles.Size = new System.Drawing.Size(456, 290);
            this.DataTitles.TabIndex = 8;
            // 
            // ButtonClean
            // 
            this.ButtonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClean.Location = new System.Drawing.Point(477, 579);
            this.ButtonClean.Name = "ButtonClean";
            this.ButtonClean.Size = new System.Drawing.Size(137, 41);
            this.ButtonClean.TabIndex = 9;
            this.ButtonClean.Text = "Clean";
            this.ButtonClean.UseVisualStyleBackColor = true;
            this.ButtonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // CategorySelector
            // 
            this.CategorySelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategorySelector.FormattingEnabled = true;
            this.CategorySelector.Location = new System.Drawing.Point(172, 72);
            this.CategorySelector.Name = "CategorySelector";
            this.CategorySelector.Size = new System.Drawing.Size(136, 21);
            this.CategorySelector.TabIndex = 11;
            this.CategorySelector.SelectedIndexChanged += new System.EventHandler(this.CategorySelector_SelectedIndexChanged);
            // 
            // LoadingVisLinks
            // 
            this.LoadingVisLinks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingVisLinks.ForeColor = System.Drawing.Color.Chartreuse;
            this.LoadingVisLinks.Location = new System.Drawing.Point(12, 23);
            this.LoadingVisLinks.Name = "LoadingVisLinks";
            this.LoadingVisLinks.Size = new System.Drawing.Size(602, 23);
            this.LoadingVisLinks.Step = 1;
            this.LoadingVisLinks.TabIndex = 12;
            // 
            // SelectCategory
            // 
            this.SelectCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectCategory.AutoSize = true;
            this.SelectCategory.Location = new System.Drawing.Point(169, 56);
            this.SelectCategory.Name = "SelectCategory";
            this.SelectCategory.Size = new System.Drawing.Size(44, 13);
            this.SelectCategory.TabIndex = 13;
            this.SelectCategory.Text = "Раздел";
            // 
            // LinksSavePath
            // 
            this.LinksSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksSavePath.Location = new System.Drawing.Point(477, 154);
            this.LinksSavePath.Name = "LinksSavePath";
            this.LinksSavePath.Size = new System.Drawing.Size(137, 20);
            this.LinksSavePath.TabIndex = 14;
            // 
            // LinksSavesPathLable
            // 
            this.LinksSavesPathLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksSavesPathLable.AutoSize = true;
            this.LinksSavesPathLable.Location = new System.Drawing.Point(474, 138);
            this.LinksSavesPathLable.Name = "LinksSavesPathLable";
            this.LinksSavesPathLable.Size = new System.Drawing.Size(77, 13);
            this.LinksSavesPathLable.TabIndex = 15;
            this.LinksSavesPathLable.Text = "Save links to...";
            // 
            // LinksSavePathSelect
            // 
            this.LinksSavePathSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinksSavePathSelect.Location = new System.Drawing.Point(477, 181);
            this.LinksSavePathSelect.Name = "LinksSavePathSelect";
            this.LinksSavePathSelect.Size = new System.Drawing.Size(137, 23);
            this.LinksSavePathSelect.TabIndex = 16;
            this.LinksSavePathSelect.Text = "Select";
            this.LinksSavePathSelect.UseVisualStyleBackColor = true;
            this.LinksSavePathSelect.Click += new System.EventHandler(this.LinksSavePathSelect_Click);
            // 
            // DataParsePathSelect
            // 
            this.DataParsePathSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataParsePathSelect.Location = new System.Drawing.Point(477, 252);
            this.DataParsePathSelect.Name = "DataParsePathSelect";
            this.DataParsePathSelect.Size = new System.Drawing.Size(137, 23);
            this.DataParsePathSelect.TabIndex = 19;
            this.DataParsePathSelect.Text = "Select";
            this.DataParsePathSelect.UseVisualStyleBackColor = true;
            this.DataParsePathSelect.Click += new System.EventHandler(this.DataParsePathSelect_Click);
            // 
            // DataParsePathLable
            // 
            this.DataParsePathLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataParsePathLable.AutoSize = true;
            this.DataParsePathLable.Location = new System.Drawing.Point(474, 209);
            this.DataParsePathLable.Name = "DataParsePathLable";
            this.DataParsePathLable.Size = new System.Drawing.Size(90, 13);
            this.DataParsePathLable.TabIndex = 18;
            this.DataParsePathLable.Text = "Parse data from...";
            // 
            // DataLoadPath
            // 
            this.DataLoadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataLoadPath.Location = new System.Drawing.Point(477, 225);
            this.DataLoadPath.Name = "DataLoadPath";
            this.DataLoadPath.Size = new System.Drawing.Size(137, 20);
            this.DataLoadPath.TabIndex = 17;
            this.DataLoadPath.TextChanged += new System.EventHandler(this.DataLoadPath_TextChanged);
            // 
            // DataSavePathSelect
            // 
            this.DataSavePathSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSavePathSelect.Location = new System.Drawing.Point(477, 321);
            this.DataSavePathSelect.Name = "DataSavePathSelect";
            this.DataSavePathSelect.Size = new System.Drawing.Size(137, 23);
            this.DataSavePathSelect.TabIndex = 22;
            this.DataSavePathSelect.Text = "Select";
            this.DataSavePathSelect.UseVisualStyleBackColor = true;
            this.DataSavePathSelect.Click += new System.EventHandler(this.DataSavePathSelect_Click);
            // 
            // DataSavesPathLable
            // 
            this.DataSavesPathLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSavesPathLable.AutoSize = true;
            this.DataSavesPathLable.Location = new System.Drawing.Point(474, 278);
            this.DataSavesPathLable.Name = "DataSavesPathLable";
            this.DataSavesPathLable.Size = new System.Drawing.Size(77, 13);
            this.DataSavesPathLable.TabIndex = 21;
            this.DataSavesPathLable.Text = "Save data to...";
            // 
            // DataSavePath
            // 
            this.DataSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSavePath.Location = new System.Drawing.Point(477, 294);
            this.DataSavePath.Name = "DataSavePath";
            this.DataSavePath.Size = new System.Drawing.Size(137, 20);
            this.DataSavePath.TabIndex = 20;
            // 
            // StartParseDataFrom
            // 
            this.StartParseDataFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartParseDataFrom.Location = new System.Drawing.Point(477, 367);
            this.StartParseDataFrom.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.StartParseDataFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartParseDataFrom.Name = "StartParseDataFrom";
            this.StartParseDataFrom.Size = new System.Drawing.Size(137, 20);
            this.StartParseDataFrom.TabIndex = 24;
            this.StartParseDataFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ParseDataFrom
            // 
            this.ParseDataFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParseDataFrom.AutoSize = true;
            this.ParseDataFrom.Location = new System.Drawing.Point(474, 351);
            this.ParseDataFrom.Name = "ParseDataFrom";
            this.ParseDataFrom.Size = new System.Drawing.Size(111, 13);
            this.ParseDataFrom.TabIndex = 23;
            this.ParseDataFrom.Text = "Start Parse Data From";
            // 
            // LoadingVisData
            // 
            this.LoadingVisData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingVisData.ForeColor = System.Drawing.Color.Chartreuse;
            this.LoadingVisData.Location = new System.Drawing.Point(12, 623);
            this.LoadingVisData.Name = "LoadingVisData";
            this.LoadingVisData.Size = new System.Drawing.Size(602, 23);
            this.LoadingVisData.Step = 1;
            this.LoadingVisData.TabIndex = 25;
            // 
            // StopParseDataOn
            // 
            this.StopParseDataOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopParseDataOn.Location = new System.Drawing.Point(477, 415);
            this.StopParseDataOn.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.StopParseDataOn.Name = "StopParseDataOn";
            this.StopParseDataOn.Size = new System.Drawing.Size(137, 20);
            this.StopParseDataOn.TabIndex = 27;
            // 
            // ParseDataTo
            // 
            this.ParseDataTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParseDataTo.AutoSize = true;
            this.ParseDataTo.Location = new System.Drawing.Point(474, 399);
            this.ParseDataTo.Name = "ParseDataTo";
            this.ParseDataTo.Size = new System.Drawing.Size(102, 13);
            this.ParseDataTo.TabIndex = 26;
            this.ParseDataTo.Text = "Stop Parse Data On";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Подраздел";
            // 
            // SubCategorySelector
            // 
            this.SubCategorySelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubCategorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCategorySelector.FormattingEnabled = true;
            this.SubCategorySelector.Location = new System.Drawing.Point(314, 72);
            this.SubCategorySelector.Name = "SubCategorySelector";
            this.SubCategorySelector.Size = new System.Drawing.Size(154, 21);
            this.SubCategorySelector.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Регион";
            // 
            // OblastSelector
            // 
            this.OblastSelector.FormattingEnabled = true;
            this.OblastSelector.Location = new System.Drawing.Point(12, 71);
            this.OblastSelector.Name = "OblastSelector";
            this.OblastSelector.Size = new System.Drawing.Size(154, 21);
            this.OblastSelector.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OblastSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubCategorySelector);
            this.Controls.Add(this.StopParseDataOn);
            this.Controls.Add(this.ParseDataTo);
            this.Controls.Add(this.LoadingVisData);
            this.Controls.Add(this.StartParseDataFrom);
            this.Controls.Add(this.ParseDataFrom);
            this.Controls.Add(this.DataSavePathSelect);
            this.Controls.Add(this.DataSavesPathLable);
            this.Controls.Add(this.DataSavePath);
            this.Controls.Add(this.DataParsePathSelect);
            this.Controls.Add(this.DataParsePathLable);
            this.Controls.Add(this.DataLoadPath);
            this.Controls.Add(this.LinksSavePathSelect);
            this.Controls.Add(this.LinksSavesPathLable);
            this.Controls.Add(this.LinksSavePath);
            this.Controls.Add(this.SelectCategory);
            this.Controls.Add(this.LoadingVisLinks);
            this.Controls.Add(this.CategorySelector);
            this.Controls.Add(this.ButtonClean);
            this.Controls.Add(this.DataTitles);
            this.Controls.Add(this.ButtonLinkStart);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.NumericEnd);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.NumericStart);
            this.Controls.Add(this.ListTitles);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.StartPoint);
            this.Name = "Form1";
            this.Text = "My Fitst Site Parser";
            ((System.ComponentModel.ISupportInitialize)(this.NumericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartParseDataFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopParseDataOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.NumericUpDown NumericStart;
        private System.Windows.Forms.NumericUpDown NumericEnd;
        private System.Windows.Forms.Label EndPoint;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonLinkStart;
        private System.Windows.Forms.ListBox DataTitles;
        private System.Windows.Forms.Button ButtonClean;
        private System.Windows.Forms.ComboBox CategorySelector;
        private System.Windows.Forms.Label SelectCategory;
        private System.Windows.Forms.TextBox LinksSavePath;
        private System.Windows.Forms.Label LinksSavesPathLable;
        private System.Windows.Forms.Button LinksSavePathSelect;
        private System.Windows.Forms.Button DataParsePathSelect;
        private System.Windows.Forms.Label DataParsePathLable;
        private System.Windows.Forms.TextBox DataLoadPath;
        private System.Windows.Forms.Button DataSavePathSelect;
        private System.Windows.Forms.Label DataSavesPathLable;
        private System.Windows.Forms.TextBox DataSavePath;
        public System.Windows.Forms.ProgressBar LoadingVisLinks;
        private System.Windows.Forms.NumericUpDown StartParseDataFrom;
        private System.Windows.Forms.Label ParseDataFrom;
        public System.Windows.Forms.ProgressBar LoadingVisData;
        private System.Windows.Forms.NumericUpDown StopParseDataOn;
        private System.Windows.Forms.Label ParseDataTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SubCategorySelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OblastSelector;
    }
}

