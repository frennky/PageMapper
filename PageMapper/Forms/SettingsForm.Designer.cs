namespace PageMapper.Forms
{
    partial class SettingsForm
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
            this.gbPageObjectProperties = new System.Windows.Forms.GroupBox();
            this.tbFileExtension = new System.Windows.Forms.TextBox();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.tbSaveLocation = new System.Windows.Forms.TextBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.btnOpenTemplate = new System.Windows.Forms.Button();
            this.gbBorder = new System.Windows.Forms.GroupBox();
            this.cmbBorderStyle = new System.Windows.Forms.ComboBox();
            this.lblBorderStyle = new System.Windows.Forms.Label();
            this.nudBorderWidth = new System.Windows.Forms.NumericUpDown();
            this.lblBorderWidth = new System.Windows.Forms.Label();
            this.btnChooseBorderColor = new System.Windows.Forms.Button();
            this.pbBorderColor = new System.Windows.Forms.PictureBox();
            this.lblBorderColor = new System.Windows.Forms.Label();
            this.gbBackgournd = new System.Windows.Forms.GroupBox();
            this.btnChooseBackgroundColor = new System.Windows.Forms.Button();
            this.pbBackgroundColor = new System.Windows.Forms.PictureBox();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.gbErrorLog = new System.Windows.Forms.GroupBox();
            this.btnBrowseLogFolder = new System.Windows.Forms.Button();
            this.tbLogFolder = new System.Windows.Forms.TextBox();
            this.lblLogFolder = new System.Windows.Forms.Label();
            this.chbLogErrors = new System.Windows.Forms.CheckBox();
            this.tbLogFilename = new System.Windows.Forms.TextBox();
            this.lblLogFilename = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbWarning = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gbSelectionStyle = new System.Windows.Forms.GroupBox();
            this.gbTemplates = new System.Windows.Forms.GroupBox();
            this.btnBrowseTemplateFolder = new System.Windows.Forms.Button();
            this.tbTemplateFolder = new System.Windows.Forms.TextBox();
            this.lblTemplateFolder = new System.Windows.Forms.Label();
            this.tbTemplateFilter = new System.Windows.Forms.TextBox();
            this.lblTemplateFilter = new System.Windows.Forms.Label();
            this.gbPageObjectProperties.SuspendLayout();
            this.gbBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorderColor)).BeginInit();
            this.gbBackgournd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundColor)).BeginInit();
            this.gbErrorLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).BeginInit();
            this.gbSelectionStyle.SuspendLayout();
            this.gbTemplates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPageObjectProperties
            // 
            this.gbPageObjectProperties.Controls.Add(this.tbFileExtension);
            this.gbPageObjectProperties.Controls.Add(this.lblFileExtension);
            this.gbPageObjectProperties.Controls.Add(this.lblClassName);
            this.gbPageObjectProperties.Controls.Add(this.tbClassName);
            this.gbPageObjectProperties.Controls.Add(this.btnBrowse);
            this.gbPageObjectProperties.Controls.Add(this.lblUrl);
            this.gbPageObjectProperties.Controls.Add(this.tbUrl);
            this.gbPageObjectProperties.Controls.Add(this.lblSaveLocation);
            this.gbPageObjectProperties.Controls.Add(this.tbSaveLocation);
            this.gbPageObjectProperties.Location = new System.Drawing.Point(12, 12);
            this.gbPageObjectProperties.Name = "gbPageObjectProperties";
            this.gbPageObjectProperties.Size = new System.Drawing.Size(560, 131);
            this.gbPageObjectProperties.TabIndex = 24;
            this.gbPageObjectProperties.TabStop = false;
            this.gbPageObjectProperties.Text = "Page Object";
            // 
            // tbFileExtension
            // 
            this.tbFileExtension.Location = new System.Drawing.Point(111, 98);
            this.tbFileExtension.Name = "tbFileExtension";
            this.tbFileExtension.Size = new System.Drawing.Size(443, 20);
            this.tbFileExtension.TabIndex = 37;
            this.tbFileExtension.TextChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Location = new System.Drawing.Point(8, 101);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(71, 13);
            this.lblFileExtension.TabIndex = 36;
            this.lblFileExtension.Text = "File extension";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(7, 21);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(63, 13);
            this.lblClassName.TabIndex = 29;
            this.lblClassName.Text = "Class Name";
            // 
            // tbClassName
            // 
            this.tbClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClassName.Location = new System.Drawing.Point(111, 19);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(442, 20);
            this.tbClassName.TabIndex = 28;
            this.tbClassName.TextChanged += new System.EventHandler(this.setting_Changed);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Image = global::PageMapper.Properties.Resources.Folder;
            this.btnBrowse.Location = new System.Drawing.Point(526, 68);
            this.btnBrowse.MaximumSize = new System.Drawing.Size(28, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 24);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(7, 48);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 25;
            this.lblUrl.Text = "URL";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(111, 45);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(443, 20);
            this.tbUrl.TabIndex = 21;
            this.tbUrl.TextChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(7, 74);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(72, 13);
            this.lblSaveLocation.TabIndex = 26;
            this.lblSaveLocation.Text = "Save location";
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaveLocation.Location = new System.Drawing.Point(111, 71);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.Size = new System.Drawing.Size(409, 20);
            this.tbSaveLocation.TabIndex = 24;
            this.tbSaveLocation.TextChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(6, 24);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(51, 13);
            this.lblTemplate.TabIndex = 36;
            this.lblTemplate.Text = "Template";
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(110, 21);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(381, 21);
            this.cmbTemplates.Sorted = true;
            this.cmbTemplates.TabIndex = 39;
            this.cmbTemplates.SelectedValueChanged += new System.EventHandler(this.setting_Changed);
            // 
            // btnOpenTemplate
            // 
            this.btnOpenTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTemplate.Image = global::PageMapper.Properties.Resources.View;
            this.btnOpenTemplate.Location = new System.Drawing.Point(497, 18);
            this.btnOpenTemplate.MaximumSize = new System.Drawing.Size(56, 28);
            this.btnOpenTemplate.MinimumSize = new System.Drawing.Size(56, 28);
            this.btnOpenTemplate.Name = "btnOpenTemplate";
            this.btnOpenTemplate.Size = new System.Drawing.Size(56, 28);
            this.btnOpenTemplate.TabIndex = 38;
            this.btnOpenTemplate.UseVisualStyleBackColor = true;
            this.btnOpenTemplate.Click += new System.EventHandler(this.btnOpenTemplate_Click);
            // 
            // gbBorder
            // 
            this.gbBorder.Controls.Add(this.cmbBorderStyle);
            this.gbBorder.Controls.Add(this.lblBorderStyle);
            this.gbBorder.Controls.Add(this.nudBorderWidth);
            this.gbBorder.Controls.Add(this.lblBorderWidth);
            this.gbBorder.Controls.Add(this.btnChooseBorderColor);
            this.gbBorder.Controls.Add(this.pbBorderColor);
            this.gbBorder.Controls.Add(this.lblBorderColor);
            this.gbBorder.Location = new System.Drawing.Point(5, 18);
            this.gbBorder.Margin = new System.Windows.Forms.Padding(2);
            this.gbBorder.Name = "gbBorder";
            this.gbBorder.Padding = new System.Windows.Forms.Padding(2);
            this.gbBorder.Size = new System.Drawing.Size(314, 101);
            this.gbBorder.TabIndex = 25;
            this.gbBorder.TabStop = false;
            this.gbBorder.Text = "Border";
            // 
            // cmbBorderStyle
            // 
            this.cmbBorderStyle.FormattingEnabled = true;
            this.cmbBorderStyle.Location = new System.Drawing.Point(105, 41);
            this.cmbBorderStyle.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBorderStyle.Name = "cmbBorderStyle";
            this.cmbBorderStyle.Size = new System.Drawing.Size(186, 21);
            this.cmbBorderStyle.TabIndex = 9;
            this.cmbBorderStyle.SelectedValueChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblBorderStyle
            // 
            this.lblBorderStyle.AutoSize = true;
            this.lblBorderStyle.Location = new System.Drawing.Point(6, 44);
            this.lblBorderStyle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorderStyle.Name = "lblBorderStyle";
            this.lblBorderStyle.Size = new System.Drawing.Size(30, 13);
            this.lblBorderStyle.TabIndex = 8;
            this.lblBorderStyle.Text = "Style";
            // 
            // nudBorderWidth
            // 
            this.nudBorderWidth.Location = new System.Drawing.Point(105, 17);
            this.nudBorderWidth.Margin = new System.Windows.Forms.Padding(2);
            this.nudBorderWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBorderWidth.Name = "nudBorderWidth";
            this.nudBorderWidth.Size = new System.Drawing.Size(186, 20);
            this.nudBorderWidth.TabIndex = 7;
            this.nudBorderWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBorderWidth.ValueChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblBorderWidth
            // 
            this.lblBorderWidth.AutoSize = true;
            this.lblBorderWidth.Location = new System.Drawing.Point(6, 19);
            this.lblBorderWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorderWidth.Name = "lblBorderWidth";
            this.lblBorderWidth.Size = new System.Drawing.Size(35, 13);
            this.lblBorderWidth.TabIndex = 6;
            this.lblBorderWidth.Text = "Width";
            // 
            // btnChooseBorderColor
            // 
            this.btnChooseBorderColor.Image = global::PageMapper.Properties.Resources.Pick;
            this.btnChooseBorderColor.Location = new System.Drawing.Point(263, 66);
            this.btnChooseBorderColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseBorderColor.Name = "btnChooseBorderColor";
            this.btnChooseBorderColor.Size = new System.Drawing.Size(28, 28);
            this.btnChooseBorderColor.TabIndex = 5;
            this.btnChooseBorderColor.UseVisualStyleBackColor = true;
            this.btnChooseBorderColor.Click += new System.EventHandler(this.btnChooseBorderColor_Click);
            // 
            // pbBorderColor
            // 
            this.pbBorderColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBorderColor.Location = new System.Drawing.Point(105, 66);
            this.pbBorderColor.Margin = new System.Windows.Forms.Padding(2);
            this.pbBorderColor.Name = "pbBorderColor";
            this.pbBorderColor.Size = new System.Drawing.Size(112, 28);
            this.pbBorderColor.TabIndex = 4;
            this.pbBorderColor.TabStop = false;
            this.pbBorderColor.BackColorChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblBorderColor
            // 
            this.lblBorderColor.AutoSize = true;
            this.lblBorderColor.Location = new System.Drawing.Point(6, 72);
            this.lblBorderColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorderColor.Name = "lblBorderColor";
            this.lblBorderColor.Size = new System.Drawing.Size(31, 13);
            this.lblBorderColor.TabIndex = 3;
            this.lblBorderColor.Text = "Color";
            // 
            // gbBackgournd
            // 
            this.gbBackgournd.Controls.Add(this.btnChooseBackgroundColor);
            this.gbBackgournd.Controls.Add(this.pbBackgroundColor);
            this.gbBackgournd.Controls.Add(this.lblBackgroundColor);
            this.gbBackgournd.Location = new System.Drawing.Point(323, 18);
            this.gbBackgournd.Margin = new System.Windows.Forms.Padding(2);
            this.gbBackgournd.Name = "gbBackgournd";
            this.gbBackgournd.Padding = new System.Windows.Forms.Padding(2);
            this.gbBackgournd.Size = new System.Drawing.Size(232, 101);
            this.gbBackgournd.TabIndex = 26;
            this.gbBackgournd.TabStop = false;
            this.gbBackgournd.Text = "Background";
            // 
            // btnChooseBackgroundColor
            // 
            this.btnChooseBackgroundColor.Image = global::PageMapper.Properties.Resources.Pick;
            this.btnChooseBackgroundColor.Location = new System.Drawing.Point(200, 17);
            this.btnChooseBackgroundColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseBackgroundColor.Name = "btnChooseBackgroundColor";
            this.btnChooseBackgroundColor.Size = new System.Drawing.Size(28, 28);
            this.btnChooseBackgroundColor.TabIndex = 2;
            this.btnChooseBackgroundColor.UseVisualStyleBackColor = true;
            this.btnChooseBackgroundColor.Click += new System.EventHandler(this.btnChooseBackgroundColor_Click);
            // 
            // pbBackgroundColor
            // 
            this.pbBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackgroundColor.Location = new System.Drawing.Point(75, 17);
            this.pbBackgroundColor.Margin = new System.Windows.Forms.Padding(2);
            this.pbBackgroundColor.Name = "pbBackgroundColor";
            this.pbBackgroundColor.Size = new System.Drawing.Size(112, 28);
            this.pbBackgroundColor.TabIndex = 1;
            this.pbBackgroundColor.TabStop = false;
            this.pbBackgroundColor.BackColorChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(4, 24);
            this.lblBackgroundColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(31, 13);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Color";
            // 
            // gbErrorLog
            // 
            this.gbErrorLog.Controls.Add(this.btnBrowseLogFolder);
            this.gbErrorLog.Controls.Add(this.tbLogFolder);
            this.gbErrorLog.Controls.Add(this.lblLogFolder);
            this.gbErrorLog.Controls.Add(this.chbLogErrors);
            this.gbErrorLog.Controls.Add(this.tbLogFilename);
            this.gbErrorLog.Controls.Add(this.lblLogFilename);
            this.gbErrorLog.Location = new System.Drawing.Point(12, 404);
            this.gbErrorLog.Name = "gbErrorLog";
            this.gbErrorLog.Size = new System.Drawing.Size(560, 100);
            this.gbErrorLog.TabIndex = 27;
            this.gbErrorLog.TabStop = false;
            this.gbErrorLog.Text = "Error Logging";
            // 
            // btnBrowseLogFolder
            // 
            this.btnBrowseLogFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseLogFolder.Image = global::PageMapper.Properties.Resources.Folder;
            this.btnBrowseLogFolder.Location = new System.Drawing.Point(526, 66);
            this.btnBrowseLogFolder.MaximumSize = new System.Drawing.Size(28, 28);
            this.btnBrowseLogFolder.Name = "btnBrowseLogFolder";
            this.btnBrowseLogFolder.Size = new System.Drawing.Size(28, 24);
            this.btnBrowseLogFolder.TabIndex = 28;
            this.btnBrowseLogFolder.UseVisualStyleBackColor = true;
            this.btnBrowseLogFolder.Click += new System.EventHandler(this.btnBrowseLogFolder_Click);
            // 
            // tbLogFolder
            // 
            this.tbLogFolder.Location = new System.Drawing.Point(110, 69);
            this.tbLogFolder.Name = "tbLogFolder";
            this.tbLogFolder.Size = new System.Drawing.Size(410, 20);
            this.tbLogFolder.TabIndex = 4;
            this.tbLogFolder.TextChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblLogFolder
            // 
            this.lblLogFolder.AutoSize = true;
            this.lblLogFolder.Location = new System.Drawing.Point(3, 72);
            this.lblLogFolder.Name = "lblLogFolder";
            this.lblLogFolder.Size = new System.Drawing.Size(54, 13);
            this.lblLogFolder.TabIndex = 3;
            this.lblLogFolder.Text = "Log folder";
            // 
            // chbLogErrors
            // 
            this.chbLogErrors.AutoSize = true;
            this.chbLogErrors.Location = new System.Drawing.Point(6, 20);
            this.chbLogErrors.Name = "chbLogErrors";
            this.chbLogErrors.Size = new System.Drawing.Size(73, 17);
            this.chbLogErrors.TabIndex = 2;
            this.chbLogErrors.Text = "Log errors";
            this.chbLogErrors.UseVisualStyleBackColor = true;
            this.chbLogErrors.CheckedChanged += new System.EventHandler(this.chbLogErrors_CheckedChanged);
            // 
            // tbLogFilename
            // 
            this.tbLogFilename.Location = new System.Drawing.Point(110, 43);
            this.tbLogFilename.Name = "tbLogFilename";
            this.tbLogFilename.Size = new System.Drawing.Size(443, 20);
            this.tbLogFilename.TabIndex = 1;
            this.tbLogFilename.TextChanged += new System.EventHandler(this.setting_Changed);
            // 
            // lblLogFilename
            // 
            this.lblLogFilename.AutoSize = true;
            this.lblLogFilename.Location = new System.Drawing.Point(3, 46);
            this.lblLogFilename.Name = "lblLogFilename";
            this.lblLogFilename.Size = new System.Drawing.Size(67, 13);
            this.lblLogFilename.TabIndex = 0;
            this.lblLogFilename.Text = "Log filename";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(426, 526);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(70, 23);
            this.btnApply.TabIndex = 30;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(502, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbWarning
            // 
            this.pbWarning.Image = global::PageMapper.Properties.Resources.Warning;
            this.pbWarning.Location = new System.Drawing.Point(12, 528);
            this.pbWarning.Name = "pbWarning";
            this.pbWarning.Size = new System.Drawing.Size(16, 16);
            this.pbWarning.TabIndex = 32;
            this.pbWarning.TabStop = false;
            this.pbWarning.Visible = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(35, 531);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(309, 13);
            this.lblWarning.TabIndex = 33;
            this.lblWarning.Text = "In order for changes to take effect please restart the application.";
            this.lblWarning.Visible = false;
            // 
            // gbSelectionStyle
            // 
            this.gbSelectionStyle.Controls.Add(this.gbBackgournd);
            this.gbSelectionStyle.Controls.Add(this.gbBorder);
            this.gbSelectionStyle.Location = new System.Drawing.Point(12, 265);
            this.gbSelectionStyle.Name = "gbSelectionStyle";
            this.gbSelectionStyle.Size = new System.Drawing.Size(560, 133);
            this.gbSelectionStyle.TabIndex = 34;
            this.gbSelectionStyle.TabStop = false;
            this.gbSelectionStyle.Text = "Selection Style";
            // 
            // gbTemplates
            // 
            this.gbTemplates.Controls.Add(this.lblTemplate);
            this.gbTemplates.Controls.Add(this.btnBrowseTemplateFolder);
            this.gbTemplates.Controls.Add(this.cmbTemplates);
            this.gbTemplates.Controls.Add(this.btnOpenTemplate);
            this.gbTemplates.Controls.Add(this.tbTemplateFolder);
            this.gbTemplates.Controls.Add(this.lblTemplateFolder);
            this.gbTemplates.Controls.Add(this.tbTemplateFilter);
            this.gbTemplates.Controls.Add(this.lblTemplateFilter);
            this.gbTemplates.Location = new System.Drawing.Point(12, 149);
            this.gbTemplates.Name = "gbTemplates";
            this.gbTemplates.Size = new System.Drawing.Size(560, 110);
            this.gbTemplates.TabIndex = 35;
            this.gbTemplates.TabStop = false;
            this.gbTemplates.Text = "Templates";
            // 
            // btnBrowseTemplateFolder
            // 
            this.btnBrowseTemplateFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTemplateFolder.Image = global::PageMapper.Properties.Resources.Folder;
            this.btnBrowseTemplateFolder.Location = new System.Drawing.Point(526, 71);
            this.btnBrowseTemplateFolder.MaximumSize = new System.Drawing.Size(28, 28);
            this.btnBrowseTemplateFolder.Name = "btnBrowseTemplateFolder";
            this.btnBrowseTemplateFolder.Size = new System.Drawing.Size(28, 24);
            this.btnBrowseTemplateFolder.TabIndex = 33;
            this.btnBrowseTemplateFolder.UseVisualStyleBackColor = true;
            this.btnBrowseTemplateFolder.Click += new System.EventHandler(this.btnBrowseTemplateFolder_Click);
            // 
            // tbTemplateFolder
            // 
            this.tbTemplateFolder.Location = new System.Drawing.Point(110, 74);
            this.tbTemplateFolder.Name = "tbTemplateFolder";
            this.tbTemplateFolder.Size = new System.Drawing.Size(410, 20);
            this.tbTemplateFolder.TabIndex = 32;
            this.tbTemplateFolder.TextChanged += new System.EventHandler(this.tbTemplateFolder_TextChanged);
            // 
            // lblTemplateFolder
            // 
            this.lblTemplateFolder.AutoSize = true;
            this.lblTemplateFolder.Location = new System.Drawing.Point(3, 77);
            this.lblTemplateFolder.Name = "lblTemplateFolder";
            this.lblTemplateFolder.Size = new System.Drawing.Size(80, 13);
            this.lblTemplateFolder.TabIndex = 31;
            this.lblTemplateFolder.Text = "Template folder";
            // 
            // tbTemplateFilter
            // 
            this.tbTemplateFilter.Location = new System.Drawing.Point(110, 48);
            this.tbTemplateFilter.Name = "tbTemplateFilter";
            this.tbTemplateFilter.Size = new System.Drawing.Size(443, 20);
            this.tbTemplateFilter.TabIndex = 30;
            this.tbTemplateFilter.TextChanged += new System.EventHandler(this.tbTemplateFilter_TextChanged);
            // 
            // lblTemplateFilter
            // 
            this.lblTemplateFilter.AutoSize = true;
            this.lblTemplateFilter.Location = new System.Drawing.Point(3, 51);
            this.lblTemplateFilter.Name = "lblTemplateFilter";
            this.lblTemplateFilter.Size = new System.Drawing.Size(73, 13);
            this.lblTemplateFilter.TabIndex = 29;
            this.lblTemplateFilter.Text = "Template filter";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.gbTemplates);
            this.Controls.Add(this.gbSelectionStyle);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.pbWarning);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbErrorLog);
            this.Controls.Add(this.gbPageObjectProperties);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Default Settings";
            this.gbPageObjectProperties.ResumeLayout(false);
            this.gbPageObjectProperties.PerformLayout();
            this.gbBorder.ResumeLayout(false);
            this.gbBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBorderColor)).EndInit();
            this.gbBackgournd.ResumeLayout(false);
            this.gbBackgournd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackgroundColor)).EndInit();
            this.gbErrorLog.ResumeLayout(false);
            this.gbErrorLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarning)).EndInit();
            this.gbSelectionStyle.ResumeLayout(false);
            this.gbTemplates.ResumeLayout(false);
            this.gbTemplates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPageObjectProperties;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Button btnOpenTemplate;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.GroupBox gbBorder;
        private System.Windows.Forms.ComboBox cmbBorderStyle;
        private System.Windows.Forms.Label lblBorderStyle;
        private System.Windows.Forms.NumericUpDown nudBorderWidth;
        private System.Windows.Forms.Label lblBorderWidth;
        private System.Windows.Forms.Button btnChooseBorderColor;
        private System.Windows.Forms.PictureBox pbBorderColor;
        private System.Windows.Forms.Label lblBorderColor;
        private System.Windows.Forms.GroupBox gbBackgournd;
        private System.Windows.Forms.Button btnChooseBackgroundColor;
        private System.Windows.Forms.PictureBox pbBackgroundColor;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.GroupBox gbErrorLog;
        private System.Windows.Forms.CheckBox chbLogErrors;
        private System.Windows.Forms.TextBox tbLogFilename;
        private System.Windows.Forms.Label lblLogFilename;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox tbLogFolder;
        private System.Windows.Forms.Label lblLogFolder;
        private System.Windows.Forms.GroupBox gbSelectionStyle;
        private System.Windows.Forms.Button btnBrowseLogFolder;
        private System.Windows.Forms.GroupBox gbTemplates;
        private System.Windows.Forms.Button btnBrowseTemplateFolder;
        private System.Windows.Forms.TextBox tbTemplateFolder;
        private System.Windows.Forms.Label lblTemplateFolder;
        private System.Windows.Forms.TextBox tbTemplateFilter;
        private System.Windows.Forms.Label lblTemplateFilter;
        private System.Windows.Forms.TextBox tbFileExtension;
        private System.Windows.Forms.Label lblFileExtension;
    }
}