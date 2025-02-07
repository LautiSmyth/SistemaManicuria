namespace GUI
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnSupplies = new FontAwesome.Sharp.IconButton();
            this.BtnLogout = new FontAwesome.Sharp.IconButton();
            this.BtnService = new FontAwesome.Sharp.IconButton();
            this.BtnTickets = new FontAwesome.Sharp.IconButton();
            this.BtnShifts = new FontAwesome.Sharp.IconButton();
            this.BtnCustomers = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.ImgHome = new System.Windows.Forms.PictureBox();
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitleForm = new System.Windows.Forms.Label();
            this.LblUserLoginName = new System.Windows.Forms.Label();
            this.IconCurrentForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblClock = new System.Windows.Forms.Label();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.PanelGains = new System.Windows.Forms.Panel();
            this.DataGridGains = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelExpenses = new System.Windows.Forms.Panel();
            this.DataGridExpenses = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblSupplyExpenses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).BeginInit();
            this.PanelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelDesktop.SuspendLayout();
            this.PanelGains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGains)).BeginInit();
            this.panel6.SuspendLayout();
            this.PanelExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExpenses)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(58)))));
            this.PanelMenu.Controls.Add(this.BtnSupplies);
            this.PanelMenu.Controls.Add(this.BtnLogout);
            this.PanelMenu.Controls.Add(this.BtnService);
            this.PanelMenu.Controls.Add(this.BtnTickets);
            this.PanelMenu.Controls.Add(this.BtnShifts);
            this.PanelMenu.Controls.Add(this.BtnCustomers);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 621);
            this.PanelMenu.TabIndex = 5;
            // 
            // BtnSupplies
            // 
            this.BtnSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSupplies.FlatAppearance.BorderSize = 0;
            this.BtnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplies.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSupplies.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.BtnSupplies.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnSupplies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSupplies.IconSize = 35;
            this.BtnSupplies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplies.Location = new System.Drawing.Point(0, 360);
            this.BtnSupplies.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSupplies.Name = "BtnSupplies";
            this.BtnSupplies.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnSupplies.Size = new System.Drawing.Size(220, 60);
            this.BtnSupplies.TabIndex = 7;
            this.BtnSupplies.Text = "Insumos";
            this.BtnSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupplies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSupplies.UseVisualStyleBackColor = true;
            this.BtnSupplies.Click += new System.EventHandler(this.BtnSupplies_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.BtnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogout.IconSize = 35;
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.Location = new System.Drawing.Point(0, 561);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnLogout.Size = new System.Drawing.Size(220, 60);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Cerrar Sesion";
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnService
            // 
            this.BtnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnService.FlatAppearance.BorderSize = 0;
            this.BtnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnService.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.BtnService.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnService.IconSize = 35;
            this.BtnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnService.Location = new System.Drawing.Point(0, 300);
            this.BtnService.Margin = new System.Windows.Forms.Padding(4);
            this.BtnService.Name = "BtnService";
            this.BtnService.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnService.Size = new System.Drawing.Size(220, 60);
            this.BtnService.TabIndex = 4;
            this.BtnService.Text = "Servicios";
            this.BtnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnService.UseVisualStyleBackColor = true;
            this.BtnService.Click += new System.EventHandler(this.BtnServices_Click);
            // 
            // BtnTickets
            // 
            this.BtnTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTickets.FlatAppearance.BorderSize = 0;
            this.BtnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTickets.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnTickets.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.BtnTickets.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTickets.IconSize = 35;
            this.BtnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTickets.Location = new System.Drawing.Point(0, 240);
            this.BtnTickets.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnTickets.Size = new System.Drawing.Size(220, 60);
            this.BtnTickets.TabIndex = 3;
            this.BtnTickets.Text = "Facturas";
            this.BtnTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTickets.UseVisualStyleBackColor = true;
            this.BtnTickets.Click += new System.EventHandler(this.BtnTickets_Click);
            // 
            // BtnShifts
            // 
            this.BtnShifts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnShifts.FlatAppearance.BorderSize = 0;
            this.BtnShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShifts.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnShifts.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.BtnShifts.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnShifts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnShifts.IconSize = 35;
            this.BtnShifts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShifts.Location = new System.Drawing.Point(0, 180);
            this.BtnShifts.Margin = new System.Windows.Forms.Padding(4);
            this.BtnShifts.Name = "BtnShifts";
            this.BtnShifts.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnShifts.Size = new System.Drawing.Size(220, 60);
            this.BtnShifts.TabIndex = 2;
            this.BtnShifts.Text = "Turnos";
            this.BtnShifts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShifts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnShifts.UseVisualStyleBackColor = true;
            this.BtnShifts.Click += new System.EventHandler(this.BtnShifts_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCustomers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnCustomers.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCustomers.IconSize = 35;
            this.BtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.Location = new System.Drawing.Point(0, 120);
            this.BtnCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.BtnCustomers.Size = new System.Drawing.Size(220, 60);
            this.BtnCustomers.TabIndex = 1;
            this.BtnCustomers.Text = "Clientes";
            this.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCustomers.UseVisualStyleBackColor = true;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.ImgHome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 120);
            this.PanelLogo.TabIndex = 0;
            // 
            // ImgHome
            // 
            this.ImgHome.Image = ((System.Drawing.Image)(resources.GetObject("ImgHome.Image")));
            this.ImgHome.Location = new System.Drawing.Point(31, 21);
            this.ImgHome.Margin = new System.Windows.Forms.Padding(4);
            this.ImgHome.Name = "ImgHome";
            this.ImgHome.Size = new System.Drawing.Size(153, 91);
            this.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgHome.TabIndex = 0;
            this.ImgHome.TabStop = false;
            this.ImgHome.Click += new System.EventHandler(this.ImgHome_Click);
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.PanelTitleBar.Controls.Add(this.panel2);
            this.PanelTitleBar.Controls.Add(this.panel1);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(964, 65);
            this.PanelTitleBar.TabIndex = 6;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblTitleForm);
            this.panel2.Controls.Add(this.LblUserLoginName);
            this.panel2.Controls.Add(this.IconCurrentForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 45);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // LblTitleForm
            // 
            this.LblTitleForm.AutoSize = true;
            this.LblTitleForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitleForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTitleForm.Location = new System.Drawing.Point(43, 0);
            this.LblTitleForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitleForm.Name = "LblTitleForm";
            this.LblTitleForm.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.LblTitleForm.Size = new System.Drawing.Size(55, 27);
            this.LblTitleForm.TabIndex = 1;
            this.LblTitleForm.Text = "Home";
            // 
            // LblUserLoginName
            // 
            this.LblUserLoginName.AutoSize = true;
            this.LblUserLoginName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblUserLoginName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblUserLoginName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblUserLoginName.Location = new System.Drawing.Point(859, 0);
            this.LblUserLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserLoginName.Name = "LblUserLoginName";
            this.LblUserLoginName.Padding = new System.Windows.Forms.Padding(0, 10, 30, 0);
            this.LblUserLoginName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUserLoginName.Size = new System.Drawing.Size(105, 27);
            this.LblUserLoginName.TabIndex = 5;
            this.LblUserLoginName.Text = "UserName";
            this.LblUserLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IconCurrentForm
            // 
            this.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(63)))));
            this.IconCurrentForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentForm.IconSize = 43;
            this.IconCurrentForm.Location = new System.Drawing.Point(0, 0);
            this.IconCurrentForm.Margin = new System.Windows.Forms.Padding(4);
            this.IconCurrentForm.Name = "IconCurrentForm";
            this.IconCurrentForm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.IconCurrentForm.Size = new System.Drawing.Size(43, 45);
            this.IconCurrentForm.TabIndex = 0;
            this.IconCurrentForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblClock);
            this.panel1.Controls.Add(this.BtnMinimize);
            this.panel1.Controls.Add(this.BtnMaximize);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 20);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblClock.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblClock.Location = new System.Drawing.Point(0, 0);
            this.LblClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClock.Name = "LblClock";
            this.LblClock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.LblClock.Size = new System.Drawing.Size(69, 17);
            this.LblClock.TabIndex = 6;
            this.LblClock.Text = "00:00:00";
            this.LblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.Silver;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 18;
            this.BtnMinimize.Location = new System.Drawing.Point(904, 0);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.BtnMinimize.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximize.IconColor = System.Drawing.Color.Silver;
            this.BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximize.IconSize = 18;
            this.BtnMaximize.Location = new System.Drawing.Point(924, 0);
            this.BtnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(20, 20);
            this.BtnMaximize.TabIndex = 3;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.UseVisualStyleBackColor = true;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.BtnExit.IconColor = System.Drawing.Color.Silver;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 18;
            this.BtnExit.Location = new System.Drawing.Point(944, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(20, 20);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.PanelDesktop.Controls.Add(this.PanelGains);
            this.PanelDesktop.Controls.Add(this.PanelExpenses);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(220, 65);
            this.PanelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(964, 556);
            this.PanelDesktop.TabIndex = 7;
            // 
            // PanelGains
            // 
            this.PanelGains.AutoSize = true;
            this.PanelGains.Controls.Add(this.DataGridGains);
            this.PanelGains.Controls.Add(this.panel6);
            this.PanelGains.Controls.Add(this.panel3);
            this.PanelGains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGains.Location = new System.Drawing.Point(475, 0);
            this.PanelGains.Name = "PanelGains";
            this.PanelGains.Padding = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.PanelGains.Size = new System.Drawing.Size(489, 556);
            this.PanelGains.TabIndex = 9;
            // 
            // DataGridGains
            // 
            this.DataGridGains.AllowUserToAddRows = false;
            this.DataGridGains.AllowUserToDeleteRows = false;
            this.DataGridGains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridGains.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridGains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridGains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridGains.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridGains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridGains.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DataGridGains.Location = new System.Drawing.Point(0, 115);
            this.DataGridGains.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridGains.MultiSelect = false;
            this.DataGridGains.Name = "DataGridGains";
            this.DataGridGains.ReadOnly = true;
            this.DataGridGains.RowHeadersVisible = false;
            this.DataGridGains.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridGains.Size = new System.Drawing.Size(479, 421);
            this.DataGridGains.TabIndex = 41;
            this.DataGridGains.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(479, 47);
            this.panel6.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ganancia neta por Servicio";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 48);
            this.panel3.TabIndex = 42;
            // 
            // PanelExpenses
            // 
            this.PanelExpenses.Controls.Add(this.DataGridExpenses);
            this.PanelExpenses.Controls.Add(this.panel5);
            this.PanelExpenses.Controls.Add(this.panel4);
            this.PanelExpenses.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelExpenses.Location = new System.Drawing.Point(0, 0);
            this.PanelExpenses.Name = "PanelExpenses";
            this.PanelExpenses.Padding = new System.Windows.Forms.Padding(20, 20, 0, 20);
            this.PanelExpenses.Size = new System.Drawing.Size(475, 556);
            this.PanelExpenses.TabIndex = 8;
            // 
            // DataGridExpenses
            // 
            this.DataGridExpenses.AllowUserToAddRows = false;
            this.DataGridExpenses.AllowUserToDeleteRows = false;
            this.DataGridExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGridExpenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            this.DataGridExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridExpenses.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridExpenses.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DataGridExpenses.Location = new System.Drawing.Point(20, 115);
            this.DataGridExpenses.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridExpenses.MultiSelect = false;
            this.DataGridExpenses.Name = "DataGridExpenses";
            this.DataGridExpenses.ReadOnly = true;
            this.DataGridExpenses.RowHeadersVisible = false;
            this.DataGridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridExpenses.Size = new System.Drawing.Size(451, 421);
            this.DataGridExpenses.TabIndex = 38;
            this.DataGridExpenses.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(20, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 47);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos por Servicio";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblSupplyExpenses);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 48);
            this.panel4.TabIndex = 2;
            // 
            // LblSupplyExpenses
            // 
            this.LblSupplyExpenses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblSupplyExpenses.AutoSize = true;
            this.LblSupplyExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplyExpenses.ForeColor = System.Drawing.Color.MediumPurple;
            this.LblSupplyExpenses.Location = new System.Drawing.Point(274, 4);
            this.LblSupplyExpenses.Name = "LblSupplyExpenses";
            this.LblSupplyExpenses.Size = new System.Drawing.Size(24, 31);
            this.LblSupplyExpenses.TabIndex = 1;
            this.LblSupplyExpenses.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gastos de Insumos:";
            // 
            // TimerClock
            // 
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 660);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).EndInit();
            this.PanelTitleBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            this.PanelGains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGains)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PanelExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridExpenses)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton BtnCustomers;
        private System.Windows.Forms.PictureBox ImgHome;
        private FontAwesome.Sharp.IconButton BtnService;
        private FontAwesome.Sharp.IconButton BtnTickets;
        private FontAwesome.Sharp.IconButton BtnShifts;
        private System.Windows.Forms.Panel PanelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentForm;
        private System.Windows.Forms.Label LblTitleForm;
        private System.Windows.Forms.Panel PanelDesktop;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private System.Windows.Forms.Label LblUserLoginName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnSupplies;
        private System.Windows.Forms.Panel PanelExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblSupplyExpenses;
        private System.Windows.Forms.DataGridView DataGridExpenses;
        private System.Windows.Forms.Panel PanelGains;
        private System.Windows.Forms.DataGridView DataGridGains;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.Timer TimerClock;
    }
}