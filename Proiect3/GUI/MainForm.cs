using MyPhotos;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMyFiles : Form
    {
        public static string FileName = "";
        public static string FilePath = "";
        public static Guid Id;

        private File fileRepository;
        private Property propertiesRepository;

        public FormMyFiles()
        {
            InitializeComponent();
            fileRepository = new File();
            propertiesRepository = new Property();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormFileDetails fd = new FormFileDetails();
            fd.ShowDialog();
        }

        private void FormMyFiles_Load(object sender, EventArgs e)
        {
            filesGridView.DataSource = fileRepository.GetAllFiles();
            propertiesDropdown.DataSource = propertiesRepository.GetAllProperties();
            setOptions();
            processItemSelection();
        }

        private void filesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            processItemSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddFile fa = new FormAddFile();
            fa.FormClosing += new FormClosingEventHandler(Fa_FormClosing);
            fa.ShowDialog();
        }

        private void Fa_FormClosing(Object sender, FormClosingEventArgs e)
        {
            filesGridView.DataSource = fileRepository.GetAllFiles();
            propertiesDropdown.DataSource = propertiesRepository.GetAllProperties();
            propertiesDropdown.DataSource = propertiesRepository.GetAllProperties();
            setOptions();
            processItemSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormAddFile fa = new FormAddFile();
            fa.setName = FileName;
            fa.setPath = FilePath;
            fa.setId = Id;
            fa.FormClosing += new FormClosingEventHandler(Fa_FormClosing);
            fa.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            fileRepository.Delete(Id);
            filesGridView.DataSource = fileRepository.GetAllFiles();
            propertiesDropdown.DataSource = propertiesRepository.GetAllProperties();
            setOptions();
            processItemSelection();
        }

        private void processItemSelection()
        {
            if (filesGridView.Rows.Count != 0)
            {
                Id = Guid.Parse(filesGridView.SelectedRows[0].Cells[0].Value.ToString());
                FileName = filesGridView.SelectedRows[0].Cells[1].Value.ToString();
                FilePath = filesGridView.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                filesGridView.DataSource = fileRepository.GetFilesByProperty(propertiesDropdown.SelectedItem.ToString(), txtSearch.Text);
            } else
            {
                filesGridView.DataSource = fileRepository.GetAllFiles();
            }
            setOptions();
        }

        private void setOptions()
        {
            if (filesGridView.Rows.Count == 0)
            {
                btnView.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnView.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }

            if (propertiesDropdown.Items.Count == 0)
            {
                propertiesDropdown.Enabled = false;
                txtSearch.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                propertiesDropdown.Enabled = true;
                txtSearch.Enabled = true;
                btnSearch.Enabled = true;

            }
        }
    }
}
