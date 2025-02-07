namespace GUI
{
    partial class FormTickets
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
            this.DateTimeRegister = new System.Windows.Forms.DateTimePicker();
            this.CbCustomer = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtServiceCost = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.CbShift = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSeeServices = new System.Windows.Forms.Button();
            this.DataGridTickets = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.TxtExtra = new GUI.TxtNumbers();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TxtHour = new System.Windows.Forms.MaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTickets)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimeRegister
            // 
            this.DateTimeRegister.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DateTimeRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeRegister.Location = new System.Drawing.Point(90, 5);
            this.DateTimeRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimeRegister.Name = "DateTimeRegister";
            this.DateTimeRegister.Size = new System.Drawing.Size(182, 26);
            this.DateTimeRegister.TabIndex = 34;
            // 
            // CbCustomer
            // 
            this.CbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbCustomer.FormattingEnabled = true;
            this.CbCustomer.Location = new System.Drawing.Point(69, 5);
            this.CbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbCustomer.Name = "CbCustomer";
            this.CbCustomer.Size = new System.Drawing.Size(323, 28);
            this.CbCustomer.TabIndex = 32;
            this.CbCustomer.SelectedIndexChanged += new System.EventHandler(this.CbCustomer_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(0, 466);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(402, 40);
            this.BtnDelete.TabIndex = 31;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 426);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(402, 40);
            this.BtnAdd.TabIndex = 29;
            this.BtnAdd.Text = "Facturar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Registro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(1, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total Servicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(1, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Extra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(1, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Total";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(5, 27);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(387, 64);
            this.TxtDescription.TabIndex = 39;
            // 
            // TxtServiceCost
            // 
            this.TxtServiceCost.Enabled = false;
            this.TxtServiceCost.Location = new System.Drawing.Point(135, 6);
            this.TxtServiceCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtServiceCost.Name = "TxtServiceCost";
            this.TxtServiceCost.Size = new System.Drawing.Size(257, 26);
            this.TxtServiceCost.TabIndex = 40;
            this.TxtServiceCost.Text = "0,0";
            this.TxtServiceCost.TextChanged += new System.EventHandler(this.CaculateTotal_TextChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(60, 5);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(332, 26);
            this.TxtTotal.TabIndex = 42;
            this.TxtTotal.Text = "0,0";
            // 
            // CbShift
            // 
            this.CbShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbShift.FormattingEnabled = true;
            this.CbShift.Location = new System.Drawing.Point(69, 7);
            this.CbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbShift.Name = "CbShift";
            this.CbShift.Size = new System.Drawing.Size(323, 28);
            this.CbShift.TabIndex = 44;
            this.CbShift.SelectedIndexChanged += new System.EventHandler(this.CbShift_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(1, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Turno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(1, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Hora";
            // 
            // BtnSeeServices
            // 
            this.BtnSeeServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeeServices.Location = new System.Drawing.Point(5, 6);
            this.BtnSeeServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSeeServices.Name = "BtnSeeServices";
            this.BtnSeeServices.Size = new System.Drawing.Size(141, 27);
            this.BtnSeeServices.TabIndex = 47;
            this.BtnSeeServices.Text = "Ver Servicios";
            this.BtnSeeServices.UseVisualStyleBackColor = true;
            this.BtnSeeServices.Click += new System.EventHandler(this.BtnSeeServices_Click);
            // 
            // DataGridTickets
            // 
            this.DataGridTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridTickets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridTickets.Location = new System.Drawing.Point(402, 0);
            this.DataGridTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridTickets.MultiSelect = false;
            this.DataGridTickets.Name = "DataGridTickets";
            this.DataGridTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridTickets.Size = new System.Drawing.Size(546, 517);
            this.DataGridTickets.TabIndex = 49;
            this.DataGridTickets.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 517);
            this.panel1.TabIndex = 50;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.DateTimeRegister);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 386);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(402, 40);
            this.panel11.TabIndex = 58;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.TxtTotal);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 346);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(402, 40);
            this.panel10.TabIndex = 57;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.TxtExtra);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 306);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(402, 40);
            this.panel9.TabIndex = 56;
            // 
            // TxtExtra
            // 
            this.TxtExtra.BackColor = System.Drawing.Color.Transparent;
            this.TxtExtra.Location = new System.Drawing.Point(60, 9);
            this.TxtExtra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtExtra.Name = "TxtExtra";
            this.TxtExtra.Size = new System.Drawing.Size(332, 31);
            this.TxtExtra.TabIndex = 42;
            this.TxtExtra.TxtText = "0,0";
            this.TxtExtra.TextChangedControl += new System.EventHandler(this.CaculateTotal_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.TxtServiceCost);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 266);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(402, 40);
            this.panel8.TabIndex = 55;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtDescription);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 170);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(402, 96);
            this.panel7.TabIndex = 54;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnSeeServices);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 40);
            this.panel6.TabIndex = 53;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TxtHour);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 40);
            this.panel5.TabIndex = 52;
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(69, 6);
            this.TxtHour.Mask = "00:00";
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(58, 26);
            this.TxtHour.TabIndex = 48;
            this.TxtHour.Text = "0000";
            this.TxtHour.ValidatingType = typeof(System.DateTime);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CbShift);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 40);
            this.panel3.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CbCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 40);
            this.panel2.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 10);
            this.panel4.TabIndex = 49;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.DataGridTickets);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(964, 556);
            this.Name = "FormTickets";
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTickets)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimeRegister;
        private System.Windows.Forms.ComboBox CbCustomer;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtServiceCost;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.ComboBox CbShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnSeeServices;
        private System.Windows.Forms.DataGridView DataGridTickets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox TxtHour;
        private TxtNumbers TxtExtra;
    }
}