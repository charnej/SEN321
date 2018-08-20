namespace SHS
{
    partial class TechnicalSupport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicalSupport));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTS = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCM = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.cmboAppType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboUnassigned = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnFindTechnicians = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tvPersonnel = new System.Windows.Forms.TreeView();
            this.toolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLogout = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 25;
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
            this.btnExit.Location = new System.Drawing.Point(1151, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 49);
            this.btnExit.TabIndex = 28;
            this.toolTipExit.SetToolTip(this.btnExit, "Logout and exit");
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
            this.btnLogout.Location = new System.Drawing.Point(1092, 14);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(56, 51);
            this.btnLogout.TabIndex = 27;
            this.toolTipLogout.SetToolTip(this.btnLogout, "Logout");
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
            this.btnTS.Location = new System.Drawing.Point(886, 20);
            this.btnTS.Name = "btnTS";
            this.btnTS.Size = new System.Drawing.Size(196, 42);
            this.btnTS.TabIndex = 2;
            this.btnTS.Text = "Technical Support";
            this.btnTS.UseVisualStyleBackColor = false;
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
            this.btnPM.Location = new System.Drawing.Point(646, 20);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(224, 42);
            this.btnPM.TabIndex = 1;
            this.btnPM.Text = "Product Management";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Technical Department";
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
            this.btnCM.Location = new System.Drawing.Point(417, 20);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(213, 42);
            this.btnCM.TabIndex = 0;
            this.btnCM.Text = "Client Management";
            this.btnCM.UseVisualStyleBackColor = false;
            this.btnCM.Click += new System.EventHandler(this.btnCM_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(44, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 375);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlOrders);
            this.tabPage1.Controls.Add(this.btnFindTechnicians);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.tvPersonnel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schedule Technicians";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.cmboAppType);
            this.pnlOrders.Controls.Add(this.label4);
            this.pnlOrders.Controls.Add(this.label2);
            this.pnlOrders.Controls.Add(this.cmboUnassigned);
            this.pnlOrders.Controls.Add(this.btnAssign);
            this.pnlOrders.Location = new System.Drawing.Point(483, 41);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(463, 254);
            this.pnlOrders.TabIndex = 54;
            // 
            // cmboAppType
            // 
            this.cmboAppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboAppType.FormattingEnabled = true;
            this.cmboAppType.Items.AddRange(new object[] {
            "Installation",
            "Maintenance",
            "Upgrades"});
            this.cmboAppType.Location = new System.Drawing.Point(174, 80);
            this.cmboAppType.Name = "cmboAppType";
            this.cmboAppType.Size = new System.Drawing.Size(228, 21);
            this.cmboAppType.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Appointment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unassigned Orders";
            // 
            // cmboUnassigned
            // 
            this.cmboUnassigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboUnassigned.FormattingEnabled = true;
            this.cmboUnassigned.Location = new System.Drawing.Point(16, 41);
            this.cmboUnassigned.Name = "cmboUnassigned";
            this.cmboUnassigned.Size = new System.Drawing.Size(386, 21);
            this.cmboUnassigned.TabIndex = 1;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(174, 124);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(148, 30);
            this.btnAssign.TabIndex = 48;
            this.btnAssign.Text = "Assign Order";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnFindTechnicians
            // 
            this.btnFindTechnicians.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(189)))), ((int)(((byte)(211)))));
            this.btnFindTechnicians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindTechnicians.ForeColor = System.Drawing.Color.White;
            this.btnFindTechnicians.Location = new System.Drawing.Point(218, 66);
            this.btnFindTechnicians.Name = "btnFindTechnicians";
            this.btnFindTechnicians.Size = new System.Drawing.Size(219, 30);
            this.btnFindTechnicians.TabIndex = 53;
            this.btnFindTechnicians.Text = "Find Available Technicians";
            this.btnFindTechnicians.UseVisualStyleBackColor = false;
            this.btnFindTechnicians.Click += new System.EventHandler(this.btnFindTechnicians_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Appointment Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // tvPersonnel
            // 
            this.tvPersonnel.Location = new System.Drawing.Point(218, 111);
            this.tvPersonnel.Name = "tvPersonnel";
            this.tvPersonnel.Size = new System.Drawing.Size(219, 184);
            this.tvPersonnel.TabIndex = 49;
            // 
            // TechnicalSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TechnicalSupport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technical Support";
            this.Load += new System.EventHandler(this.TechnicalSupport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTS;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmboUnassigned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TreeView tvPersonnel;
        private System.Windows.Forms.Button btnFindTechnicians;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.ComboBox cmboAppType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolTip toolTipExit;
        private System.Windows.Forms.ToolTip toolTipLogout;
    }
}