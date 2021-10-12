using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Institutio.User_Controls
{
    public partial class Institutio_TeachersUserControl : UserControl
    {
        SqlConnection sqlConnection;

        public Institutio_TeachersUserControl()
        {
            InitializeComponent();
        }

        private void Institutio_TeachersUserControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                sqlConnection = new SqlConnection(Classes.Database.databaseString);
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        private void ShowDatabase()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand readCommand = new SqlCommand("Select * From Institutio_TeacherTable", sqlConnection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = readCommand;
                sqlDataAdapter.Fill(dataTable);

                Teachers_DataGridView.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", $"{exception.Data.ToString()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
