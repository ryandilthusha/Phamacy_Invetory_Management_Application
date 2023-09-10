
namespace Phamacy_Management_System
{
    partial class Billing_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_button = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse_BillingForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_billing = new System.Windows.Forms.Panel();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_CusID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Transactions = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgv_Bill = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MedcineStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_Medine = new System.Windows.Forms.TextBox();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse_panelBilling = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_seller = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_Print = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_AddBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_logout = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.panel_billing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MedcineStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(231, 716);
            this.panel1.TabIndex = 3;
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.label17);
            this.panel_button.Controls.Add(this.btn_logout);
            this.panel_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_button.Location = new System.Drawing.Point(11, 179);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(215, 543);
            this.panel_button.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(68, 493);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "LOGOUT";
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
            // bunifuElipse_BillingForm
            // 
            this.bunifuElipse_BillingForm.ElipseRadius = 50;
            this.bunifuElipse_BillingForm.TargetControl = this;
            // 
            // panel_billing
            // 
            this.panel_billing.BackColor = System.Drawing.Color.White;
            this.panel_billing.Controls.Add(this.btn_Print);
            this.panel_billing.Controls.Add(this.lbl_Amount);
            this.panel_billing.Controls.Add(this.label7);
            this.panel_billing.Controls.Add(this.btn_AddBill);
            this.panel_billing.Controls.Add(this.label5);
            this.panel_billing.Controls.Add(this.txt_price);
            this.panel_billing.Controls.Add(this.txt_quantity);
            this.panel_billing.Controls.Add(this.label9);
            this.panel_billing.Controls.Add(this.cmb_CusID);
            this.panel_billing.Controls.Add(this.label10);
            this.panel_billing.Controls.Add(this.label4);
            this.panel_billing.Controls.Add(this.label3);
            this.panel_billing.Controls.Add(this.label8);
            this.panel_billing.Controls.Add(this.dgv_Transactions);
            this.panel_billing.Controls.Add(this.dgv_Bill);
            this.panel_billing.Controls.Add(this.dgv_MedcineStock);
            this.panel_billing.Controls.Add(this.txt_Medine);
            this.panel_billing.Controls.Add(this.txt_CusName);
            this.panel_billing.Controls.Add(this.label6);
            this.panel_billing.Location = new System.Drawing.Point(263, 90);
            this.panel_billing.Name = "panel_billing";
            this.panel_billing.Size = new System.Drawing.Size(1160, 594);
            this.panel_billing.TabIndex = 6;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Amount.Location = new System.Drawing.Point(885, 256);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(59, 19);
            this.lbl_Amount.TabIndex = 15;
            this.lbl_Amount.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(801, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bill Amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(211, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quntity";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_price.Location = new System.Drawing.Point(215, 59);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(138, 22);
            this.txt_price.TabIndex = 2;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_quantity.Location = new System.Drawing.Point(215, 127);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(138, 22);
            this.txt_quantity.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(211, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "Price";
            // 
            // cmb_CusID
            // 
            this.cmb_CusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmb_CusID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmb_CusID.FormattingEnabled = true;
            this.cmb_CusID.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_CusID.Location = new System.Drawing.Point(42, 57);
            this.cmb_CusID.Name = "cmb_CusID";
            this.cmb_CusID.Size = new System.Drawing.Size(138, 24);
            this.cmb_CusID.TabIndex = 0;
            this.cmb_CusID.SelectionChangeCommitted += new System.EventHandler(this.cmb_CusID_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(123, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Medicine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(800, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bill Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(825, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Bill";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(119, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Medicine Stock";
            // 
            // dgv_Transactions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Transactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Transactions.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Transactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Transactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Transactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Transactions.DoubleBuffered = true;
            this.dgv_Transactions.EnableHeadersVisualStyles = false;
            this.dgv_Transactions.HeaderBgColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_Transactions.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Transactions.Location = new System.Drawing.Point(629, 371);
            this.dgv_Transactions.Name = "dgv_Transactions";
            this.dgv_Transactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Transactions.Size = new System.Drawing.Size(503, 206);
            this.dgv_Transactions.TabIndex = 5;
            // 
            // dgv_Bill
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Bill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bill.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Bill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Bill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Bill.DoubleBuffered = true;
            this.dgv_Bill.EnableHeadersVisualStyles = false;
            this.dgv_Bill.HeaderBgColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_Bill.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Bill.Location = new System.Drawing.Point(629, 44);
            this.dgv_Bill.Name = "dgv_Bill";
            this.dgv_Bill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Bill.Size = new System.Drawing.Size(503, 205);
            this.dgv_Bill.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // dgv_MedcineStock
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_MedcineStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_MedcineStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MedcineStock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_MedcineStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MedcineStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MedcineStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_MedcineStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MedcineStock.DoubleBuffered = true;
            this.dgv_MedcineStock.EnableHeadersVisualStyles = false;
            this.dgv_MedcineStock.HeaderBgColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_MedcineStock.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_MedcineStock.Location = new System.Drawing.Point(19, 331);
            this.dgv_MedcineStock.Name = "dgv_MedcineStock";
            this.dgv_MedcineStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_MedcineStock.Size = new System.Drawing.Size(352, 246);
            this.dgv_MedcineStock.TabIndex = 5;
            this.dgv_MedcineStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MedcineStock_CellDoubleClick);
            // 
            // txt_Medine
            // 
            this.txt_Medine.Enabled = false;
            this.txt_Medine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Medine.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Medine.Location = new System.Drawing.Point(127, 196);
            this.txt_Medine.Name = "txt_Medine";
            this.txt_Medine.Size = new System.Drawing.Size(138, 22);
            this.txt_Medine.TabIndex = 4;
            // 
            // txt_CusName
            // 
            this.txt_CusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CusName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_CusName.Location = new System.Drawing.Point(42, 127);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(138, 22);
            this.txt_CusName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(38, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Customer ID";
            // 
            // bunifuElipse_panelBilling
            // 
            this.bunifuElipse_panelBilling.ElipseRadius = 50;
            this.bunifuElipse_panelBilling.TargetControl = this.panel_billing;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbl_seller
            // 
            this.lbl_seller.AutoSize = true;
            this.lbl_seller.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seller.ForeColor = System.Drawing.Color.Black;
            this.lbl_seller.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_seller.Location = new System.Drawing.Point(1252, 11);
            this.lbl_seller.Name = "lbl_seller";
            this.lbl_seller.Size = new System.Drawing.Size(64, 30);
            this.lbl_seller.TabIndex = 7;
            this.lbl_seller.Text = "Seller";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Showcard Gothic", 20.25F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(754, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 33);
            this.label12.TabIndex = 15;
            this.label12.Text = "Billing";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox7.Location = new System.Drawing.Point(683, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(65, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // btn_Print
            // 
            this.btn_Print.ActiveBorderThickness = 1;
            this.btn_Print.ActiveCornerRadius = 20;
            this.btn_Print.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_Print.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Print.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_Print.BackColor = System.Drawing.Color.White;
            this.btn_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Print.BackgroundImage")));
            this.btn_Print.ButtonText = "Print";
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Print.IdleBorderThickness = 2;
            this.btn_Print.IdleCornerRadius = 20;
            this.btn_Print.IdleFillColor = System.Drawing.Color.White;
            this.btn_Print.IdleForecolor = System.Drawing.Color.Black;
            this.btn_Print.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_Print.Location = new System.Drawing.Point(810, 292);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(138, 41);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_AddBill
            // 
            this.btn_AddBill.ActiveBorderThickness = 1;
            this.btn_AddBill.ActiveCornerRadius = 20;
            this.btn_AddBill.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_AddBill.ActiveForecolor = System.Drawing.Color.White;
            this.btn_AddBill.ActiveLineColor = System.Drawing.Color.Chartreuse;
            this.btn_AddBill.BackColor = System.Drawing.Color.White;
            this.btn_AddBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddBill.BackgroundImage")));
            this.btn_AddBill.ButtonText = "Add to Bill";
            this.btn_AddBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBill.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_AddBill.IdleBorderThickness = 2;
            this.btn_AddBill.IdleCornerRadius = 20;
            this.btn_AddBill.IdleFillColor = System.Drawing.Color.White;
            this.btn_AddBill.IdleForecolor = System.Drawing.Color.Black;
            this.btn_AddBill.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_AddBill.Location = new System.Drawing.Point(127, 234);
            this.btn_AddBill.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AddBill.Name = "btn_AddBill";
            this.btn_AddBill.Size = new System.Drawing.Size(138, 41);
            this.btn_AddBill.TabIndex = 5;
            this.btn_AddBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddBill.Click += new System.EventHandler(this.btn_AddBill_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Image = global::Phamacy_Management_System.Properties.Resources.Logout_CCNew;
            this.btn_logout.ImageActive = null;
            this.btn_logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_logout.Location = new System.Drawing.Point(72, 440);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(65, 50);
            this.btn_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_logout.TabIndex = 0;
            this.btn_logout.TabStop = false;
            this.btn_logout.Zoom = 10;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
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
            // Billing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1452, 716);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_seller);
            this.Controls.Add(this.panel_billing);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.panel_billing.ResumeLayout(false);
            this.panel_billing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MedcineStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuImageButton btn_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_BillingForm;
        private System.Windows.Forms.Panel panel_billing;
        private System.Windows.Forms.ComboBox cmb_CusID;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_MedcineStock;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_AddBill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Bill;
        private System.Windows.Forms.TextBox txt_Medine;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Transactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_panelBilling;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Print;
        private System.Windows.Forms.Label lbl_seller;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}