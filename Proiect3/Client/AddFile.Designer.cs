namespace Client
{
    partial class FormAddFile
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
            this.components = new System.ComponentModel.Container();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.propertiesGridView = new System.Windows.Forms.DataGridView();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnEditProperty = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddPropertiesMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(259, 386);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(67, 271);
            this.btnUploadImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(75, 23);
            this.btnUploadImg.TabIndex = 1;
            this.btnUploadImg.Text = "Upload";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 324);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 324);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(787, 22);
            this.txtName.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 234);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(557, 386);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // propertiesGridView
            // 
            this.propertiesGridView.AllowUserToAddRows = false;
            this.propertiesGridView.AllowUserToDeleteRows = false;
            this.propertiesGridView.AllowUserToResizeColumns = false;
            this.propertiesGridView.AllowUserToResizeRows = false;
            this.propertiesGridView.AutoGenerateColumns = false;
            this.propertiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.keyDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.fileIdDataGridViewTextBoxColumn,
            this.fileDataGridViewTextBoxColumn});
            this.propertiesGridView.DataSource = this.propertyBindingSource;
            this.propertiesGridView.Location = new System.Drawing.Point(248, 12);
            this.propertiesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.propertiesGridView.Name = "propertiesGridView";
            this.propertiesGridView.ReadOnly = true;
            this.propertiesGridView.RowHeadersWidth = 51;
            this.propertiesGridView.RowTemplate.Height = 24;
            this.propertiesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.propertiesGridView.Size = new System.Drawing.Size(605, 234);
            this.propertiesGridView.TabIndex = 6;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(259, 271);
            this.btnAddProperty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(160, 30);
            this.btnAddProperty.TabIndex = 7;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(691, 271);
            this.btnDeleteProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(160, 28);
            this.btnDeleteProperty.TabIndex = 8;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);
            // 
            // btnEditProperty
            // 
            this.btnEditProperty.Location = new System.Drawing.Point(472, 271);
            this.btnEditProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditProperty.Name = "btnEditProperty";
            this.btnEditProperty.Size = new System.Drawing.Size(160, 28);
            this.btnEditProperty.TabIndex = 9;
            this.btnEditProperty.Text = "Edit Property";
            this.btnEditProperty.UseVisualStyleBackColor = true;
            this.btnEditProperty.Click += new System.EventHandler(this.btnEditProperty_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyDataGridViewTextBoxColumn.Width = 200;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileIdDataGridViewTextBoxColumn
            // 
            this.fileIdDataGridViewTextBoxColumn.DataPropertyName = "FileId";
            this.fileIdDataGridViewTextBoxColumn.HeaderText = "FileId";
            this.fileIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fileIdDataGridViewTextBoxColumn.Name = "fileIdDataGridViewTextBoxColumn";
            this.fileIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileIdDataGridViewTextBoxColumn.Visible = false;
            this.fileIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fileDataGridViewTextBoxColumn
            // 
            this.fileDataGridViewTextBoxColumn.DataPropertyName = "File";
            this.fileDataGridViewTextBoxColumn.HeaderText = "File";
            this.fileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fileDataGridViewTextBoxColumn.Name = "fileDataGridViewTextBoxColumn";
            this.fileDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileDataGridViewTextBoxColumn.Visible = false;
            this.fileDataGridViewTextBoxColumn.Width = 125;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = typeof(MyPhotos.Property);
            // 
            // lblAddPropertiesMessage
            // 
            this.lblAddPropertiesMessage.AutoSize = true;
            this.lblAddPropertiesMessage.Location = new System.Drawing.Point(347, 128);
            this.lblAddPropertiesMessage.Name = "lblAddPropertiesMessage";
            this.lblAddPropertiesMessage.Size = new System.Drawing.Size(396, 17);
            this.lblAddPropertiesMessage.TabIndex = 10;
            this.lblAddPropertiesMessage.Text = "You can add, edit and delete properties only on edit file mode";
            // 
            // FormAddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.lblAddPropertiesMessage);
            this.Controls.Add(this.btnEditProperty);
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.propertiesGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.btnAddFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFile";
            this.Load += new System.EventHandler(this.FormAddFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView propertiesGridView;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnEditProperty;
        private System.Windows.Forms.Label lblAddPropertiesMessage;
    }
}