﻿
namespace Institutio.Forms
{
    partial class Institutio_AwakeForm
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
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.UserControl_Panel = new System.Windows.Forms.Panel();
            this.WindowState_Panel = new System.Windows.Forms.Panel();
            this.LeftSideMenu_Panel = new System.Windows.Forms.Panel();
            this.Navigation_Panel = new System.Windows.Forms.Panel();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.Teachers_Button = new System.Windows.Forms.Button();
            this.Students_Button = new System.Windows.Forms.Button();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.LogoLabel_Panel = new System.Windows.Forms.Panel();
            this.MainLogo_Label = new System.Windows.Forms.Label();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.MainLogo_PictureBox = new System.Windows.Forms.PictureBox();
            this.Main_Panel.SuspendLayout();
            this.LeftSideMenu_Panel.SuspendLayout();
            this.LogoLabel_Panel.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.Main_Panel.Controls.Add(this.UserControl_Panel);
            this.Main_Panel.Controls.Add(this.WindowState_Panel);
            this.Main_Panel.Controls.Add(this.LeftSideMenu_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1000, 650);
            this.Main_Panel.TabIndex = 0;
            // 
            // UserControl_Panel
            // 
            this.UserControl_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl_Panel.Location = new System.Drawing.Point(200, 30);
            this.UserControl_Panel.Name = "UserControl_Panel";
            this.UserControl_Panel.Size = new System.Drawing.Size(800, 620);
            this.UserControl_Panel.TabIndex = 2;
            // 
            // WindowState_Panel
            // 
            this.WindowState_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowState_Panel.Location = new System.Drawing.Point(200, 0);
            this.WindowState_Panel.Name = "WindowState_Panel";
            this.WindowState_Panel.Size = new System.Drawing.Size(800, 30);
            this.WindowState_Panel.TabIndex = 1;
            // 
            // LeftSideMenu_Panel
            // 
            this.LeftSideMenu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.LeftSideMenu_Panel.Controls.Add(this.Navigation_Panel);
            this.LeftSideMenu_Panel.Controls.Add(this.Settings_Button);
            this.LeftSideMenu_Panel.Controls.Add(this.Teachers_Button);
            this.LeftSideMenu_Panel.Controls.Add(this.Students_Button);
            this.LeftSideMenu_Panel.Controls.Add(this.MainMenu_Button);
            this.LeftSideMenu_Panel.Controls.Add(this.LogoLabel_Panel);
            this.LeftSideMenu_Panel.Controls.Add(this.Logo_Panel);
            this.LeftSideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.LeftSideMenu_Panel.Name = "LeftSideMenu_Panel";
            this.LeftSideMenu_Panel.Size = new System.Drawing.Size(200, 650);
            this.LeftSideMenu_Panel.TabIndex = 0;
            // 
            // Navigation_Panel
            // 
            this.Navigation_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.Navigation_Panel.Location = new System.Drawing.Point(0, 180);
            this.Navigation_Panel.Name = "Navigation_Panel";
            this.Navigation_Panel.Size = new System.Drawing.Size(2, 50);
            this.Navigation_Panel.TabIndex = 5;
            // 
            // Settings_Button
            // 
            this.Settings_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Settings_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.Settings_Button.Image = global::Institutio.Institutio_Resources.Institutio_SettingsButtonIcon;
            this.Settings_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.Location = new System.Drawing.Point(0, 600);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Settings_Button.Size = new System.Drawing.Size(200, 50);
            this.Settings_Button.TabIndex = 4;
            this.Settings_Button.Text = "Settings";
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_Button.UseVisualStyleBackColor = true;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // Teachers_Button
            // 
            this.Teachers_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Teachers_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Teachers_Button.FlatAppearance.BorderSize = 0;
            this.Teachers_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Teachers_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Teachers_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teachers_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Teachers_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.Teachers_Button.Image = global::Institutio.Institutio_Resources.Institutio_TeachersButtonIcon;
            this.Teachers_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Teachers_Button.Location = new System.Drawing.Point(0, 280);
            this.Teachers_Button.Name = "Teachers_Button";
            this.Teachers_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Teachers_Button.Size = new System.Drawing.Size(200, 50);
            this.Teachers_Button.TabIndex = 3;
            this.Teachers_Button.Text = "Teachers";
            this.Teachers_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teachers_Button.UseVisualStyleBackColor = true;
            this.Teachers_Button.Click += new System.EventHandler(this.Teachers_Button_Click);
            // 
            // Students_Button
            // 
            this.Students_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Students_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Students_Button.FlatAppearance.BorderSize = 0;
            this.Students_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Students_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Students_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Students_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Students_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.Students_Button.Image = global::Institutio.Institutio_Resources.Institutio_StudentsButtonIcon;
            this.Students_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Students_Button.Location = new System.Drawing.Point(0, 230);
            this.Students_Button.Name = "Students_Button";
            this.Students_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Students_Button.Size = new System.Drawing.Size(200, 50);
            this.Students_Button.TabIndex = 2;
            this.Students_Button.Text = "Students";
            this.Students_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Students_Button.UseVisualStyleBackColor = true;
            this.Students_Button.Click += new System.EventHandler(this.Students_Button_Click);
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.MainMenu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenu_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu_Button.FlatAppearance.BorderSize = 0;
            this.MainMenu_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.MainMenu_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.MainMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenu_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.MainMenu_Button.Image = global::Institutio.Institutio_Resources.Institutio_HomeButtonIcon;
            this.MainMenu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenu_Button.Location = new System.Drawing.Point(0, 180);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.MainMenu_Button.Size = new System.Drawing.Size(200, 50);
            this.MainMenu_Button.TabIndex = 1;
            this.MainMenu_Button.Text = "Main Menu";
            this.MainMenu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Button.UseVisualStyleBackColor = false;
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            // 
            // LogoLabel_Panel
            // 
            this.LogoLabel_Panel.Controls.Add(this.MainLogo_Label);
            this.LogoLabel_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoLabel_Panel.Location = new System.Drawing.Point(0, 150);
            this.LogoLabel_Panel.Name = "LogoLabel_Panel";
            this.LogoLabel_Panel.Size = new System.Drawing.Size(200, 30);
            this.LogoLabel_Panel.TabIndex = 1;
            // 
            // MainLogo_Label
            // 
            this.MainLogo_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLogo_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainLogo_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.MainLogo_Label.Location = new System.Drawing.Point(0, 0);
            this.MainLogo_Label.Name = "MainLogo_Label";
            this.MainLogo_Label.Size = new System.Drawing.Size(200, 30);
            this.MainLogo_Label.TabIndex = 0;
            this.MainLogo_Label.Text = "Institutio";
            this.MainLogo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.Controls.Add(this.MainLogo_PictureBox);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(200, 150);
            this.Logo_Panel.TabIndex = 0;
            // 
            // MainLogo_PictureBox
            // 
            this.MainLogo_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLogo_PictureBox.Image = global::Institutio.Institutio_Resources.Institutio_MainLogoIcon;
            this.MainLogo_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainLogo_PictureBox.Name = "MainLogo_PictureBox";
            this.MainLogo_PictureBox.Size = new System.Drawing.Size(200, 150);
            this.MainLogo_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MainLogo_PictureBox.TabIndex = 0;
            this.MainLogo_PictureBox.TabStop = false;
            // 
            // Institutio_AwakeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Institutio_AwakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Institutio";
            this.Main_Panel.ResumeLayout(false);
            this.LeftSideMenu_Panel.ResumeLayout(false);
            this.LogoLabel_Panel.ResumeLayout(false);
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogo_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel LeftSideMenu_Panel;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.Panel LogoLabel_Panel;
        private System.Windows.Forms.Button MainMenu_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button Teachers_Button;
        private System.Windows.Forms.Button Students_Button;
        private System.Windows.Forms.Label MainLogo_Label;
        private System.Windows.Forms.PictureBox MainLogo_PictureBox;
        private System.Windows.Forms.Panel Navigation_Panel;
        private System.Windows.Forms.Panel WindowState_Panel;
        private System.Windows.Forms.Panel UserControl_Panel;
    }
}