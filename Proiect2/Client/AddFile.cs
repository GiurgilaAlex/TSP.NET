using System;
using System.Drawing;
using System.Windows.Forms;

namespace Client
{
    public partial class FormAddFile : Form
    {
        private FilePropertyClient filePropertyClient;
        private string path;

        public string setName;
        public string setPath;
        public Guid setId;
        
        public FormAddFile()
        {
            InitializeComponent();
            filePropertyClient = new FilePropertyClient();
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog()== DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(opnfd.FileName);
                txtName.Text = System.IO.Path.GetFileName(opnfd.FileName);
                path = opnfd.FileName;
                btnAddFile.Enabled = true;
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                MyPhotos.File file = new MyPhotos.File();

                file.Name = txtName.Text;
                file.Path = path;

                if (setId != Guid.Empty) 
                {
                    file.Id = setId;
                    filePropertyClient.UpdateFile(file);
                } else
                {
                    filePropertyClient.AddFile(file);
                }
                Close();
            }
        }

        private void FormAddFile_Load(object sender, EventArgs e)
        {
            if (setName != null && setPath != null)
            {
                pictureBox.Image = new Bitmap(setPath);
                txtName.Text = setName;
                path = setPath;
                btnAddFile.Text = "Update";
                propertiesGridView.DataSource = filePropertyClient.GetPropertiesByFileId(setId);
                lblAddPropertiesMessage.Hide();
            } else
            {
                propertiesGridView.Hide();
                btnAddProperty.Enabled = false;
                btnEditProperty.Enabled = false;
                btnDeleteProperty.Enabled = false;
            }

            if (pictureBox.Image == null)
            {
                btnAddFile.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            AddProperty ap = new AddProperty();
            ap.FormClosing += new FormClosingEventHandler(Ap_FormClosing);
            ap.setFileId = setId;
            ap.ShowDialog();
        }

        private void Ap_FormClosing(Object sender, FormClosingEventArgs e)
        {
            propertiesGridView.DataSource = filePropertyClient.GetPropertiesByFileId(setId);
        }

        private void btnEditProperty_Click(object sender, EventArgs e)
        {
            AddProperty ap = new AddProperty();
            ap.FormClosing += new FormClosingEventHandler(Ap_FormClosing);
            ap.setFileId = setId;

            MyPhotos.Property prop = new MyPhotos.Property();
            prop.Id = Guid.Parse(propertiesGridView.SelectedRows[0].Cells[0].Value.ToString());
            prop.Key = propertiesGridView.SelectedRows[0].Cells[1].Value.ToString();
            prop.Value = propertiesGridView.SelectedRows[0].Cells[2].Value.ToString();

            ap.setProperty = prop;
            ap.ShowDialog();
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            filePropertyClient.DeleteProperty(Guid.Parse(propertiesGridView.SelectedRows[0].Cells[0].Value.ToString()));
            propertiesGridView.DataSource = filePropertyClient.GetPropertiesByFileId(setId);
        }
    }
}
