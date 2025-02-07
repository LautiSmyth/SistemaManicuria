namespace GUI
{
    partial class FormSupplies
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
            this.DataGridSupplies = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtCustomPrice = new GUI.TxtNumbers();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtYield = new GUI.TxtNumbers();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSupplyPrice = new GUI.TxtNumbers();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.LblVName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSupplies)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridSupplies
            // 
            this.DataGridSupplies.AllowUserToAddRows = false;
            this.DataGridSupplies.AllowUserToDeleteRows = false;
            this.DataGridSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridSupplies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSupplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridSupplies.Location = new System.Drawing.Point(402, 0);
            this.DataGridSupplies.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridSupplies.MultiSelect = false;
            this.DataGridSupplies.Name = "DataGridSupplies";
            this.DataGridSupplies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSupplies.Size = new System.Drawing.Size(546, 517);
            this.DataGridSupplies.TabIndex = 37;
            this.DataGridSupplies.TabStop = false;
            this.DataGridSupplies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSupplies_CellClick);
            this.DataGridSupplies.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSupplies_CellValueChanged);
            this.DataGridSupplies.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGrid_CurrentCellDirtyStateChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BtnAdd);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(402, 517);
            this.panel7.TabIndex = 38;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 252);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(402, 40);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TxtCustomPrice);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 192);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 60);
            this.panel6.TabIndex = 35;
            // 
            // TxtCustomPrice
            // 
            this.TxtCustomPrice.BackColor = System.Drawing.Color.Transparent;
            this.TxtCustomPrice.Enabled = false;
            this.TxtCustomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomPrice.Location = new System.Drawing.Point(137, 17);
            this.TxtCustomPrice.Margin = new System.Windows.Forms.Padding(5);
            this.TxtCustomPrice.Name = "TxtCustomPrice";
            this.TxtCustomPrice.Size = new System.Drawing.Size(254, 27);
            this.TxtCustomPrice.TabIndex = 43;
            this.TxtCustomPrice.TxtText = "0,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7, 18, 0, 0);
            this.label5.Size = new System.Drawing.Size(127, 38);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio Cliente";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtYield);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 60);
            this.panel3.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(7, 18, 0, 0);
            this.label3.Size = new System.Drawing.Size(117, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rendimiento";
            // 
            // TxtYield
            // 
            this.TxtYield.BackColor = System.Drawing.Color.Transparent;
            this.TxtYield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYield.Location = new System.Drawing.Point(139, 16);
            this.TxtYield.Margin = new System.Windows.Forms.Padding(5);
            this.TxtYield.Name = "TxtYield";
            this.TxtYield.Size = new System.Drawing.Size(252, 27);
            this.TxtYield.TabIndex = 42;
            this.TxtYield.TxtText = "0,0";
            this.TxtYield.TextChangedControl += new System.EventHandler(this.TxtCalculateCustomPrice_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtSupplyPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 60);
            this.panel2.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(7, 18, 0, 0);
            this.label2.Size = new System.Drawing.Size(130, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Insumo";
            // 
            // TxtSupplyPrice
            // 
            this.TxtSupplyPrice.BackColor = System.Drawing.Color.Transparent;
            this.TxtSupplyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplyPrice.Location = new System.Drawing.Point(139, 16);
            this.TxtSupplyPrice.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSupplyPrice.Name = "TxtSupplyPrice";
            this.TxtSupplyPrice.Size = new System.Drawing.Size(253, 36);
            this.TxtSupplyPrice.TabIndex = 41;
            this.TxtSupplyPrice.TxtText = "0,0";
            this.TxtSupplyPrice.TextChangedControl += new System.EventHandler(this.TxtCalculateCustomPrice_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtProducto);
            this.panel1.Controls.Add(this.LblVName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 60);
            this.panel1.TabIndex = 30;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(97, 14);
            this.TxtProducto.Margin = new System.Windows.Forms.Padding(5);
            this.TxtProducto.MaxLength = 255;
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(294, 26);
            this.TxtProducto.TabIndex = 0;
            this.TxtProducto.Click += new System.EventHandler(this.TxtName_TextChanged);
            this.TxtProducto.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // LblVName
            // 
            this.LblVName.AutoSize = true;
            this.LblVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVName.ForeColor = System.Drawing.Color.Red;
            this.LblVName.Location = new System.Drawing.Point(94, 41);
            this.LblVName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblVName.Name = "LblVName";
            this.LblVName.Size = new System.Drawing.Size(73, 13);
            this.LblVName.TabIndex = 29;
            this.LblVName.Text = "*Campo vacio";
            this.LblVName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(88, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 12);
            this.panel4.TabIndex = 33;
            // 
            // FormSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.DataGridSupplies);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(964, 556);
            this.Name = "FormSupplies";
            this.Text = "FormSupplies";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSupplies)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSupplies;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label LblVName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private TxtNumbers TxtCustomPrice;
        private TxtNumbers TxtYield;
        private TxtNumbers TxtSupplyPrice;
    }
}