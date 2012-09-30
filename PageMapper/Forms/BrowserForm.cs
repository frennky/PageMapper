using PageMapper.Enums;
using PageMapper.Events;
using PageMapper.Extensions;
using PageMapper.Models;
using PageMapper.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PageMapper.Forms
{
    public delegate void PagePropertyChangedEventHandler(object sender, PagePropertyChangedEventArgs e);
    public delegate void UrlChangedEventHandler(object sender, UrlChangedEventArgs e);

    public partial class BrowserForm : Form
    {
        #region Fields

        private readonly MainForm mainForm;
        private HtmlDocument document;
        private readonly IDictionary<HtmlElement, string> elementStyles = new Dictionary<HtmlElement, string>();
        private WebElement selectedElement;
        
        #endregion

        #region Properties
        
        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        #endregion

        #region Events

        private event PagePropertyChangedEventHandler PagePropertyChanged;
        private event UrlChangedEventHandler UrlChanged;

        #endregion
        
        #region Private methods

        private string GetSelectionStyle()
        {
            switch (Settings.Default.SelectionStyle)
            {
                case SelectionStyle.Border:
                    return string.Format("border: {0}px {1} rgb({2},{3},{4});",
                        Settings.Default.BorderStyleWidth,
                        Settings.Default.BorderStyle,
                        Settings.Default.BorderStyleColor.R,
                        Settings.Default.BorderStyleColor.G,
                        Settings.Default.BorderStyleColor.B);
                case SelectionStyle.Background:
                    return string.Format("background-color: rgb({0},{1},{2});",
                        Settings.Default.BackgroundStyleColor.R,
                        Settings.Default.BackgroundStyleColor.G,
                        Settings.Default.BackgroundStyleColor.B);
                default:
                    return string.Empty;
            }
        }

        protected virtual void OnPagePropertyChanged(PagePropertyChangedEventArgs e)
        {
            if (PagePropertyChanged != null) PagePropertyChanged(this, e);
        }

        protected virtual void OnUrlChanged(UrlChangedEventArgs e)
        {
            if (UrlChanged != null) UrlChanged(this, e);
        }

        #endregion

        #region Constructors

        public BrowserForm(MainForm parent, string url)
        {
            this.mainForm = parent;
            InitializeComponent();

            this.PagePropertyChanged += mainForm.PagePropertyChanged;
            this.UrlChanged += mainForm.UrlChanged;
            this.Icon = Resources.BrowserIcon;
            this.Text = string.Format("Internet Explorer v{0}", this.webBrowser.Version);
            this.tbAddress.Text = url;
        }

        #endregion

        #region Public methods

        public void ResetStyles()
        {
            foreach (var item in this.elementStyles)
            {
                item.Key.Style = item.Value;
            }
            this.elementStyles.Clear();
        }
        
        public void RefreshStyles()
        {
            foreach (var pair in elementStyles)
            {
                var element = pair.Key;
                var style = pair.Value;
                element.Style = string.Format("{0}; {1}", style, GetSelectionStyle());
            }
        }

        #endregion

        #region Event handlers

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.webBrowser.GoBack();
        }

        private void btnFarward_Click(object sender, EventArgs e)
        {
            this.webBrowser.GoForward();
        }
        
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.webBrowser.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.webBrowser.Refresh();
        }

        private void tbAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.webBrowser.Navigate(this.tbAddress.Text);
        }
        
        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.btnRefresh.Visible = false;
            this.btnStop.Visible = !this.btnRefresh.Visible;
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.btnRefresh.Visible = true;
            this.btnStop.Visible = !this.btnRefresh.Visible;
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress <= 0) return;

            this.progressBar.Maximum = (e.MaximumProgress > e.CurrentProgress) ?
                Convert.ToInt32(e.MaximumProgress) : Convert.ToInt32(e.CurrentProgress);
            this.progressBar.Value = Convert.ToInt32(e.CurrentProgress);
        }

        private void document_MouseLeave(object sender, HtmlElementEventArgs e)
        {
            if (!e.CtrlKeyPressed) return;

            var element = e.FromElement;
            if (element == null || !this.elementStyles.ContainsKey(element)) return;

            element.Style = this.elementStyles[element];
            this.elementStyles.Remove(element);
        }

        private void document_MouseOver(object sender, HtmlElementEventArgs e)
        {
            if (!e.CtrlKeyPressed) return;

            var element = e.ToElement;
            if (element == null || this.elementStyles.ContainsKey(element)) return;

            var style = element.Style;
            this.elementStyles.Add(element, style);
            element.Style = string.Format("{0}; {1}", style, GetSelectionStyle());
            this.selectedElement = element.AsWebElement();
            this.OnPagePropertyChanged(new PagePropertyChangedEventArgs(this.selectedElement));
        }
        
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.document = this.webBrowser.Document;
            if (this.document == null) return;

            this.document.MouseOver += document_MouseOver;
            this.document.MouseLeave += document_MouseLeave;

            this.tbAddress.Text = this.webBrowser.Url.ToString();
            this.OnUrlChanged(new UrlChangedEventArgs(this.webBrowser.Url));
            this.Text = this.webBrowser.DocumentTitle;
        }

        #endregion
    }
}