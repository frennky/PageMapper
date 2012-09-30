using System.Windows.Forms;
using PageMapper.Properties;

namespace PageMapper.Forms
{
    public partial class PreviewForm : Form
    {
        public PreviewForm(string result)
        {
            InitializeComponent();
            this.Icon = Resources.PreviewIcon;
            this.tbResult.Text = result;
        }

        private void pasteToolStripButton_Click(object sender, System.EventArgs e)
        {
            this.tbResult.Paste();
        }

        private void copyToolStripButton_Click(object sender, System.EventArgs e)
        {
            this.tbResult.Copy();
        }

        private void cutToolStripButton_Click(object sender, System.EventArgs e)
        {
            this.tbResult.Cut();
        }
    }
}