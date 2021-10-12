using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Institutio.User_Controls
{
    public partial class Institutio_StudentsUserControl : UserControl
    {
        SqlConnection sqlConnection;

        public Institutio_StudentsUserControl()
        {
            InitializeComponent();
        }

        private void Institutio_StudentsUserControl_Load(object sender, EventArgs e)
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
                SqlCommand readCommand = new SqlCommand("Select * From Institutio_StudentTable", sqlConnection);

                DataTable dataTable = new DataTable();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = readCommand;
                sqlDataAdapter.Fill(dataTable);

                Students_DataGridView.DataSource = dataTable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", $"{exception.Data.ToString()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
