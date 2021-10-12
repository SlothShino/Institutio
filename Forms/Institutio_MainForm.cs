using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Institutio.Forms
{
    public partial class Institutio_MainForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Classes.Database.databaseString);

        public Institutio_MainForm()
        {
            InitializeComponent();
        }
        private void Institutio_MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(MainMenu_Button, Students_Button, Teachers_Button, Settings_Button, Navigation_Panel);
            InstantiateInstitutio_MainMenuUserControl.BringToFront();
        }

        private void Students_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Students_Button, MainMenu_Button, Teachers_Button, Settings_Button, Navigation_Panel);
        }

        private void Teachers_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Teachers_Button, MainMenu_Button, Students_Button, Settings_Button, Navigation_Panel);
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Settings_Button, MainMenu_Button, Students_Button, Teachers_Button, Navigation_Panel);
        }

        private void Exit_Button_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonUI(Button firstButton, Button secondButton, Button thirdButton, Button fourthButton, Panel navigationPanel)
        {
            // Sets The Clicked Button Colors
            firstButton.BackColor = Color.FromArgb(82, 42, 128);
            firstButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(82, 42, 128);
            firstButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(82, 42, 128);
            firstButton.FlatAppearance.CheckedBackColor = Color.FromArgb(82, 42, 128);

            // Sets The Navigation Panel Location To Clicked Button
            navigationPanel.Top = firstButton.Top;
            navigationPanel.Height = firstButton.Height;

            // Sets The Other Buttons
            secondButton.BackColor = Color.FromArgb(41, 25, 62);
            secondButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 25, 62);
            secondButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 25, 62);
            secondButton.FlatAppearance.CheckedBackColor = Color.FromArgb(41, 25, 62);

            thirdButton.BackColor = Color.FromArgb(41, 25, 62);
            thirdButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 25, 62);
            thirdButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 25, 62);
            thirdButton.FlatAppearance.CheckedBackColor = Color.FromArgb(41, 25, 62);

            fourthButton.BackColor = Color.FromArgb(41, 25, 62);
            fourthButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 25, 62);
            fourthButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 25, 62);
            fourthButton.FlatAppearance.CheckedBackColor = Color.FromArgb(41, 25, 62);
        }
    }
}
