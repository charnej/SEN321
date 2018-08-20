namespace SHS
{
    partial class ProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCompID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numUpdCompQty = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numUpdCompCost = new System.Windows.Forms.NumericUpDown();
            this.txtUpdCompName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateComp = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numCompQty = new System.Windows.Forms.NumericUpDown();
            this.numCompCost = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddCompName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtDescr = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtAddPD = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblGetProductName = new System.Windows.Forms.Label();
            this.cmboContract = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvProductsContract = new System.Windows.Forms.DataGridView();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.txtAddContractDescription = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAddContractName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchApp = new System.Windows.Forms.Button();
            this.cmboTechnician = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCM = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdCompQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdCompCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompCost)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsContract)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(68, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 370);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCompID);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Component Inventory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.ForeColor = System.Drawing.Color.White;
            this.lblCompID.Location = new System.Drawing.Point(65, 312);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(41, 13);
            this.lblCompID.TabIndex = 9;
            this.lblCompID.Text = "label19";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.numUpdCompQty);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.numUpdCompCost);
            this.panel4.Controls.Add(this.txtUpdCompName);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnUpdateComp);
            this.panel4.Controls.Add(this.dgvStock);
            this.panel4.Location = new System.Drawing.Point(47, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 263);
            this.panel4.TabIndex = 8;
            // 
            // numUpdCompQty
            // 
            this.numUpdCompQty.Location = new System.Drawing.Point(160, 206);
            this.numUpdCompQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpdCompQty.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpdCompQty.Name = "numUpdCompQty";
            this.numUpdCompQty.Size = new System.Drawing.Size(100, 20);
            this.numUpdCompQty.TabIndex = 52;
            this.numUpdCompQty.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Component Name";
            // 
            // numUpdCompCost
            // 
            this.numUpdCompCost.DecimalPlaces = 2;
            this.numUpdCompCost.Location = new System.Drawing.Point(420, 157);
            this.numUpdCompCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUpdCompCost.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpdCompCost.Name = "numUpdCompCost";
            this.numUpdCompCost.Size = new System.Drawing.Size(85, 20);
            this.numUpdCompCost.TabIndex = 51;
            this.numUpdCompCost.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtUpdCompName
            // 
            this.txtUpdCompName.Location = new System.Drawing.Point(160, 157);
            this.txtUpdCompName.Name = "txtUpdCompName";
            this.txtUpdCompName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdCompName.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Component Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.label11.Location = new System.Drawing.Point(141, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 25);
            this.label11.TabIndex = 48;
            this.label11.Text = "Update Component";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(266, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 20);
            this.label14.TabIndex = 49;
            this.label14.Text = "Component Cost";
            // 
            // btnUpdateComp
            // 
            this.btnUpdateComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnUpdateComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateComp.ForeColor = System.Drawing.Color.White;
            this.btnUpdateComp.Location = new System.Drawing.Point(292, 198);
            this.btnUpdateComp.Name = "btnUpdateComp";
            this.btnUpdateComp.Size = new System.Drawing.Size(148, 30);
            this.btnUpdateComp.TabIndex = 47;
            this.btnUpdateComp.Text = "Update Component";
            this.btnUpdateComp.UseVisualStyleBackColor = false;
            this.btnUpdateComp.Click += new System.EventHandler(this.btnUpdateComp_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(26, 50);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(447, 86);
            this.dgvStock.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numCompQty);
            this.panel3.Controls.Add(this.numCompCost);
            this.panel3.Controls.Add(this.btnAddOrder);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtAddCompName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(662, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 263);
            this.panel3.TabIndex = 7;
            // 
            // numCompQty
            // 
            this.numCompQty.Location = new System.Drawing.Point(195, 158);
            this.numCompQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCompQty.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCompQty.Name = "numCompQty";
            this.numCompQty.Size = new System.Drawing.Size(154, 20);
            this.numCompQty.TabIndex = 48;
            this.numCompQty.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numCompCost
            // 
            this.numCompCost.DecimalPlaces = 2;
            this.numCompCost.Location = new System.Drawing.Point(195, 119);
            this.numCompCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCompCost.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCompCost.Name = "numCompCost";
            this.numCompCost.Size = new System.Drawing.Size(154, 20);
            this.numCompCost.TabIndex = 47;
            this.numCompCost.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Location = new System.Drawing.Point(139, 215);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(148, 30);
            this.btnAddOrder.TabIndex = 46;
            this.btnAddOrder.Text = "Add Component";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.label25.Location = new System.Drawing.Point(101, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(214, 25);
            this.label25.TabIndex = 35;
            this.label25.Text = "Add New Component";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Component Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Component Qty";
            // 
            // txtAddCompName
            // 
            this.txtAddCompName.Location = new System.Drawing.Point(194, 73);
            this.txtAddCompName.Name = "txtAddCompName";
            this.txtAddCompName.Size = new System.Drawing.Size(155, 20);
            this.txtAddCompName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Component Cost";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1079, 344);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Products";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblProductID);
            this.panel5.Controls.Add(this.btnUpdateProduct);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dgvProducts);
            this.panel5.Controls.Add(this.txtDescr);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtProductName);
            this.panel5.Location = new System.Drawing.Point(381, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(648, 290);
            this.panel5.TabIndex = 1;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.Location = new System.Drawing.Point(495, 179);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(41, 13);
            this.lblProductID.TabIndex = 50;
            this.lblProductID.Text = "label19";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(349, 243);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(148, 30);
            this.btnUpdateProduct.TabIndex = 48;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.label7.Location = new System.Drawing.Point(247, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Update Product";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 34);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(642, 106);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // txtDescr
            // 
            this.txtDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescr.Location = new System.Drawing.Point(166, 200);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(138, 73);
            this.txtDescr.TabIndex = 4;
            this.txtDescr.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Product Description";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(166, 159);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(138, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.txtAddPD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtAddProductName);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 290);
            this.panel1.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(90, 216);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(148, 30);
            this.btnAddProduct.TabIndex = 49;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtAddPD
            // 
            this.txtAddPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddPD.Location = new System.Drawing.Point(157, 99);
            this.txtAddPD.Name = "txtAddPD";
            this.txtAddPD.Size = new System.Drawing.Size(138, 73);
            this.txtAddPD.TabIndex = 40;
            this.txtAddPD.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.label8.Location = new System.Drawing.Point(69, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Add New Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Product Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Product Description";
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Location = new System.Drawing.Point(157, 58);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(138, 20);
            this.txtAddProductName.TabIndex = 37;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1079, 344);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Contracts";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblGetProductName);
            this.panel7.Controls.Add(this.cmboContract);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.dgvProductsContract);
            this.panel7.Controls.Add(this.btnAddContract);
            this.panel7.Controls.Add(this.txtAddContractDescription);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.txtAddContractName);
            this.panel7.Location = new System.Drawing.Point(15, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1018, 290);
            this.panel7.TabIndex = 2;
            // 
            // lblGetProductName
            // 
            this.lblGetProductName.AutoSize = true;
            this.lblGetProductName.ForeColor = System.Drawing.Color.White;
            this.lblGetProductName.Location = new System.Drawing.Point(4, 267);
            this.lblGetProductName.Name = "lblGetProductName";
            this.lblGetProductName.Size = new System.Drawing.Size(41, 13);
            this.lblGetProductName.TabIndex = 54;
            this.lblGetProductName.Text = "label19";
            // 
            // cmboContract
            // 
            this.cmboContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboContract.FormattingEnabled = true;
            this.cmboContract.Items.AddRange(new object[] {
            "9",
            "12",
            "24"});
            this.cmboContract.Location = new System.Drawing.Point(751, 179);
            this.cmboContract.Name = "cmboContract";
            this.cmboContract.Size = new System.Drawing.Size(121, 21);
            this.cmboContract.TabIndex = 52;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(747, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(202, 20);
            this.label18.TabIndex = 51;
            this.label18.Text = "Contract Duration (months)";
            // 
            // dgvProductsContract
            // 
            this.dgvProductsContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductsContract.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductsContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductsContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsContract.Location = new System.Drawing.Point(110, 34);
            this.dgvProductsContract.MultiSelect = false;
            this.dgvProductsContract.Name = "dgvProductsContract";
            this.dgvProductsContract.ReadOnly = true;
            this.dgvProductsContract.Size = new System.Drawing.Size(844, 103);
            this.dgvProductsContract.TabIndex = 50;
            this.dgvProductsContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsContract_CellClick);
            // 
            // btnAddContract
            // 
            this.btnAddContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnAddContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContract.ForeColor = System.Drawing.Color.White;
            this.btnAddContract.Location = new System.Drawing.Point(458, 250);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(148, 30);
            this.btnAddContract.TabIndex = 49;
            this.btnAddContract.Text = "Add Contract";
            this.btnAddContract.UseVisualStyleBackColor = false;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // txtAddContractDescription
            // 
            this.txtAddContractDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddContractDescription.Location = new System.Drawing.Point(575, 159);
            this.txtAddContractDescription.Name = "txtAddContractDescription";
            this.txtAddContractDescription.Size = new System.Drawing.Size(138, 73);
            this.txtAddContractDescription.TabIndex = 40;
            this.txtAddContractDescription.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.label15.Location = new System.Drawing.Point(421, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 25);
            this.label15.TabIndex = 37;
            this.label15.Text = "Add New Contract";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(43, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Contract Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(404, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Contract Description";
            // 
            // txtAddContractName
            // 
            this.txtAddContractName.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAddContractName.Location = new System.Drawing.Point(223, 159);
            this.txtAddContractName.Name = "txtAddContractName";
            this.txtAddContractName.ReadOnly = true;
            this.txtAddContractName.Size = new System.Drawing.Size(138, 20);
            this.txtAddContractName.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearchApp);
            this.tabPage2.Controls.Add(this.cmboTechnician);
            this.tabPage2.Controls.Add(this.lblChoose);
            this.tabPage2.Controls.Add(this.dgvAppointments);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Appointments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchApp
            // 
            this.btnSearchApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnSearchApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchApp.ForeColor = System.Drawing.Color.White;
            this.btnSearchApp.Location = new System.Drawing.Point(404, 262);
            this.btnSearchApp.Name = "btnSearchApp";
            this.btnSearchApp.Size = new System.Drawing.Size(228, 30);
            this.btnSearchApp.TabIndex = 48;
            this.btnSearchApp.Text = "View Appointments";
            this.btnSearchApp.UseVisualStyleBackColor = false;
            this.btnSearchApp.Click += new System.EventHandler(this.btnSearchApp_Click);
            // 
            // cmboTechnician
            // 
            this.cmboTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboTechnician.FormattingEnabled = true;
            this.cmboTechnician.Location = new System.Drawing.Point(186, 30);
            this.cmboTechnician.Name = "cmboTechnician";
            this.cmboTechnician.Size = new System.Drawing.Size(181, 21);
            this.cmboTechnician.TabIndex = 2;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(31, 31);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(134, 20);
            this.lblChoose.TabIndex = 1;
            this.lblChoose.Text = "Select Technician";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(31, 81);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(1005, 150);
            this.dgvAppointments.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(211)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnTS);
            this.panel2.Controls.Add(this.btnPM);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCM);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 83);
            this.panel2.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1144, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(1082, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 51);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTS
            // 
            this.btnTS.BackColor = System.Drawing.Color.White;
            this.btnTS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTS.FlatAppearance.BorderSize = 0;
            this.btnTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnTS.Location = new System.Drawing.Point(880, 20);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(196, 40);
            this.btnTS.TabIndex = 2;
            this.btnTS.Text = "Technical Support";
            this.btnTS.UseVisualStyleBackColor = false;
            this.btnTS.Click += new System.EventHandler(this.btnTS_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.White;
            this.btnPM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnPM.Location = new System.Drawing.Point(641, 20);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(224, 40);
            this.btnPM.TabIndex = 1;
            this.btnPM.Text = "Product Management";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Management";
            // 
            // btnCM
            // 
            this.btnCM.BackColor = System.Drawing.Color.White;
            this.btnCM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCM.FlatAppearance.BorderSize = 0;
            this.btnCM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnCM.Location = new System.Drawing.Point(412, 20);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(213, 40);
            this.btnCM.TabIndex = 0;
            this.btnCM.Text = "Client Management";
            this.btnCM.UseVisualStyleBackColor = false;
            this.btnCM.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdCompQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdCompCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCompCost)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsContract)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox txtAddCompName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateComp;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.RichTextBox txtDescr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.RichTextBox txtAddPD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numCompCost;
        private System.Windows.Forms.NumericUpDown numCompQty;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.RichTextBox txtAddContractDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAddContractName;
        private System.Windows.Forms.DataGridView dgvProductsContract;
        private System.Windows.Forms.ComboBox cmboContract;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblGetProductName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cmboTechnician;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnSearchApp;
        private System.Windows.Forms.NumericUpDown numUpdCompQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUpdCompCost;
        private System.Windows.Forms.TextBox txtUpdCompName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCompID;
        private System.Windows.Forms.Label lblProductID;
    }
}