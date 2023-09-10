
namespace Phamacy_Management_System
{
    partial class Seller_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_button = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_sellers = new System.Windows.Forms.Panel();
            this.dtp_Birth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Sellers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SellName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuElipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse_panelSellers = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_bills = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_sellers = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_medicines = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_customers = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_manufactorers = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_dashboard = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.panel_sellers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_medicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_manufactorers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 755);
            this.panel1.TabIndex = 3;
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.btn_bills);
            this.panel_button.Controls.Add(this.label17);
            this.panel_button.Controls.Add(this.label18);
            this.panel_button.Controls.Add(this.label15);
            this.panel_button.Controls.Add(this.label19);
            this.panel_button.Controls.Add(this.label16);
            this.panel_button.Controls.Add(this.label14);
            this.panel_button.Controls.Add(this.btn_logout);
            this.panel_button.Controls.Add(this.btn_sellers);
            this.panel_button.Controls.Add(this.btn_medicines);
            this.panel_button.Controls.Add(this.btn_customers);
            this.panel_button.Controls.Add(this.btn_manufactorers);
            this.panel_button.Controls.Add(this.btn_dashboard);
            this.panel_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_button.Location = new System.Drawing.Point(11, 179);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(215, 575);
            this.panel_button.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(68, 541);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "LOGOUT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(79, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 22);
            this.label18.TabIndex = 1;
            this.label18.Text = "Manufactorers";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(80, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "Medicines";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.OrangeRed;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(80, 342);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 22);
            this.label19.TabIndex = 1;
            this.label19.Text = "Sellers";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(80, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 22);
            this.label16.TabIndex = 1;
            this.label16.Text = "Customers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(80, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(78, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pharmacy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "One";
            // 
            // panel_sellers
            // 
            this.panel_sellers.BackColor = System.Drawing.Color.White;
            this.panel_sellers.Controls.Add(this.dtp_Birth);
            this.panel_sellers.Controls.Add(this.label5);
            this.panel_sellers.Controls.Add(this.txt_Phone);
            this.panel_sellers.Controls.Add(this.txt_Password);
            this.panel_sellers.Controls.Add(this.cmb_Gender);
            this.panel_sellers.Controls.Add(this.label7);
            this.panel_sellers.Controls.Add(this.label8);
            this.panel_sellers.Controls.Add(this.dgv_Sellers);
            this.panel_sellers.Controls.Add(this.btn_Delete);
            this.panel_sellers.Controls.Add(this.btn_Edit);
            this.panel_sellers.Controls.Add(this.btn_Save);
            this.panel_sellers.Controls.Add(this.label9);
            this.panel_sellers.Controls.Add(this.txt_SellName);
            this.panel_sellers.Controls.Add(this.label3);
            this.panel_sellers.Controls.Add(this.label4);
            this.panel_sellers.Controls.Add(this.label6);
            this.panel_sellers.Controls.Add(this.txt_Address);
            this.panel_sellers.Controls.Add(this.label10);
            this.panel_sellers.Location = new System.Drawing.Point(269, 124);
            this.panel_sellers.Name = "panel_sellers";
            this.panel_sellers.Size = new System.Drawing.Size(1160, 594);
            this.panel_sellers.TabIndex = 6;
            // 
            // dtp_Birth
            // 
            this.dtp_Birth.BackColor = System.Drawing.Color.LimeGreen;
            this.dtp_Birth.BorderRadius = 0;
            this.dtp_Birth.ForeColor = System.Drawing.Color.White;
            this.dtp_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Birth.FormatCustom = null;
            this.dtp_Birth.Location = new System.Drawing.Point(47, 214);
            this.dtp_Birth.Name = "dtp_Birth";
            this.dtp_Birth.Size = new System.Drawing.Size(159, 26);
            this.dtp_Birth.TabIndex = 2;
            this.dtp_Birth.Value = new System.DateTime(2021, 12, 17, 13, 46, 42, 65);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(43, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date of Birth";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Phone.Location = new System.Drawing.Point(573, 86);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(122, 22);
            this.txt_Phone.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Password.Location = new System.Drawing.Point(573, 149);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(122, 22);
            this.txt_Password.TabIndex = 5;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_Gender.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Gender.Location = new System.Drawing.Point(47, 149);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(159, 24);
            this.cmb_Gender.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(43, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(528, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seller List";
            // 
            // dgv_Sellers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Sellers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Sellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Sellers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Sellers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Sellers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Sellers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Sellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sellers.DoubleBuffered = true;
            this.dgv_Sellers.EnableHeadersVisualStyles = false;
            this.dgv_Sellers.HeaderBgColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_Sellers.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Sellers.Location = new System.Drawing.Point(62, 260);
            this.dgv_Sellers.Name = "dgv_Sellers";
            this.dgv_Sellers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Sellers.Size = new System.Drawing.Size(1035, 300);
            this.dgv_Sellers.TabIndex = 5;
            this.dgv_Sellers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Sellers_CellDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(14, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "Seller Details";
            // 
            // txt_SellName
            // 
            this.txt_SellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SellName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_SellName.Location = new System.Drawing.Point(47, 86);
            this.txt_SellName.Name = "txt_SellName";
            this.txt_SellName.Size = new System.Drawing.Size(159, 22);
            this.txt_SellName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(569, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(569, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(43, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Seller Name";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Address.Location = new System.Drawing.Point(255, 84);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(227, 88);
            this.txt_Address.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(251, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Address";
            // 
            // bunifuElipse_Form
            // 
            this.bunifuElipse_Form.ElipseRadius = 50;
            this.bunifuElipse_Form.TargetControl = this;
            // 
            // bunifuElipse_panelSellers
            // 
            this.bunifuElipse_panelSellers.ElipseRadius = 50;
            this.bunifuElipse_panelSellers.TargetControl = this.panel_sellers;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 20.25F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(754, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 33);
            this.label12.TabIndex = 14;
            this.label12.Text = "Sellers";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Phamacy_Management_System.Properties.Resources.Dashboard_CC;
            this.pictureBox2.Location = new System.Drawing.Point(683, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.ActiveBorderThickness = 1;
            this.btn_Delete.ActiveCornerRadius = 20;
            this.btn_Delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Delete.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Delete.BackColor = System.Drawing.Color.White;
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.IdleBorderThickness = 2;
            this.btn_Delete.IdleCornerRadius = 20;
            this.btn_Delete.IdleFillColor = System.Drawing.Color.White;
            this.btn_Delete.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Delete.Location = new System.Drawing.Point(905, 133);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(138, 41);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.ActiveBorderThickness = 1;
            this.btn_Edit.ActiveCornerRadius = 20;
            this.btn_Edit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Edit.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Edit.BackColor = System.Drawing.Color.White;
            this.btn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.BackgroundImage")));
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.IdleBorderThickness = 2;
            this.btn_Edit.IdleCornerRadius = 20;
            this.btn_Edit.IdleFillColor = System.Drawing.Color.White;
            this.btn_Edit.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Edit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Edit.Location = new System.Drawing.Point(993, 82);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(138, 41);
            this.btn_Edit.TabIndex = 7;
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ActiveBorderThickness = 1;
            this.btn_Save.ActiveCornerRadius = 20;
            this.btn_Save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Save.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.BackgroundImage")));
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.IdleBorderThickness = 2;
            this.btn_Save.IdleCornerRadius = 20;
            this.btn_Save.IdleFillColor = System.Drawing.Color.White;
            this.btn_Save.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Save.Location = new System.Drawing.Point(825, 84);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(138, 41);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_bills
            // 
            this.btn_bills.ActiveBorderThickness = 1;
            this.btn_bills.ActiveCornerRadius = 20;
            this.btn_bills.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btn_bills.ActiveForecolor = System.Drawing.Color.White;
            this.btn_bills.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_bills.BackColor = System.Drawing.Color.White;
            this.btn_bills.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_bills.BackgroundImage")));
            this.btn_bills.ButtonText = "Manage Bills";
            this.btn_bills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bills.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_bills.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_bills.IdleBorderThickness = 2;
            this.btn_bills.IdleCornerRadius = 20;
            this.btn_bills.IdleFillColor = System.Drawing.Color.White;
            this.btn_bills.IdleForecolor = System.Drawing.Color.Black;
            this.btn_bills.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_bills.Location = new System.Drawing.Point(33, 407);
            this.btn_bills.Margin = new System.Windows.Forms.Padding(5);
            this.btn_bills.Name = "btn_bills";
            this.btn_bills.Size = new System.Drawing.Size(138, 39);
            this.btn_bills.TabIndex = 13;
            this.btn_bills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bills.Click += new System.EventHandler(this.btn_bills_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Image = global::Phamacy_Management_System.Properties.Resources.Logout_CCNew;
            this.btn_logout.ImageActive = null;
            this.btn_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_logout.Location = new System.Drawing.Point(72, 488);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(65, 50);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 0;
            this.btn_logout.TabStop = false;
            this.btn_logout.Zoom = 10;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_sellers
            // 
            this.btn_sellers.BackColor = System.Drawing.Color.White;
            this.btn_sellers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sellers.Image = global::Phamacy_Management_System.Properties.Resources.Seller_CC;
            this.btn_sellers.ImageActive = null;
            this.btn_sellers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sellers.Location = new System.Drawing.Point(3, 318);
            this.btn_sellers.Name = "btn_sellers";
            this.btn_sellers.Size = new System.Drawing.Size(71, 71);
            this.btn_sellers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_sellers.TabIndex = 0;
            this.btn_sellers.TabStop = false;
            this.btn_sellers.Zoom = 10;
            // 
            // btn_medicines
            // 
            this.btn_medicines.BackColor = System.Drawing.Color.White;
            this.btn_medicines.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_medicines.Image = global::Phamacy_Management_System.Properties.Resources.Medicines_CC;
            this.btn_medicines.ImageActive = null;
            this.btn_medicines.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_medicines.Location = new System.Drawing.Point(3, 88);
            this.btn_medicines.Name = "btn_medicines";
            this.btn_medicines.Size = new System.Drawing.Size(71, 71);
            this.btn_medicines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_medicines.TabIndex = 0;
            this.btn_medicines.TabStop = false;
            this.btn_medicines.Zoom = 10;
            this.btn_medicines.Click += new System.EventHandler(this.btn_medicines_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.Color.White;
            this.btn_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_customers.Image = global::Phamacy_Management_System.Properties.Resources.Customers_CC;
            this.btn_customers.ImageActive = null;
            this.btn_customers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_customers.Location = new System.Drawing.Point(3, 241);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(71, 71);
            this.btn_customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_customers.TabIndex = 0;
            this.btn_customers.TabStop = false;
            this.btn_customers.Zoom = 10;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // btn_manufactorers
            // 
            this.btn_manufactorers.BackColor = System.Drawing.Color.White;
            this.btn_manufactorers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_manufactorers.Image = global::Phamacy_Management_System.Properties.Resources.Manufac_CC;
            this.btn_manufactorers.ImageActive = null;
            this.btn_manufactorers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_manufactorers.Location = new System.Drawing.Point(2, 165);
            this.btn_manufactorers.Name = "btn_manufactorers";
            this.btn_manufactorers.Size = new System.Drawing.Size(71, 71);
            this.btn_manufactorers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_manufactorers.TabIndex = 0;
            this.btn_manufactorers.TabStop = false;
            this.btn_manufactorers.Zoom = 10;
            this.btn_manufactorers.Click += new System.EventHandler(this.btn_manufactorers_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.Image = global::Phamacy_Management_System.Properties.Resources.Dashboard_CC;
            this.btn_dashboard.ImageActive = null;
            this.btn_dashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_dashboard.Location = new System.Drawing.Point(3, 12);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(71, 71);
            this.btn_dashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.TabStop = false;
            this.btn_dashboard.Zoom = 10;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(34, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Seller_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1468, 755);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel_sellers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Seller_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seller_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.panel_sellers.ResumeLayout(false);
            this.panel_sellers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_medicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_manufactorers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuImageButton btn_logout;
        private Bunifu.Framework.UI.BunifuImageButton btn_sellers;
        private Bunifu.Framework.UI.BunifuImageButton btn_medicines;
        private Bunifu.Framework.UI.BunifuImageButton btn_customers;
        private Bunifu.Framework.UI.BunifuImageButton btn_manufactorers;
        private Bunifu.Framework.UI.BunifuImageButton btn_dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_sellers;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Sellers;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Delete;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Save;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SellName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Password;
        private Bunifu.Framework.UI.BunifuDatepicker dtp_Birth;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_Form;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_panelSellers;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_bills;
    }
}