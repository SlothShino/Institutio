
namespace Institutio.User_Controls
{
    partial class Institutio_TeachersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.Teachers_DataGridView = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftMargin_Panel = new System.Windows.Forms.Panel();
            this.RightMargin_Panel = new System.Windows.Forms.Panel();
            this.BottomMargin_Panel = new System.Windows.Forms.Panel();
            this.TopMargin_Panel = new System.Windows.Forms.Panel();
            this.Main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Teachers_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(42)))), ((int)(((byte)(128)))));
            this.Main_Panel.Controls.Add(this.Teachers_DataGridView);
            this.Main_Panel.Controls.Add(this.Refresh_Button);
            this.Main_Panel.Controls.Add(this.panel4);
            this.Main_Panel.Controls.Add(this.panel3);
            this.Main_Panel.Controls.Add(this.panel2);
            this.Main_Panel.Controls.Add(this.panel1);
            this.Main_Panel.Controls.Add(this.LeftMargin_Panel);
            this.Main_Panel.Controls.Add(this.RightMargin_Panel);
            this.Main_Panel.Controls.Add(this.BottomMargin_Panel);
            this.Main_Panel.Controls.Add(this.TopMargin_Panel);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(800, 620);
            this.Main_Panel.TabIndex = 1;
            // 
            // Teachers_DataGridView
            // 
            this.Teachers_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Teachers_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Teachers_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Teachers_DataGridView.Location = new System.Drawing.Point(12, 12);
            this.Teachers_DataGridView.Name = "Teachers_DataGridView";
            this.Teachers_DataGridView.RowTemplate.Height = 25;
            this.Teachers_DataGridView.Size = new System.Drawing.Size(776, 546);
            this.Teachers_DataGridView.TabIndex = 13;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Refresh_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Refresh_Button.FlatAppearance.BorderSize = 0;
            this.Refresh_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Refresh_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Refresh_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Refresh_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.Refresh_Button.Image = global::Institutio.Institutio_Resources.Institutio_RefreshIcon;
            this.Refresh_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refresh_Button.Location = new System.Drawing.Point(12, 558);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.Refresh_Button.Size = new System.Drawing.Size(776, 50);
            this.Refresh_Button.TabIndex = 12;
            this.Refresh_Button.Text = "Refresh Teachers Database";
            this.Refresh_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh_Button.UseVisualStyleBackColor = false;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(10, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 596);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(788, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 596);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 2);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(87)))), ((int)(((byte)(213)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 2);
            this.panel1.TabIndex = 8;
            // 
            // LeftMargin_Panel
            // 
            this.LeftMargin_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMargin_Panel.Location = new System.Drawing.Point(0, 10);
            this.LeftMargin_Panel.Name = "LeftMargin_Panel";
            this.LeftMargin_Panel.Size = new System.Drawing.Size(10, 600);
            this.LeftMargin_Panel.TabIndex = 7;
            // 
            // RightMargin_Panel
            // 
            this.RightMargin_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMargin_Panel.Location = new System.Drawing.Point(790, 10);
            this.RightMargin_Panel.Name = "RightMargin_Panel";
            this.RightMargin_Panel.Size = new System.Drawing.Size(10, 600);
            this.RightMargin_Panel.TabIndex = 6;
            // 
            // BottomMargin_Panel
            // 
            this.BottomMargin_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMargin_Panel.Location = new System.Drawing.Point(0, 610);
            this.BottomMargin_Panel.Name = "BottomMargin_Panel";
            this.BottomMargin_Panel.Size = new System.Drawing.Size(800, 10);
            this.BottomMargin_Panel.TabIndex = 5;
            // 
            // TopMargin_Panel
            // 
            this.TopMargin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMargin_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopMargin_Panel.Name = "TopMargin_Panel";
            this.TopMargin_Panel.Size = new System.Drawing.Size(800, 10);
            this.TopMargin_Panel.TabIndex = 4;
            // 
            // Institutio_TeachersUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Main_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Institutio_TeachersUserControl";
            this.Size = new System.Drawing.Size(800, 620);
            this.Load += new System.EventHandler(this.Institutio_TeachersUserControl_Load);
            this.Main_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Teachers_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.DataGridView Teachers_DataGridView;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftMargin_Panel;
        private System.Windows.Forms.Panel RightMargin_Panel;
        private System.Windows.Forms.Panel BottomMargin_Panel;
        private System.Windows.Forms.Panel TopMargin_Panel;
    }
}
