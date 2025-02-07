namespace GUI
{
    partial class FormServices
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridServices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblVService = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DataGridSupplies = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSearch = new GUI.TxtLetters();
            this.TxtComission = new GUI.TxtNumbers();
            this.TxtPctComission = new GUI.TxtNumbers();
            this.TxtServicePrice = new GUI.TxtNumbers();
            this.TxtLaborPrice = new GUI.TxtNumbers();
            this.TxtHours = new GUI.TxtNumbers();
            this.TxtService = new GUI.TxtLetters();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServices)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSupplies)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "$ Precio";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 288);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(402, 40);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "$ Total";
            // 
            // DataGridServices
            // 
            this.DataGridServices.AllowUserToAddRows = false;
            this.DataGridServices.AllowUserToDeleteRows = false;
            this.DataGridServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridServices.Location = new System.Drawing.Point(402, 0);
            this.DataGridServices.Margin = new System.Windows.Forms.Padding(6);
            this.DataGridServices.MultiSelect = false;
            this.DataGridServices.Name = "DataGridServices";
            this.DataGridServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridServices.Size = new System.Drawing.Size(546, 288);
            this.DataGridServices.TabIndex = 38;
            this.DataGridServices.TabStop = false;
            this.DataGridServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridServices_CellClick);
            this.DataGridServices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridServices_CellValueChanged);
            this.DataGridServices.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 517);
            this.panel1.TabIndex = 39;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TxtComission);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 242);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(402, 46);
            this.panel9.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "$ Comision";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.TxtPctComission);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 196);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(402, 46);
            this.panel8.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "%Comision";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TxtServicePrice);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 150);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 46);
            this.panel6.TabIndex = 38;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TxtLaborPrice);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 104);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 46);
            this.panel5.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtHours);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 46);
            this.panel3.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtService);
            this.panel2.Controls.Add(this.LblVService);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 46);
            this.panel2.TabIndex = 35;
            // 
            // LblVService
            // 
            this.LblVService.AutoSize = true;
            this.LblVService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVService.ForeColor = System.Drawing.Color.Red;
            this.LblVService.Location = new System.Drawing.Point(76, 33);
            this.LblVService.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblVService.Name = "LblVService";
            this.LblVService.Size = new System.Drawing.Size(73, 13);
            this.LblVService.TabIndex = 40;
            this.LblVService.Text = "*Campo vacio";
            this.LblVService.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 12);
            this.panel4.TabIndex = 34;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DataGridSupplies);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(402, 288);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(546, 229);
            this.panel7.TabIndex = 40;
            // 
            // DataGridSupplies
            // 
            this.DataGridSupplies.AllowUserToAddRows = false;
            this.DataGridSupplies.AllowUserToDeleteRows = false;
            this.DataGridSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridSupplies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSupplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridSupplies.Location = new System.Drawing.Point(0, 40);
            this.DataGridSupplies.Margin = new System.Windows.Forms.Padding(6);
            this.DataGridSupplies.MultiSelect = false;
            this.DataGridSupplies.Name = "DataGridSupplies";
            this.DataGridSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSupplies.Size = new System.Drawing.Size(546, 189);
            this.DataGridSupplies.TabIndex = 39;
            this.DataGridSupplies.TabStop = false;
            this.DataGridSupplies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSupplies_CellValueChanged);
            this.DataGridSupplies.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.TxtSearch);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(546, 40);
            this.panel10.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(116, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Buscar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Insumos";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.Transparent;
            this.TxtSearch.Location = new System.Drawing.Point(191, 8);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(349, 29);
            this.TxtSearch.TabIndex = 42;
            this.TxtSearch.TxtText = "";
            this.TxtSearch.TextChangedControl += new System.EventHandler(this.TxtSearch_TextChangedControl);
            // 
            // TxtComission
            // 
            this.TxtComission.BackColor = System.Drawing.Color.Transparent;
            this.TxtComission.Enabled = false;
            this.TxtComission.Location = new System.Drawing.Point(106, 4);
            this.TxtComission.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtComission.Name = "TxtComission";
            this.TxtComission.Size = new System.Drawing.Size(292, 28);
            this.TxtComission.TabIndex = 16;
            this.TxtComission.TxtText = "0,0";
            // 
            // TxtPctComission
            // 
            this.TxtPctComission.BackColor = System.Drawing.Color.Transparent;
            this.TxtPctComission.Location = new System.Drawing.Point(106, 4);
            this.TxtPctComission.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtPctComission.Name = "TxtPctComission";
            this.TxtPctComission.Size = new System.Drawing.Size(292, 31);
            this.TxtPctComission.TabIndex = 16;
            this.TxtPctComission.TxtText = "0,0";
            this.TxtPctComission.TextChangedControl += new System.EventHandler(this.TxtCalculations_TextChangedControl);
            // 
            // TxtServicePrice
            // 
            this.TxtServicePrice.BackColor = System.Drawing.Color.Transparent;
            this.TxtServicePrice.Enabled = false;
            this.TxtServicePrice.Location = new System.Drawing.Point(89, 4);
            this.TxtServicePrice.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtServicePrice.Name = "TxtServicePrice";
            this.TxtServicePrice.Size = new System.Drawing.Size(309, 30);
            this.TxtServicePrice.TabIndex = 16;
            this.TxtServicePrice.TxtText = "0,0";
            this.TxtServicePrice.TextChangedControl += new System.EventHandler(this.TxtCalculations_TextChangedControl);
            // 
            // TxtLaborPrice
            // 
            this.TxtLaborPrice.BackColor = System.Drawing.Color.Transparent;
            this.TxtLaborPrice.Location = new System.Drawing.Point(89, 4);
            this.TxtLaborPrice.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtLaborPrice.Name = "TxtLaborPrice";
            this.TxtLaborPrice.Size = new System.Drawing.Size(309, 30);
            this.TxtLaborPrice.TabIndex = 15;
            this.TxtLaborPrice.TxtText = "0,0";
            this.TxtLaborPrice.TextChangedControl += new System.EventHandler(this.TxtCalculations_TextChangedControl);
            // 
            // TxtHours
            // 
            this.TxtHours.BackColor = System.Drawing.Color.Transparent;
            this.TxtHours.Location = new System.Drawing.Point(89, 4);
            this.TxtHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHours.Name = "TxtHours";
            this.TxtHours.Size = new System.Drawing.Size(309, 27);
            this.TxtHours.TabIndex = 14;
            this.TxtHours.TxtText = "0,0";
            this.TxtHours.TextChangedControl += new System.EventHandler(this.TxtCalculations_TextChangedControl);
            // 
            // TxtService
            // 
            this.TxtService.BackColor = System.Drawing.Color.Transparent;
            this.TxtService.Location = new System.Drawing.Point(89, 3);
            this.TxtService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtService.Name = "TxtService";
            this.TxtService.Size = new System.Drawing.Size(309, 26);
            this.TxtService.TabIndex = 41;
            this.TxtService.TxtText = "";
            this.TxtService.TextChangedControl += new System.EventHandler(this.TxtService_TextChangedControl);
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.DataGridServices);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(964, 556);
            this.Name = "FormServices";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.FormServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSupplies)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGridServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblVService;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private TxtLetters TxtService;
        private TxtNumbers TxtHours;
        private TxtNumbers TxtComission;
        private TxtNumbers TxtPctComission;
        private TxtNumbers TxtServicePrice;
        private TxtNumbers TxtLaborPrice;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView DataGridSupplies;
        private System.Windows.Forms.Panel panel10;
        private TxtLetters TxtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}