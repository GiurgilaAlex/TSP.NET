using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client
{
    public partial class FormFileDetails : Form
    {
        public FormFileDetails()
        {
            InitializeComponent();
        }

        private void FormFileDetails_Load(object sender, EventArgs e)
        {
            lblFileName.Text = FormMyFiles.FileName;
            pictureBox.Image = Image.FromFile(FormMyFiles.FilePath);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
