namespace GUI
{
    partial class FormShift
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbCustomer = new System.Windows.Forms.ComboBox();
            this.CbService = new System.Windows.Forms.ComboBox();
            this.DateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimeRegister = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridShifts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtHour = new System.Windows.Forms.MaskedTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CbFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSearch = new GUI.TxtLetters();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridShifts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 235);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(402, 40);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cliente";
            // 
            // CbCustomer
            // 
            this.CbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbCustomer.FormattingEnabled = true;
            this.CbCustomer.Location = new System.Drawing.Point(90, 9);
            this.CbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbCustomer.Name = "CbCustomer";
            this.CbCustomer.Size = new System.Drawing.Size(305, 28);
            this.CbCustomer.TabIndex = 20;
            // 
            // CbService
            // 
            this.CbService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbService.FormattingEnabled = true;
            this.CbService.Location = new System.Drawing.Point(90, 8);
            this.CbService.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbService.Name = "CbService";
            this.CbService.Size = new System.Drawing.Size(305, 28);
            this.CbService.TabIndex = 21;
            // 
            // DateTimeDate
            // 
            this.DateTimeDate.CustomFormat = "dd/MM/yyyy";
            this.DateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeDate.Location = new System.Drawing.Point(90, 7);
            this.DateTimeDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimeDate.MinDate = new System.DateTime(2024, 11, 15, 0, 0, 0, 0);
            this.DateTimeDate.Name = "DateTimeDate";
            this.DateTimeDate.Size = new System.Drawing.Size(196, 26);
            this.DateTimeDate.TabIndex = 22;
            // 
            // DateTimeRegister
            // 
            this.DateTimeRegister.CustomFormat = "dd/MM/yyyy";
            this.DateTimeRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeRegister.Location = new System.Drawing.Point(90, 9);
            this.DateTimeRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimeRegister.Name = "DateTimeRegister";
            this.DateTimeRegister.Size = new System.Drawing.Size(196, 26);
            this.DateTimeRegister.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Registro";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(4, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hora";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DataGridShifts
            // 
            this.DataGridShifts.AllowUserToAddRows = false;
            this.DataGridShifts.AllowUserToDeleteRows = false;
            this.DataGridShifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridShifts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridShifts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridShifts.Location = new System.Drawing.Point(402, 80);
            this.DataGridShifts.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridShifts.MultiSelect = false;
            this.DataGridShifts.Name = "DataGridShifts";
            this.DataGridShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridShifts.Size = new System.Drawing.Size(546, 437);
            this.DataGridShifts.TabIndex = 27;
            this.DataGridShifts.TabStop = false;
            this.DataGridShifts.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridShifts_CellBeginEdit);
            this.DataGridShifts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridShifts_CellClick);
            this.DataGridShifts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridShifts_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 517);
            this.panel1.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.DateTimeRegister);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 190);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(402, 45);
            this.panel8.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtHour);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 145);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(402, 45);
            this.panel7.TabIndex = 38;
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(90, 9);
            this.TxtHour.Mask = "00:00";
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(58, 26);
            this.TxtHour.TabIndex = 49;
            this.TxtHour.Text = "0000";
            this.TxtHour.ValidatingType = typeof(System.DateTime);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.DateTimeDate);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 45);
            this.panel6.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.CbService);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 45);
            this.panel5.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CbCustomer);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 45);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 10);
            this.panel4.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CbFilter);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(402, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 80);
            this.panel2.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(7, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Buscar cliente";
            // 
            // CbFilter
            // 
            this.CbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilter.FormattingEnabled = true;
            this.CbFilter.Location = new System.Drawing.Point(79, 5);
            this.CbFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbFilter.Name = "CbFilter";
            this.CbFilter.Size = new System.Drawing.Size(229, 28);
            this.CbFilter.TabIndex = 22;
            this.CbFilter.SelectedIndexChanged += new System.EventHandler(this.CbFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Filtrar";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.Transparent;
            this.TxtSearch.Location = new System.Drawing.Point(138, 43);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(332, 31);
            this.TxtSearch.TabIndex = 24;
            this.TxtSearch.TxtText = "";
            this.TxtSearch.TextChangedControl += new System.EventHandler(this.TxtSearch_TextChangedControl);
            // 
            // FormShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.DataGridShifts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(964, 556);
            this.Name = "FormShift";
            this.Text = "Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridShifts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbCustomer;
        private System.Windows.Forms.ComboBox CbService;
        private System.Windows.Forms.DateTimePicker DateTimeDate;
        private System.Windows.Forms.DateTimePicker DateTimeRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DataGridShifts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtHour;
        private TxtLetters TxtSearch;
    }
}