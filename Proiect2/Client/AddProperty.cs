using System;
using System.Windows.Forms;

namespace Client
{
    public partial class AddProperty : Form
    {
        private FilePropertyClient filePropertyClient;

        public Guid setFileId;
        public MyPhotos.Property setProperty;

        public AddProperty()
        {
            InitializeComponent();
            filePropertyClient = new FilePropertyClient();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyPhotos.Property property = new MyPhotos.Property();
            
            property.Value = txtValue.Text;
            property.FileId = setFileId;

            if (txtKey.Enabled == true)
            {
                property.Key = txtKey.Text;
            }
            else
            {
                property.Key = keyDropdown.Text;
            }

            if (setProperty != null)
            {
                property.Id = setProperty.Id;
                filePropertyClient.UpdateProperty(property);
            }
            else
            {
                filePropertyClient.AddProperty(property);
            }

            Close();
        }

        private void newKeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            txtKey.Text = "";
            txtKey.Enabled = !txtKey.Enabled;
            keyDropdown.Enabled = !keyDropdown.Enabled;
        }

        private void AddProperty_Load(object sender, EventArgs e)
        {
            keyDropdown.DataSource = filePropertyClient.GetAllProperties();
            if(setProperty != null)
            {
                newKeyCheckbox.Checked = false;
                keyDropdown.SelectedItem = setProperty.Key;
                txtValue.Text = setProperty.Value;
            }
        }
    }
}
