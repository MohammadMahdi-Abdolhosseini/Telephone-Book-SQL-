namespace Telephone_Book__SQL_
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.birthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxPhoto = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toDTP = new System.Windows.Forms.DateTimePicker();
            this.fromDTP = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contactInfoDBDataSet = new Telephone_Book__SQL_.ContactInfoDBDataSet();
            this.contactInfoTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactInfoTTableAdapter = new Telephone_Book__SQL_.ContactInfoDBDataSetTableAdapters.ContactInfoTTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxContactInfo.SuspendLayout();
            this.groupBoxPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxContacts.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxContactInfo
            // 
            this.groupBoxContactInfo.Controls.Add(this.birthdayDTP);
            this.groupBoxContactInfo.Controls.Add(this.txtPhone);
            this.groupBoxContactInfo.Controls.Add(this.txtName);
            this.groupBoxContactInfo.Controls.Add(this.btnBrowse);
            this.groupBoxContactInfo.Controls.Add(this.btnSave);
            this.groupBoxContactInfo.Controls.Add(this.btnCancel);
            this.groupBoxContactInfo.Controls.Add(this.groupBoxPhoto);
            this.groupBoxContactInfo.Controls.Add(this.label3);
            this.groupBoxContactInfo.Controls.Add(this.label2);
            this.groupBoxContactInfo.Controls.Add(this.label1);
            this.groupBoxContactInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxContactInfo.Name = "groupBoxContactInfo";
            this.groupBoxContactInfo.Size = new System.Drawing.Size(389, 161);
            this.groupBoxContactInfo.TabIndex = 0;
            this.groupBoxContactInfo.TabStop = false;
            this.groupBoxContactInfo.Text = "Contact Info";
            // 
            // birthdayDTP
            // 
            this.birthdayDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdayDTP.Location = new System.Drawing.Point(72, 97);
            this.birthdayDTP.Name = "birthdayDTP";
            this.birthdayDTP.Size = new System.Drawing.Size(206, 27);
            this.birthdayDTP.TabIndex = 2;
            this.birthdayDTP.Value = new System.DateTime(2000, 11, 5, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(72, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(206, 27);
            this.txtPhone.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 27);
            this.txtName.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 130);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(110, 25);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Import Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(203, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxPhoto
            // 
            this.groupBoxPhoto.Controls.Add(this.pictureBox);
            this.groupBoxPhoto.Location = new System.Drawing.Point(284, 22);
            this.groupBoxPhoto.Name = "groupBoxPhoto";
            this.groupBoxPhoto.Size = new System.Drawing.Size(99, 133);
            this.groupBoxPhoto.TabIndex = 0;
            this.groupBoxPhoto.TabStop = false;
            this.groupBoxPhoto.Text = "Photo";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(6, 22);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(87, 105);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(648, 211);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Controls.Add(this.dataGridView);
            this.groupBoxContacts.Location = new System.Drawing.Point(12, 179);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(660, 239);
            this.groupBoxContacts.TabIndex = 2;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Contacts";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.label7);
            this.groupBoxSearch.Controls.Add(this.label6);
            this.groupBoxSearch.Controls.Add(this.toDTP);
            this.groupBoxSearch.Controls.Add(this.fromDTP);
            this.groupBoxSearch.Controls.Add(this.txtPhoneSearch);
            this.groupBoxSearch.Controls.Add(this.txtNameSearch);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.label4);
            this.groupBoxSearch.Location = new System.Drawing.Point(407, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(265, 161);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "From";
            // 
            // toDTP
            // 
            this.toDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDTP.Location = new System.Drawing.Point(61, 129);
            this.toDTP.Name = "toDTP";
            this.toDTP.Size = new System.Drawing.Size(198, 27);
            this.toDTP.TabIndex = 3;
            this.toDTP.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.toDTP.ValueChanged += new System.EventHandler(this.toDTP_ValueChanged);
            // 
            // fromDTP
            // 
            this.fromDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDTP.Location = new System.Drawing.Point(61, 97);
            this.fromDTP.Name = "fromDTP";
            this.fromDTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromDTP.Size = new System.Drawing.Size(198, 27);
            this.fromDTP.TabIndex = 2;
            this.fromDTP.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.fromDTP.ValueChanged += new System.EventHandler(this.fromDTP_ValueChanged);
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(61, 67);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(198, 27);
            this.txtPhoneSearch.TabIndex = 1;
            this.txtPhoneSearch.TextChanged += new System.EventHandler(this.txtPhoneSearch_TextChanged);
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(61, 37);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(198, 27);
            this.txtNameSearch.TabIndex = 0;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(597, 424);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 25);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(516, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(18, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Made By";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mohammad Mahdi Abdolhosseini";
            // 
            // contactInfoDBDataSet
            // 
            this.contactInfoDBDataSet.DataSetName = "ContactInfoDBDataSet";
            this.contactInfoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactInfoTBindingSource
            // 
            this.contactInfoTBindingSource.DataMember = "ContactInfoT";
            this.contactInfoTBindingSource.DataSource = this.contactInfoDBDataSet;
            // 
            // contactInfoTTableAdapter
            // 
            this.contactInfoTTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxContacts);
            this.Controls.Add(this.groupBoxContactInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Book [SQL Sample]";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxContactInfo.ResumeLayout(false);
            this.groupBoxContactInfo.PerformLayout();
            this.groupBoxPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxContacts.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactInfoTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContactInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPhoto;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DateTimePicker birthdayDTP;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.DateTimePicker toDTP;
        private System.Windows.Forms.DateTimePicker fromDTP;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ContactInfoDBDataSet contactInfoDBDataSet;
        private System.Windows.Forms.BindingSource contactInfoTBindingSource;
        private ContactInfoDBDataSetTableAdapters.ContactInfoTTableAdapter contactInfoTTableAdapter;
        private System.Windows.Forms.Button btnDelete;
    }
}

