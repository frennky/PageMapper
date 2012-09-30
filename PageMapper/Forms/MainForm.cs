using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PageMapper.Enums;
using PageMapper.Extensions;
using PageMapper.Models;
using PageMapper.Properties;
using RazorEngine;
using PageMapper.Events;

namespace PageMapper.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        private readonly List<PageProperty> pageProperties = new List<PageProperty>();
        private BrowserForm browserForm;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Resources.BrowserIcon;
            this.Text = string.Format("{0} v{1}", this.Text, this.ProductVersion);

            LoadSettings();
            LoadSelectionStyle();
            FillTemplatesComboBox();
            FillFindByComboBox();

            browserForm = new BrowserForm(this, this.tbUrl.Text);
            browserForm.Show();
        }

        #endregion

        #region Public Event handlers

        public void PagePropertyChanged(object sender, PagePropertyChangedEventArgs e)
        {
            this.tbElementId.Text = e.SelectedElement.Id;
            this.tbElementName.Text = e.SelectedElement.Name;
            this.tbElementTagName.Text = e.SelectedElement.TagName;
            this.tbElementClassName.Text = e.SelectedElement.ClassName;
            this.tbElementHtml.Text = e.SelectedElement.Html;
        }

        public void UrlChanged(object sender, UrlChangedEventArgs e)
        {
            this.tbUrl.Text = e.Url.ToString();
        }

        #endregion

        #region Private methods

        private void LoadSettings()
        {
            this.tbClassName.Text = Settings.Default.ClassName;
            this.tbUrl.Text = Settings.Default.Url;
            this.tbSaveLocation.Text = Settings.Default.SaveLocation;
        }

        private void LoadSelectionStyle()
        {
            switch (Settings.Default.SelectionStyle)
            {
                case SelectionStyle.Border:
                    this.borderToolStripMenuItem.Checked = true;
                    break;
                case SelectionStyle.Background:
                    this.backgroundToolStripMenuItem.Checked = true;
                    break;
                default:
                    this.borderToolStripMenuItem.Checked = true;
                    break;
            }
        }
        
        private void FillTemplatesComboBox()
        {
            this.cmbTemplates.Items.Clear();
            if (!Directory.Exists(Settings.Default.TemplateFolder)) return;
            
            var templateFiles = Directory.GetFiles(
                Settings.Default.TemplateFolder,
                Settings.Default.TemplateFilter,
                SearchOption.AllDirectories);

            if (templateFiles.Length == 0) return;

            this.cmbTemplates.Items.AddRange(templateFiles);
            this.cmbTemplates.SelectedItem =
                this.cmbTemplates.Items.Contains(Settings.Default.Template) ?
                    Settings.Default.Template : this.cmbTemplates.Items[0];
        }

        private void FillFindByComboBox()
        {
            this.cmbFindBy.DataSource = Enum.GetValues(typeof(How));
        }
        
        private void AddPageProperty()
        {
            var pageProperty = new PageProperty {  Name = this.tbPropertyName.Text, Locator = this.tbPropertyKey.Text, LocatorType = this.cmbFindBy.Text };

            if (!pageProperty.IsValid()) return;

            if ((this.pageProperties.Count != 0)
                && (!this.pageProperties.Exists(we => we.Name != pageProperty.Name)))
                return;

            this.pageProperties.Add(pageProperty);
        }

        private void RemovePageProperty()
        {
            var selectedPageProperty = this.lsbPageProperties.SelectedItem as PageProperty;
            if (selectedPageProperty == null) return;

            this.pageProperties.Remove(selectedPageProperty);
            RefreshPagePropertyList();
        }

        private void RefreshPagePropertyList()
        {
            this.lsbPageProperties.DataSource = null;
            this.lsbPageProperties.DataSource = this.pageProperties;
            this.lsbPageProperties.DisplayMember = "Name";
        }

        private string Save(string result)
        {
            var filename = string.Format(@"{0}\{1}{2}", 
                this.tbSaveLocation.Text, 
                this.tbClassName.Text, 
                Settings.Default.FileExtension);

            File.WriteAllText(filename, result);
            return filename;
        }

        private PageObject CreatePageModel()
        {
            return new PageObject
            {
                ClassName = this.tbClassName.Text,
                Url = this.tbUrl.Text,
                Properties = this.pageProperties
            };
        }
        
        private void UpdateBindings()
        {
            var selectedItem = (How)this.cmbFindBy.SelectedItem;
            TextBox dataSource;
            switch (selectedItem)
            {
                case How.Id:
                    dataSource = this.tbElementId;
                    break;
                case How.Name:
                    dataSource = this.tbElementName;
                    break;
                case How.TagName:
                    dataSource = this.tbElementTagName;
                    break;
                case How.ClassName:
                    dataSource = this.tbElementClassName;
                    break;
                default:
                    dataSource = new TextBox();
                    break;
            }

            this.tbPropertyKey.DataBindings.Clear();
            this.tbPropertyKey.DataBindings.Add("Text", dataSource, "Text", false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        #endregion

        #region Event handlers

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Load Template
            var template = File.ReadAllText(this.cmbTemplates.SelectedItem.ToString());

            //Create Model
            var model = CreatePageModel();

            //Parse Template
            var result = Razor.Parse(template, model);

            //Save file
            var filename = Save(result);

            //Dispaly Success/Fail Message
            MessageBox.Show("Page class successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog {Description = "Select save location"};
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbSaveLocation.Text = folderDialog.SelectedPath;
            }
        }

        private void btnOpenTemplate_Click(object sender, EventArgs e)
        {
            if (this.cmbTemplates.SelectedItem == null) return;

            Process.Start(Path.Combine(Environment.CurrentDirectory, this.cmbTemplates.SelectedItem.ToString()));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPageProperty();
            RefreshPagePropertyList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemovePageProperty();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pageProperties.Clear();
            RefreshPagePropertyList();
        }

        private void lsbPageProperties_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            
            RemovePageProperty();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //Load Template
            var template = File.ReadAllText(this.cmbTemplates.SelectedItem.ToString());

            //Create Model
            var model = CreatePageModel();

            //Parse Template
            var result = Razor.Parse(template, model);

            //Dispaly Preview Form
            new PreviewForm(result).ShowDialog(this);
        }
        
        private void tbPropertyKey_TextChanged(object sender, EventArgs e)
        {
            this.tbPropertyName.Text = this.tbPropertyKey.Text.Sanatize();
        }

        private void tsbOpenWebBrowser_Click(object sender, EventArgs e)
        {
            if (this.browserForm.IsDisposed)
            {
                this.browserForm = new BrowserForm(this, this.tbUrl.Text);
                this.browserForm.Show();
            }
            else
            {
                if (this.browserForm.WindowState == FormWindowState.Minimized)
                    this.browserForm.WindowState = FormWindowState.Normal;
            }
            this.browserForm.Activate();
        }

        private void tsbReset_Click(object sender, EventArgs e)
        {
            this.pageProperties.Clear();
            RefreshPagePropertyList();
            LoadSettings();
        }

        private void tsbResetStyles_Click(object sender, EventArgs e)
        {
            this.browserForm.ResetStyles();
        }
        
        private void tsbSettings_Click(object sender, EventArgs e)
        {
            if (new SettingsForm().ShowDialog() != DialogResult.OK) return;
            
            LoadSettings();
            FillTemplatesComboBox();
            this.browserForm.RefreshStyles();
        }

        private void cmbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBindings();
        }
        
        private void selectionStyleMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem == null) return;

            var menu = menuItem.Owner;
            var items = menu.Items.Cast<ToolStripMenuItem>();
            var checkedMenuItem = items.Single(item => item.Checked);
            
            if (menuItem == checkedMenuItem) return;

            menuItem.Checked = true;
            checkedMenuItem.Checked = false;

            var styleText = menuItem.Text;
            var style = (SelectionStyle)Enum.Parse(typeof (SelectionStyle), styleText);
            Settings.Default.SelectionStyle = style;
            Settings.Default.Save();
            this.browserForm.RefreshStyles();
        }

        #endregion
        
    }
}