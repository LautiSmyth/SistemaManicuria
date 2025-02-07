namespace GUI
{
    partial class FormCustomers
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.DataGridCustomers = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DateTimeRegister = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.LblVName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelVPhone = new GUI.PanelValidationBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelVEmail = new GUI.PanelValidationBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(76, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.label2.Size = new System.Drawing.Size(84, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.label3.Size = new System.Drawing.Size(58, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(92, 16);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.MaxLength = 255;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(302, 26);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(92, 16);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone.MaxLength = 14;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(301, 26);
            this.TxtPhone.TabIndex = 1;
            this.TxtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(92, 16);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.MaxLength = 255;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(302, 26);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // DataGridCustomers
            // 
            this.DataGridCustomers.AllowUserToAddRows = false;
            this.DataGridCustomers.AllowUserToDeleteRows = false;
            this.DataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridCustomers.Location = new System.Drawing.Point(402, 0);
            this.DataGridCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridCustomers.MultiSelect = false;
            this.DataGridCustomers.Name = "DataGridCustomers";
            this.DataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCustomers.Size = new System.Drawing.Size(546, 517);
            this.DataGridCustomers.TabIndex = 6;
            this.DataGridCustomers.TabStop = false;
            this.DataGridCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCustomers_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(0, 291);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(402, 40);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DateTimeRegister
            // 
            this.DateTimeRegister.CalendarTitleBackColor = System.Drawing.Color.DarkSlateBlue;
            this.DateTimeRegister.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.DateTimeRegister.CalendarTrailingForeColor = System.Drawing.Color.Gainsboro;
            this.DateTimeRegister.CustomFormat = "dd/MM/yyyy";
            this.DateTimeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeRegister.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeRegister.Location = new System.Drawing.Point(90, 14);
            this.DateTimeRegister.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimeRegister.MinDate = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
            this.DateTimeRegister.Name = "DateTimeRegister";
            this.DateTimeRegister.Size = new System.Drawing.Size(175, 26);
            this.DateTimeRegister.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(82, 40);
            this.label4.TabIndex = 24;
            this.label4.Text = "Registro";
            // 
            // LblVName
            // 
            this.LblVName.AutoSize = true;
            this.LblVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVName.ForeColor = System.Drawing.Color.Red;
            this.LblVName.Location = new System.Drawing.Point(89, 43);
            this.LblVName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblVName.Name = "LblVName";
            this.LblVName.Size = new System.Drawing.Size(73, 13);
            this.LblVName.TabIndex = 29;
            this.LblVName.Text = "*Campo vacio";
            this.LblVName.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.LblVName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 60);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.PanelVPhone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 55);
            this.panel2.TabIndex = 31;
            // 
            // PanelVPhone
            // 
            this.PanelVPhone.BackColor = System.Drawing.Color.Transparent;
            this.PanelVPhone.Location = new System.Drawing.Point(93, 38);
            this.PanelVPhone.Margin = new System.Windows.Forms.Padding(4);
            this.PanelVPhone.Name = "PanelVPhone";
            this.PanelVPhone.Size = new System.Drawing.Size(298, 10);
            this.PanelVPhone.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtEmail);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.PanelVEmail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 55);
            this.panel3.TabIndex = 32;
            // 
            // PanelVEmail
            // 
            this.PanelVEmail.BackColor = System.Drawing.Color.Transparent;
            this.PanelVEmail.Location = new System.Drawing.Point(93, 38);
            this.PanelVEmail.Margin = new System.Windows.Forms.Padding(4);
            this.PanelVEmail.Name = "PanelVEmail";
            this.PanelVEmail.Size = new System.Drawing.Size(301, 10);
            this.PanelVEmail.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 10);
            this.panel4.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.DateTimeRegister);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 56);
            this.panel5.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TxtAddress);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 55);
            this.panel6.TabIndex = 35;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(92, 16);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAddress.MaxLength = 255;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(302, 26);
            this.TxtAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.label5.Size = new System.Drawing.Size(89, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Direccion";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BtnAdd);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(402, 517);
            this.panel7.TabIndex = 36;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.DataGridCustomers);
            this.Controls.Add(this.panel7);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(964, 556);
            this.Name = "FormCustomers";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.DataGridView DataGridCustomers;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DateTimePicker DateTimeRegister;
        private System.Windows.Forms.Label label4;
        private PanelValidationBar PanelVEmail;
        private PanelValidationBar PanelVPhone;
        private System.Windows.Forms.Label LblVName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
    }
}