using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Telephone_Book__SQL_
{
    public partial class MainForm : Form
    {

        const string INSERT_QUERY = "INSERT INTO ContactInfoT (Name, Phone, Birthday, Photo) VALUES (@Name,@Phone,@Birthday,@Photo)";
        const string SELECT_ALL_QUERY = "SELECT Name, Phone, Birthday, Photo FROM ContactInfoT";
        const string SELECT_QUERY = "SELECT Id, Name, Phone, Birthday, Photo FROM ContactInfoT"
                                    + " WHERE Name = @Name AND Phone = @Phone";
        const string UPDATE_QUERY = "UPDATE ContactInfoT"
                                    + " SET Name = @Name, Phone = @Phone, Birthday = @Birthday"
                                    + " WHERE Id = @Original_Id";
        const string UPDATE_Photo_QUERY = "UPDATE ContactInfoT SET Photo = @Photo WHERE Id = @Original_Id";
        const string DELETE_QUERY = "DELETE FROM ContactInfoT WHERE Name = @Name AND Phone = @Phone";
        const string SEARCH_QUERY = "SELECT Name, Phone, Birthday, Photo FROM ContactInfoT"
                                    + " WHERE Name LIKE @Name AND Phone LIKE @Phone AND Birthday >= @from AND Birthday <= @to";

        const string FILE_DIALOG_TITLE = "Import Image";
        const string FILE_DIALOG_FILTER = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png";

        const string MESSAGE_WINDOW_NAME = "Message";
        const string EMPTY_FIELD_ERROR = "Name and Phone cannot be empty.";
        const string DUPLICATE_DATA_ERROR = "There is another contact with the same Phone.\n"
                                          + "Please enter a different Phone.";
        const string DELETE_MESSAGE = "Are you sure want to delete this record?";
        const string DISCARD_CHANGES_ERROR = "Discard your changes?";

        const string DEFAULT_BIRTHDAY = "1/jan/1990";
        const string DEFAULT_SEARCH_FROM = "1/jan/1950";
        const string DEFAULT_SEARCH_TO = "1/jan/2025";


        private string connectionString;
        private SqlConnection connection;
        private SqlCommand command;
        private byte[] defaultPhoto;
        private DataTable dataTable;

        private bool isNewData = false;
        private bool isNewPhoto;

        public MainForm()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Telephone_Book__SQL_.Properties.Settings.ContactInfoDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

            defaultPhoto = GetPhotoFromImage();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetEditMode(false);

            LoadData();
            
        }

        private void LoadData()
        {
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter(SELECT_ALL_QUERY, connection);
            dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = FILE_DIALOG_TITLE;
            fileDialog.Filter = FILE_DIALOG_FILTER;
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(fileDialog.FileName);
                isNewPhoto = true;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                return;
            }

            if (isNewData)
            {
                InsertData();
            }
            else
            {
                UpdateData();
            }
            

            LoadData();
            SetEditMode(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isNewData = false;
            isNewPhoto = false;
            SetEditMode(true);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            ShowSelectedInfo();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (groupBoxContactInfo.Enabled)
            {
                if (MessageBox.Show(DISCARD_CHANGES_ERROR, MESSAGE_WINDOW_NAME, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    CreateEmptyContact();
                }
            }
            else
            {
                CreateEmptyContact();
            }


        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRow();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(DISCARD_CHANGES_ERROR, MESSAGE_WINDOW_NAME, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SetEditMode(false);
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void txtPhoneSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void fromDTP_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void toDTP_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void InsertData()
        {
            connection.Open();
            command = new SqlCommand(INSERT_QUERY, connection);
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Phone", txtPhone.Text);
            command.Parameters.AddWithValue("@Birthday", birthdayDTP.Value.Date);
            command.Parameters.AddWithValue("@Photo", GetPhotoFromImage());
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void UpdateData()
        {
            int Original_Id = Convert.ToInt32(dataTable.Rows[0].ItemArray[0].ToString());
            
            connection.Open();
            command = new SqlCommand(UPDATE_QUERY, connection);
            command.Parameters.AddWithValue("@Original_Id", Original_Id);           
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Phone", txtPhone.Text);
            command.Parameters.AddWithValue("@Birthday", birthdayDTP.Value.Date);
            command.ExecuteNonQuery();

            if (isNewPhoto)
            {
                command = new SqlCommand(UPDATE_Photo_QUERY, connection);
                command.Parameters.AddWithValue("@Original_Id", Original_Id);
                command.Parameters.AddWithValue("@Photo", GetPhotoFromImage());
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        private byte[] GetPhotoFromImage()
        {
            if (pictureBox.Image == null)
            {
                return null;
            }

            using (MemoryStream stream = new MemoryStream())
            {
                pictureBox.Image.Save(stream, pictureBox.Image.RawFormat);
                return stream.ToArray();
            }
        }

        private Image GetImageFromByteArray(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return null;
            }

            using (MemoryStream stream = new MemoryStream(byteArray))
            {
                return Image.FromStream(stream);
            }
        }

        private void ShowSelectedInfo()
        {
            connection.Open();

            command = new SqlCommand(SELECT_QUERY, connection);
            command.Parameters.AddWithValue("@Name", dataGridView.CurrentRow.Cells[0].Value.ToString());
            command.Parameters.AddWithValue("@Phone", dataGridView.CurrentRow.Cells[1].Value.ToString());

            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            dataTable = new DataTable();
            sqlData.Fill(dataTable);

            txtName.Text = dataTable.Rows[0].ItemArray[1].ToString();
            txtPhone.Text = dataTable.Rows[0].ItemArray[2].ToString();
            birthdayDTP.Value = DateTime.Parse(dataTable.Rows[0].ItemArray[3].ToString());
            byte[] imageByteArray = (byte[])dataTable.Rows[0].ItemArray[4];
            pictureBox.Image = GetImageFromByteArray(imageByteArray);

            connection.Close();
        } 

        private void SetEditMode(bool mode)
        {
            txtNameSearch.Text = txtPhoneSearch.Text = "";
            fromDTP.Value = DateTime.Parse(DEFAULT_SEARCH_FROM);
            toDTP.Value = DateTime.Parse(DEFAULT_SEARCH_TO);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            if (mode == true)
            {
                groupBoxContactInfo.Enabled = true;
                groupBoxContacts.Enabled = false;
                groupBoxSearch.Enabled = false;
                if (dataGridView.RowCount == 0) return;
                txtName.Focus();
            }
            else
            {
                defaultEmptyContact();
                groupBoxContactInfo.Enabled = false;
                groupBoxContacts.Enabled = true;
                groupBoxSearch.Enabled = true;
                txtNameSearch.Focus();
            }
        }

        private void CreateEmptyContact()
        {
            defaultEmptyContact();
            isNewPhoto = true;
            isNewData = true;
            SetEditMode(true);
        }

        private void defaultEmptyContact()
        {
            txtName.Text = txtPhone.Text = "";
            birthdayDTP.Value = DateTime.Parse(DEFAULT_BIRTHDAY);
            pictureBox.Image = GetImageFromByteArray(defaultPhoto);
        }

        private void DeleteSelectedRowFromDatabase()
        {
            connection.Open();

            command = new SqlCommand(DELETE_QUERY, connection);
            command.Parameters.AddWithValue("@Name", dataGridView.CurrentRow.Cells[0].Value.ToString());
            command.Parameters.AddWithValue("@Phone", dataGridView.CurrentRow.Cells[1].Value.ToString());

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void DeleteSelectedRow()
        {
            if (dataGridView.RowCount == 0) return;
            string contactInfo = "\nName: " + txtName.Text + "\nPhone: " + txtPhone.Text;
            if (MessageBox.Show(DELETE_MESSAGE + contactInfo, MESSAGE_WINDOW_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteSelectedRowFromDatabase();
                LoadData();
                SetEditMode(false);
            }
        }

        private bool isValid()
        {
            int Original_Id = isNewData? -1 : Convert.ToInt32(dataTable.Rows[0].ItemArray[0].ToString());
            connection.Open();

            // Check if the new phone number already exists in the database
            string checkPhoneQuery = "SELECT COUNT(*) FROM ContactInfoT WHERE Phone = @NewPhone AND Id != @Original_Id";
            using (SqlCommand checkPhoneCommand = new SqlCommand(checkPhoneQuery, connection))
            {
                checkPhoneCommand.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                checkPhoneCommand.Parameters.AddWithValue("@Original_Id", Original_Id);

                int matchingPhoneCount = (int)checkPhoneCommand.ExecuteScalar();
                connection.Close();

                if (matchingPhoneCount > 0)
                {
                    MessageBox.Show(DUPLICATE_DATA_ERROR, MESSAGE_WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show(EMPTY_FIELD_ERROR, MESSAGE_WINDOW_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Search()
        {
            connection.Open();
            command = new SqlCommand(SEARCH_QUERY, connection);
            command.Parameters.AddWithValue("@Name", "%" + txtNameSearch.Text + "%");
            command.Parameters.AddWithValue("@Phone", "%" + txtPhoneSearch.Text + "%");
            command.Parameters.AddWithValue("@from", fromDTP.Value.Date);
            command.Parameters.AddWithValue("@to", toDTP.Value.Date);

            SqlDataAdapter sqlData = new SqlDataAdapter(command);
            dataTable = new DataTable();
            sqlData.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }


    }
}
