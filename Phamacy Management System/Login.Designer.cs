
namespace Phamacy_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Admin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse_LoginForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_Panel = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_button = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_Exit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(188, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pharmacy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(137, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "One";
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.White;
            this.panel_Login.Controls.Add(this.btn_Exit);
            this.panel_Login.Controls.Add(this.label3);
            this.panel_Login.Controls.Add(this.label6);
            this.panel_Login.Controls.Add(this.btn_Admin);
            this.panel_Login.Controls.Add(this.btn_Login);
            this.panel_Login.Controls.Add(this.txt_password);
            this.panel_Login.Controls.Add(this.txt_username);
            this.panel_Login.Controls.Add(this.pictureBox1);
            this.panel_Login.Controls.Add(this.pictureBox10);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Controls.Add(this.label2);
            this.panel_Login.Location = new System.Drawing.Point(40, 12);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(463, 626);
            this.panel_Login.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(86, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(86, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Admin.color = System.Drawing.Color.DarkCyan;
            this.btn_Admin.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Admin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Image = ((System.Drawing.Image)(resources.GetObject("btn_Admin.Image")));
            this.btn_Admin.ImagePosition = 14;
            this.btn_Admin.ImageZoom = 40;
            this.btn_Admin.LabelPosition = 29;
            this.btn_Admin.LabelText = "ADMIN";
            this.btn_Admin.Location = new System.Drawing.Point(193, 496);
            this.btn_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(78, 71);
            this.btn_Admin.TabIndex = 3;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.ActiveBorderThickness = 1;
            this.btn_Login.ActiveCornerRadius = 20;
            this.btn_Login.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Login.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Login.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Login.BackColor = System.Drawing.Color.White;
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Login.IdleBorderThickness = 2;
            this.btn_Login.IdleCornerRadius = 20;
            this.btn_Login.IdleFillColor = System.Drawing.Color.White;
            this.btn_Login.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Login.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Login.Location = new System.Drawing.Point(164, 434);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(138, 41);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.Location = new System.Drawing.Point(90, 363);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(276, 31);
            this.txt_password.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.Location = new System.Drawing.Point(90, 296);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(276, 31);
            this.txt_username.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(123, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox10.Location = new System.Drawing.Point(90, 184);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(276, 15);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // bunifuElipse_LoginForm
            // 
            this.bunifuElipse_LoginForm.ElipseRadius = 50;
            this.bunifuElipse_LoginForm.TargetControl = this;
            // 
            // bunifuElipse_Panel
            // 
            this.bunifuElipse_Panel.ElipseRadius = 50;
            this.bunifuElipse_Panel.TargetControl = this.panel_Login;
            // 
            // bunifuElipse_button
            // 
            this.bunifuElipse_button.ElipseRadius = 40;
            this.bunifuElipse_button.TargetControl = this.btn_Admin;
            // 
            // btn_Exit
            // 
            this.btn_Exit.ActiveBorderThickness = 1;
            this.btn_Exit.ActiveCornerRadius = 20;
            this.btn_Exit.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Exit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Exit.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.ButtonText = "EXIT";
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Exit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Exit.IdleBorderThickness = 2;
            this.btn_Exit.IdleCornerRadius = 20;
            this.btn_Exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Exit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Exit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Exit.Location = new System.Drawing.Point(164, 576);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(138, 39);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(550, 667);
            this.Controls.Add(this.panel_Login);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Login;
        private Bunifu.Framework.UI.BunifuTileButton btn_Admin;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_LoginForm;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Panel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Exit;
    }
}