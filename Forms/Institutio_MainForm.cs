using System;
using System.Drawing;
using System.Windows.Forms;

namespace Institutio.Forms
{
    public partial class Institutio_MainForm : Form
    {
        public Institutio_MainForm()
        {
            InitializeComponent();
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(MainMenu_Button, Students_Button, Teachers_Button, Settings_Button, Navigation_Panel);
            InstantiateInstitutio_MainMenuUserControl.BringToFront();
        }

        private void Students_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Students_Button, MainMenu_Button, Teachers_Button, Settings_Button, Navigation_Panel);
            InstantiateInstitutio_StudentsUserControl.BringToFront();
        }

        private void Teachers_Button_Click(object sender, EventArgs e)
        {
            ButtonUI(Teachers_Button, MainMenu_Button, Students_Button, Settings_Button, Navigation_Panel);
            InstantiateInstitutio_TeachersUserControl.BringToFront();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Settings Yet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
