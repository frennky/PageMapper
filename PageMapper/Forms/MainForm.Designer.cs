namespace PageMapper.Forms
{
    partial class MainForm
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
            this.tsbOpenWebBrowser = new System.Windows.Forms.ToolStripButton();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.tsddbChooseSelectionStyle = new System.Windows.Forms.ToolStripDropDownButton();
            this.borderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbResetStyles = new System.Windows.Forms.ToolStripButton();
            this.gbPageObjectProperties = new System.Windows.Forms.GroupBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.btnOpenTemplate = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.tbSaveLocation = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSelectedElement = new System.Windows.Forms.GroupBox();
            this.lblElementHtml = new System.Windows.Forms.Label();
            this.tbElementHtml = new System.Windows.Forms.TextBox();
            this.lblElementTagName = new System.Windows.Forms.Label();
            this.tbElementTagName = new System.Windows.Forms.TextBox();
            this.lblElementClassName = new System.Windows.Forms.Label();
            this.tbElementClassName = new System.Windows.Forms.TextBox();
            this.lblElementName = new System.Windows.Forms.Label();
            this.tbElementName = new System.Windows.Forms.TextBox();
            this.lblElementId = new System.Windows.Forms.Label();
            this.tbElementId = new System.Windows.Forms.TextBox();
            this.cmbFindBy = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.tbPropertyName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPropertyName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblPropertyLocator = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPropertyKey = new System.Windows.Forms.TextBox();
            this.gbPageProperties = new System.Windows.Forms.GroupBox();
            this.lsbPageProperties = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.gbPageObjectProperties.SuspendLayout();
            this.gbSelectedElement.SuspendLayout();
            this.gbPageProperties.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbOpenWebBrowser
            // 
            this.tsbOpenWebBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenWebBrowser.Image = global::PageMapper.Properties.Resources.Browser;
            this.tsbOpenWebBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenWebBrowser.Name = "tsbOpenWebBrowser";
            this.tsbOpenWebBrowser.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenWebBrowser.Text = "Open WebBrowser";
            this.tsbOpenWebBrowser.Click += new System.EventHandler(this.tsbOpenWebBrowser_Click);
            // 
            // tsbReset
            // 
            this.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReset.Image = global::PageMapper.Properties.Resources.Reset;
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(23, 22);
            this.tsbReset.Text = "Reset";
            this.tsbReset.Click += new System.EventHandler(this.tsbReset_Click);
            // 
            // tsbSettings
            // 
            this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettings.Image = global::PageMapper.Properties.Resources.Settings;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(23, 22);
            this.tsbSettings.Text = "Settings";
            this.tsbSettings.Click += new System.EventHandler(this.tsbSettings_Click);
            // 
            // tsddbChooseSelectionStyle
            // 
            this.tsddbChooseSelectionStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbChooseSelectionStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borderToolStripMenuItem,
            this.backgroundToolStripMenuItem});
            this.tsddbChooseSelectionStyle.Image = global::PageMapper.Properties.Resources.Style;
            this.tsddbChooseSelectionStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbChooseSelectionStyle.Name = "tsddbChooseSelectionStyle";
            this.tsddbChooseSelectionStyle.Size = new System.Drawing.Size(29, 22);
            this.tsddbChooseSelectionStyle.Text = "Choose Selection Style";
            // 
            // borderToolStripMenuItem
            // 
            this.borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            this.borderToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.borderToolStripMenuItem.Text = "Border";
            this.borderToolStripMenuItem.Click += new System.EventHandler(this.selectionStyleMenuItem_Click);
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.selectionStyleMenuItem_Click);
            // 
            // tsbResetStyles
            // 
            this.tsbResetStyles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbResetStyles.Image = global::PageMapper.Properties.Resources.ResetStyles;
            this.tsbResetStyles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResetStyles.Name = "tsbResetStyles";
            this.tsbResetStyles.Size = new System.Drawing.Size(23, 22);
            this.tsbResetStyles.Text = "Reset Styles";
            this.tsbResetStyles.Click += new System.EventHandler(this.tsbResetStyles_Click);
            // 
            // gbPageObjectProperties
            // 
            this.gbPageObjectProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPageObjectProperties.Controls.Add(this.lblTemplate);
            this.gbPageObjectProperties.Controls.Add(this.cmbTemplates);
            this.gbPageObjectProperties.Controls.Add(this.btnOpenTemplate);
            this.gbPageObjectProperties.Controls.Add(this.lblClassName);
            this.gbPageObjectProperties.Controls.Add(this.tbClassName);
            this.gbPageObjectProperties.Controls.Add(this.btnBrowse);
            this.gbPageObjectProperties.Controls.Add(this.lblUrl);
            this.gbPageObjectProperties.Controls.Add(this.tbUrl);
            this.gbPageObjectProperties.Controls.Add(this.lblSaveLocation);
            this.gbPageObjectProperties.Controls.Add(this.tbSaveLocation);
            this.gbPageObjectProperties.Controls.Add(this.btnPreview);
            this.gbPageObjectProperties.Controls.Add(this.btnSave);
            this.gbPageObjectProperties.Location = new System.Drawing.Point(10, 589);
            this.gbPageObjectProperties.Name = "gbPageObjectProperties";
            this.gbPageObjectProperties.Size = new System.Drawing.Size(650, 153);
            this.gbPageObjectProperties.TabIndex = 23;
            this.gbPageObjectProperties.TabStop = false;
            this.gbPageObjectProperties.Text = "Page Object";
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(7, 76);
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
            this.cmbTemplates.Location = new System.Drawing.Point(111, 73);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(353, 21);
            this.cmbTemplates.Sorted = true;
            this.cmbTemplates.TabIndex = 39;
            // 
            // btnOpenTemplate
            // 
            this.btnOpenTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTemplate.Image = global::PageMapper.Properties.Resources.View;
            this.btnOpenTemplate.Location = new System.Drawing.Point(470, 71);
            this.btnOpenTemplate.MaximumSize = new System.Drawing.Size(56, 28);
            this.btnOpenTemplate.MinimumSize = new System.Drawing.Size(56, 28);
            this.btnOpenTemplate.Name = "btnOpenTemplate";
            this.btnOpenTemplate.Size = new System.Drawing.Size(56, 28);
            this.btnOpenTemplate.TabIndex = 38;
            this.btnOpenTemplate.UseVisualStyleBackColor = true;
            this.btnOpenTemplate.Click += new System.EventHandler(this.btnOpenTemplate_Click);
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
            this.tbClassName.Size = new System.Drawing.Size(533, 20);
            this.tbClassName.TabIndex = 28;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Image = global::PageMapper.Properties.Resources.Folder;
            this.btnBrowse.Location = new System.Drawing.Point(498, 110);
            this.btnBrowse.MaximumSize = new System.Drawing.Size(28, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 28);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(7, 48);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 25;
            this.lblUrl.Text = "Url";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(111, 45);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(533, 20);
            this.tbUrl.TabIndex = 21;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Location = new System.Drawing.Point(7, 113);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(72, 13);
            this.lblSaveLocation.TabIndex = 26;
            this.lblSaveLocation.Text = "Save location";
            // 
            // tbSaveLocation
            // 
            this.tbSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaveLocation.Location = new System.Drawing.Point(111, 110);
            this.tbSaveLocation.Name = "tbSaveLocation";
            this.tbSaveLocation.Size = new System.Drawing.Size(381, 20);
            this.tbSaveLocation.TabIndex = 24;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Image = global::PageMapper.Properties.Resources.Preview;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(532, 71);
            this.btnPreview.MaximumSize = new System.Drawing.Size(112, 28);
            this.btnPreview.MinimumSize = new System.Drawing.Size(112, 28);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(112, 28);
            this.btnPreview.TabIndex = 41;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::PageMapper.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(532, 110);
            this.btnSave.MaximumSize = new System.Drawing.Size(112, 28);
            this.btnSave.MinimumSize = new System.Drawing.Size(112, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 28);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbSelectedElement
            // 
            this.gbSelectedElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedElement.Controls.Add(this.lblElementHtml);
            this.gbSelectedElement.Controls.Add(this.tbElementHtml);
            this.gbSelectedElement.Controls.Add(this.lblElementTagName);
            this.gbSelectedElement.Controls.Add(this.tbElementTagName);
            this.gbSelectedElement.Controls.Add(this.lblElementClassName);
            this.gbSelectedElement.Controls.Add(this.tbElementClassName);
            this.gbSelectedElement.Controls.Add(this.lblElementName);
            this.gbSelectedElement.Controls.Add(this.tbElementName);
            this.gbSelectedElement.Controls.Add(this.lblElementId);
            this.gbSelectedElement.Controls.Add(this.tbElementId);
            this.gbSelectedElement.Location = new System.Drawing.Point(10, 24);
            this.gbSelectedElement.Name = "gbSelectedElement";
            this.gbSelectedElement.Size = new System.Drawing.Size(650, 189);
            this.gbSelectedElement.TabIndex = 24;
            this.gbSelectedElement.TabStop = false;
            this.gbSelectedElement.Text = "Selected Element";
            // 
            // lblElementHtml
            // 
            this.lblElementHtml.AutoSize = true;
            this.lblElementHtml.Location = new System.Drawing.Point(6, 112);
            this.lblElementHtml.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementHtml.Name = "lblElementHtml";
            this.lblElementHtml.Size = new System.Drawing.Size(28, 13);
            this.lblElementHtml.TabIndex = 26;
            this.lblElementHtml.Text = "Html";
            // 
            // tbElementHtml
            // 
            this.tbElementHtml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementHtml.Location = new System.Drawing.Point(110, 109);
            this.tbElementHtml.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementHtml.Multiline = true;
            this.tbElementHtml.Name = "tbElementHtml";
            this.tbElementHtml.Size = new System.Drawing.Size(534, 75);
            this.tbElementHtml.TabIndex = 31;
            // 
            // lblElementTagName
            // 
            this.lblElementTagName.AutoSize = true;
            this.lblElementTagName.Location = new System.Drawing.Point(6, 66);
            this.lblElementTagName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementTagName.Name = "lblElementTagName";
            this.lblElementTagName.Size = new System.Drawing.Size(54, 13);
            this.lblElementTagName.TabIndex = 20;
            this.lblElementTagName.Text = "TagName";
            // 
            // tbElementTagName
            // 
            this.tbElementTagName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementTagName.Location = new System.Drawing.Point(110, 63);
            this.tbElementTagName.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementTagName.Name = "tbElementTagName";
            this.tbElementTagName.Size = new System.Drawing.Size(534, 20);
            this.tbElementTagName.TabIndex = 29;
            // 
            // lblElementClassName
            // 
            this.lblElementClassName.AutoSize = true;
            this.lblElementClassName.Location = new System.Drawing.Point(6, 89);
            this.lblElementClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementClassName.Name = "lblElementClassName";
            this.lblElementClassName.Size = new System.Drawing.Size(60, 13);
            this.lblElementClassName.TabIndex = 21;
            this.lblElementClassName.Text = "ClassName";
            // 
            // tbElementClassName
            // 
            this.tbElementClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementClassName.Location = new System.Drawing.Point(110, 86);
            this.tbElementClassName.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementClassName.Name = "tbElementClassName";
            this.tbElementClassName.Size = new System.Drawing.Size(534, 20);
            this.tbElementClassName.TabIndex = 30;
            // 
            // lblElementName
            // 
            this.lblElementName.AutoSize = true;
            this.lblElementName.Location = new System.Drawing.Point(6, 44);
            this.lblElementName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(35, 13);
            this.lblElementName.TabIndex = 19;
            this.lblElementName.Text = "Name";
            // 
            // tbElementName
            // 
            this.tbElementName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementName.Location = new System.Drawing.Point(110, 41);
            this.tbElementName.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementName.Name = "tbElementName";
            this.tbElementName.Size = new System.Drawing.Size(534, 20);
            this.tbElementName.TabIndex = 28;
            // 
            // lblElementId
            // 
            this.lblElementId.AutoSize = true;
            this.lblElementId.Location = new System.Drawing.Point(6, 21);
            this.lblElementId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblElementId.Name = "lblElementId";
            this.lblElementId.Size = new System.Drawing.Size(16, 13);
            this.lblElementId.TabIndex = 18;
            this.lblElementId.Text = "Id";
            // 
            // tbElementId
            // 
            this.tbElementId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbElementId.Location = new System.Drawing.Point(110, 18);
            this.tbElementId.Margin = new System.Windows.Forms.Padding(2);
            this.tbElementId.Name = "tbElementId";
            this.tbElementId.Size = new System.Drawing.Size(534, 20);
            this.tbElementId.TabIndex = 27;
            // 
            // cmbFindBy
            // 
            this.cmbFindBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFindBy.FormattingEnabled = true;
            this.cmbFindBy.Location = new System.Drawing.Point(110, 19);
            this.cmbFindBy.Name = "cmbFindBy";
            this.cmbFindBy.Size = new System.Drawing.Size(534, 21);
            this.cmbFindBy.TabIndex = 17;
            this.cmbFindBy.SelectedIndexChanged += new System.EventHandler(this.cmbFindBy_SelectedIndexChanged);
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Location = new System.Drawing.Point(6, 21);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(42, 13);
            this.lblFindBy.TabIndex = 16;
            this.lblFindBy.Text = "Find By";
            // 
            // tbPropertyName
            // 
            this.tbPropertyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPropertyName.Location = new System.Drawing.Point(110, 69);
            this.tbPropertyName.Name = "tbPropertyName";
            this.tbPropertyName.Size = new System.Drawing.Size(534, 20);
            this.tbPropertyName.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = global::PageMapper.Properties.Resources.Clear;
            this.btnClear.Location = new System.Drawing.Point(588, 95);
            this.btnClear.MaximumSize = new System.Drawing.Size(56, 28);
            this.btnClear.MinimumSize = new System.Drawing.Size(56, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPropertyName
            // 
            this.lblPropertyName.AutoSize = true;
            this.lblPropertyName.Location = new System.Drawing.Point(6, 72);
            this.lblPropertyName.Name = "lblPropertyName";
            this.lblPropertyName.Size = new System.Drawing.Size(35, 13);
            this.lblPropertyName.TabIndex = 11;
            this.lblPropertyName.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::PageMapper.Properties.Resources.Remove;
            this.btnRemove.Location = new System.Drawing.Point(172, 95);
            this.btnRemove.MaximumSize = new System.Drawing.Size(56, 28);
            this.btnRemove.MinimumSize = new System.Drawing.Size(56, 28);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 28);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblPropertyLocator
            // 
            this.lblPropertyLocator.AutoSize = true;
            this.lblPropertyLocator.Location = new System.Drawing.Point(6, 47);
            this.lblPropertyLocator.Name = "lblPropertyLocator";
            this.lblPropertyLocator.Size = new System.Drawing.Size(43, 13);
            this.lblPropertyLocator.TabIndex = 8;
            this.lblPropertyLocator.Text = "Locator";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PageMapper.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(110, 95);
            this.btnAdd.MaximumSize = new System.Drawing.Size(56, 28);
            this.btnAdd.MinimumSize = new System.Drawing.Size(56, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPropertyKey
            // 
            this.tbPropertyKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPropertyKey.Location = new System.Drawing.Point(110, 45);
            this.tbPropertyKey.Name = "tbPropertyKey";
            this.tbPropertyKey.ReadOnly = true;
            this.tbPropertyKey.Size = new System.Drawing.Size(534, 20);
            this.tbPropertyKey.TabIndex = 4;
            this.tbPropertyKey.TextChanged += new System.EventHandler(this.tbPropertyKey_TextChanged);
            // 
            // gbPageProperties
            // 
            this.gbPageProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPageProperties.Controls.Add(this.lblFindBy);
            this.gbPageProperties.Controls.Add(this.cmbFindBy);
            this.gbPageProperties.Controls.Add(this.lblPropertyLocator);
            this.gbPageProperties.Controls.Add(this.tbPropertyKey);
            this.gbPageProperties.Controls.Add(this.lblPropertyName);
            this.gbPageProperties.Controls.Add(this.tbPropertyName);
            this.gbPageProperties.Controls.Add(this.btnAdd);
            this.gbPageProperties.Controls.Add(this.btnRemove);
            this.gbPageProperties.Controls.Add(this.btnClear);
            this.gbPageProperties.Controls.Add(this.lsbPageProperties);
            this.gbPageProperties.Location = new System.Drawing.Point(10, 219);
            this.gbPageProperties.Name = "gbPageProperties";
            this.gbPageProperties.Size = new System.Drawing.Size(650, 364);
            this.gbPageProperties.TabIndex = 25;
            this.gbPageProperties.TabStop = false;
            this.gbPageProperties.Text = "Page Properties";
            // 
            // lsbPageProperties
            // 
            this.lsbPageProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbPageProperties.FormattingEnabled = true;
            this.lsbPageProperties.Location = new System.Drawing.Point(110, 129);
            this.lsbPageProperties.Name = "lsbPageProperties";
            this.lsbPageProperties.Size = new System.Drawing.Size(534, 225);
            this.lsbPageProperties.TabIndex = 0;
            this.lsbPageProperties.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsbPageProperties_KeyUp);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenWebBrowser,
            this.tsbReset,
            this.tsddbChooseSelectionStyle,
            this.tsbResetStyles,
            this.tsbSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(667, 25);
            this.toolStrip.TabIndex = 26;
            this.toolStrip.Text = "Toolbar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 750);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.gbPageProperties);
            this.Controls.Add(this.gbSelectedElement);
            this.Controls.Add(this.gbPageObjectProperties);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PageMapper";
            this.gbPageObjectProperties.ResumeLayout(false);
            this.gbPageObjectProperties.PerformLayout();
            this.gbSelectedElement.ResumeLayout(false);
            this.gbSelectedElement.PerformLayout();
            this.gbPageProperties.ResumeLayout(false);
            this.gbPageProperties.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPageObjectProperties;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Button btnOpenTemplate;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tbSaveLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.GroupBox gbSelectedElement;
        private System.Windows.Forms.ComboBox cmbFindBy;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbPropertyKey;
        private System.Windows.Forms.Label lblPropertyLocator;
        private System.Windows.Forms.TextBox tbPropertyName;
        private System.Windows.Forms.Label lblPropertyName;
        private System.Windows.Forms.GroupBox gbPageProperties;
        private System.Windows.Forms.ListBox lsbPageProperties;
        private System.Windows.Forms.Label lblElementId;
        private System.Windows.Forms.Label lblElementName;
        private System.Windows.Forms.Label lblElementTagName;
        private System.Windows.Forms.Label lblElementClassName;
        private System.Windows.Forms.Label lblElementHtml;
        private System.Windows.Forms.TextBox tbElementId;
        private System.Windows.Forms.TextBox tbElementName;
        private System.Windows.Forms.TextBox tbElementTagName;
        private System.Windows.Forms.TextBox tbElementClassName;
        private System.Windows.Forms.TextBox tbElementHtml;
        private System.Windows.Forms.ToolStripButton tsbOpenWebBrowser;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStripDropDownButton tsddbChooseSelectionStyle;
        private System.Windows.Forms.ToolStripMenuItem borderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbResetStyles;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}