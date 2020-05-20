using MyPhotos;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class AddProperty : Form
    {
        private Property propertiesRepository;

        public Guid setFileId;
        public Property setProperty;

        public AddProperty()
        {
            InitializeComponent();
            propertiesRepository = new Property();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Property property = new Property();
            
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
                propertiesRepository.Update(property);
            }
            else
            {
                propertiesRepository.Add(property);
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
            keyDropdown.DataSource = propertiesRepository.GetAllProperties();
            if(setProperty != null)
            {
                newKeyCheckbox.Checked = false;
                keyDropdown.SelectedItem = setProperty.Key;
                txtValue.Text = setProperty.Value;
            }
        }
    }
}
