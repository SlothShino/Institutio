﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Institutio.User_Controls
{
    public partial class Institutio_MainMenuUserControl : UserControl
    {
        SqlConnection sqlConnection = new SqlConnection(Classes.Database.databaseString);

        public Institutio_MainMenuUserControl()
        {
            InitializeComponent();
        }

        private void Institutio_MainMenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand addStudentCommand = new SqlCommand("Insert Into Institutio_StudentTable (Student_Name, Student_Surname, Student_Age, Student_Gender, Student_BloodGroup, Student_Field, Student_Year) Values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)");
                addStudentCommand.Parameters.AddWithValue("@p1", StudentName_TextBox.Text);
                addStudentCommand.Parameters.AddWithValue("@p2", StudentSurname_TextBox.Text);
                addStudentCommand.Parameters.AddWithValue("@p3", StudentAge_TextBox.Text);
                addStudentCommand.Parameters.AddWithValue("@p4", StudentGender_TextBox.Text);
                addStudentCommand.Parameters.AddWithValue("@p5", StudentBloodGroup_TextBox.Text);
                addStudentCommand.Parameters.AddWithValue("@p6", StudentField_TextBox.Text);
                addStudentCommand.Parameters.AddWithValue("@p7", StudentYear_TextBox.Text);
                addStudentCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("New Student Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", $"{exception.Data.ToString()}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StudentName_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentName_TextBox.Text == "  Student Name:")
            {
                StudentName_TextBox.Clear();
            }
        }

        private void StudentSurname_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentSurname_TextBox.Text == "  Student Surname:")
            {
                StudentSurname_TextBox.Clear();
            }
        }

        private void StudentAge_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentAge_TextBox.Text == "  Student Age:")
            {
                StudentAge_TextBox.Clear();
            }
        }

        private void StudentGender_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentGender_TextBox.Text == "  Student Gender:")
            {
                StudentGender_TextBox.Clear();
            }
        }

        private void StudentBloodGroup_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentBloodGroup_TextBox.Text == "  Student Blood Group:")
            {
                StudentBloodGroup_TextBox.Clear();
            }
        }

        private void StudentField_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentField_TextBox.Text == "  Student Blood Group:")
            {
                StudentField_TextBox.Clear();
            }
        }

        private void StudentYear_TextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (StudentYear_TextBox.Text == "  Student Year:")
            {
                StudentYear_TextBox.Clear();
            }
        }
    }
}
