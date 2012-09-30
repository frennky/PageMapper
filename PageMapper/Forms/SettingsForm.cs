using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PageMapper.Properties;
using BorderStyle = PageMapper.Enums.BorderStyle;

namespace PageMapper.Forms
{
    public partial class SettingsForm : Form
    {
        #region Constructors

        public SettingsForm()
        {
            InitializeComponent();
            this.Icon = Resources.SettingsIcon;

            FillTemplatesComboBox();
            FillBorderStylesComboBox();

            LoadSettings();
        }

        #endregion

        #region Private methods

        private void LoadSettings()
        {
            this.tbClassName.Text = Settings.Default.ClassName;
            this.tbUrl.Text = Settings.Default.Url;
            this.tbSaveLocation.Text = Settings.Default.SaveLocation;
            this.tbFileExtension.Text = Settings.Default.FileExtension;

            this.cmbTemplates.SelectedItem = Settings.Default.Template;
            this.tbTemplateFilter.Text = Settings.Default.TemplateFilter;
            this.tbTemplateFolder.Text = Settings.Default.TemplateFolder;

            this.nudBorderWidth.Value = Settings.Default.BorderStyleWidth;
            this.cmbBorderStyle.SelectedItem = Settings.Default.BorderStyle;
            this.pbBorderColor.BackColor = Settings.Default.BorderStyleColor;
            this.pbBackgroundColor.BackColor = Settings.Default.BackgroundStyleColor;

            this.chbLogErrors.Checked = Settings.Default.LogErrors;
            this.tbLogFilename.Text = Settings.Default.LogFilename;
            this.tbLogFolder.Text = Settings.Default.LogFolder;
        }

        private void Save()
        {
            Settings.Default.ClassName = this.tbClassName.Text;
            Settings.Default.Url = this.tbUrl.Text;
            Settings.Default.SaveLocation = this.tbSaveLocation.Text;
            Settings.Default.FileExtension = this.tbFileExtension.Text;

            Settings.Default.Template = this.cmbTemplates.SelectedItem != null ? 
                this.cmbTemplates.SelectedItem.ToString() : string.Empty;
            Settings.Default.TemplateFilter = this.tbTemplateFilter.Text;
            Settings.Default.TemplateFolder = this.tbTemplateFolder.Text;

            Settings.Default.BorderStyleWidth = (int)this.nudBorderWidth.Value;
            Settings.Default.BorderStyle = (BorderStyle)this.cmbBorderStyle.SelectedItem;
            Settings.Default.BorderStyleColor = this.pbBorderColor.BackColor;
            Settings.Default.BackgroundStyleColor = this.pbBackgroundColor.BackColor;

            Settings.Default.LogErrors = this.chbLogErrors.Checked;
            Settings.Default.LogFilename = this.tbLogFilename.Text;
            Settings.Default.LogFolder = this.tbLogFolder.Text;

            Settings.Default.Save();
        }
        
        private void FillTemplatesComboBox(string folder = null, string filter = null)
        {
            this.cmbTemplates.Items.Clear();
            if (!Directory.Exists(folder ?? Settings.Default.TemplateFolder)) return;

            var templateFiles = Directory.GetFiles(
                folder ?? Settings.Default.TemplateFolder,
                filter ?? Settings.Default.TemplateFilter,
                SearchOption.AllDirectories);

            if (templateFiles.Length == 0) return;

            this.cmbTemplates.Items.AddRange(templateFiles);
            this.cmbTemplates.SelectedItem =
                this.cmbTemplates.Items.Contains(Settings.Default.Template) ?
                    Settings.Default.Template : this.cmbTemplates.Items[0];
        }

        private void FillBorderStylesComboBox()
        {
            this.cmbBorderStyle.DataSource = Enum.GetValues(typeof(BorderStyle));
        }

        #endregion

        #region Event handlers

        private void btnChooseBorderColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) return;
            this.pbBorderColor.BackColor = colorDialog.Color;
        }

        private void btnChooseBackgroundColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) return;
            this.pbBackgroundColor.BackColor = colorDialog.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
            this.btnApply.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog { Description = "Select save location" };
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbSaveLocation.Text = folderDialog.SelectedPath;
            }
        }

        private void btnBrowseLogFolder_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog { Description = @"Select log file location" };
            if (folderDialog.ShowDialog() != DialogResult.OK) return;
            this.tbLogFolder.Text = folderDialog.SelectedPath;
        }

        private void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Environment.CurrentDirectory, this.cmbTemplates.SelectedItem.ToString()));
        }

        private void chbLogErrors_CheckedChanged(object sender, EventArgs e)
        {
            this.tbLogFilename.Enabled = this.chbLogErrors.Checked;
            this.tbLogFolder.Enabled = this.chbLogErrors.Checked;
            setting_Changed(sender, e);
        }
        
        private void btnBrowseTemplateFolder_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog { Description = @"Select template folder location" };
            
            if (folderDialog.ShowDialog() != DialogResult.OK) return;

            this.tbTemplateFolder.Text = folderDialog.SelectedPath;
            FillTemplatesComboBox(this.tbTemplateFolder.Text);
        }

        private void tbTemplateFilter_TextChanged(object sender, EventArgs e)
        {
            FillTemplatesComboBox(filter: this.tbTemplateFilter.Text);
            setting_Changed(sender, e);
        }

        private void tbTemplateFolder_TextChanged(object sender, EventArgs e)
        {
            FillTemplatesComboBox(this.tbTemplateFolder.Text);
            setting_Changed(sender, e);
        }

        private void setting_Changed(object sender, EventArgs e)
        {
            this.btnApply.Enabled = true;
            this.pbWarning.Visible = true;
            this.lblWarning.Visible = true;
        }

        #endregion
        
    }
}