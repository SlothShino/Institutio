
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
            this.LeftSideMenu_Panel = new System.Windows.Forms.Panel();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.LogoLabel_Panel = new System.Windows.Forms.Panel();
            this.Logo_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel.SuspendLayout();
            this.LeftSideMenu_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.Main_Panel.Controls.Add(this.LeftSideMenu_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1000, 650);
            this.Main_Panel.TabIndex = 0;
            // 
            // LeftSideMenu_Panel
            // 
            this.LeftSideMenu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.LeftSideMenu_Panel.Controls.Add(this.MainMenu_Button);
            this.LeftSideMenu_Panel.Controls.Add(this.LogoLabel_Panel);
            this.LeftSideMenu_Panel.Controls.Add(this.Logo_Panel);
            this.LeftSideMenu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSideMenu_Panel.Location = new System.Drawing.Point(0, 0);
            this.LeftSideMenu_Panel.Name = "LeftSideMenu_Panel";
            this.LeftSideMenu_Panel.Size = new System.Drawing.Size(200, 650);
            this.LeftSideMenu_Panel.TabIndex = 0;
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenu_Button.FlatAppearance.BorderSize = 0;
            this.MainMenu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenu_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenu_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.MainMenu_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainMenu_Button.Location = new System.Drawing.Point(0, 180);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MainMenu_Button.Size = new System.Drawing.Size(200, 50);
            this.MainMenu_Button.TabIndex = 1;
            this.MainMenu_Button.Text = "Main Menu";
            this.MainMenu_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Button.UseVisualStyleBackColor = true;
            // 
            // LogoLabel_Panel
            // 
            this.LogoLabel_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoLabel_Panel.Location = new System.Drawing.Point(0, 150);
            this.LogoLabel_Panel.Name = "LogoLabel_Panel";
            this.LogoLabel_Panel.Size = new System.Drawing.Size(200, 30);
            this.LogoLabel_Panel.TabIndex = 1;
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(200, 150);
            this.Logo_Panel.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel LeftSideMenu_Panel;
        private System.Windows.Forms.Panel Logo_Panel;
        private System.Windows.Forms.Panel LogoLabel_Panel;
        private System.Windows.Forms.Button MainMenu_Button;
    }
}