namespace GUI
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnUserRegister = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.ImgHome = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.TxtPass = new GUI.TxtMultiFunctions();
            this.TxtUser = new GUI.TxtMultiFunctions();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.ForeColor = System.Drawing.Color.LightGray;
            this.BtnLogin.Location = new System.Drawing.Point(225, 213);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(386, 33);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "ACCEDER";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnUserRegister
            // 
            this.BtnUserRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUserRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnUserRegister.FlatAppearance.BorderSize = 0;
            this.BtnUserRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnUserRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnUserRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRegister.ForeColor = System.Drawing.Color.LightGray;
            this.BtnUserRegister.Location = new System.Drawing.Point(512, 295);
            this.BtnUserRegister.Name = "BtnUserRegister";
            this.BtnUserRegister.Size = new System.Drawing.Size(126, 23);
            this.BtnUserRegister.TabIndex = 0;
            this.BtnUserRegister.TabStop = false;
            this.BtnUserRegister.Text = "Registrar Usuario";
            this.BtnUserRegister.UseVisualStyleBackColor = false;
            this.BtnUserRegister.Click += new System.EventHandler(this.BtnUserRegister_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(88)))));
            this.LeftPanel.Controls.Add(this.ImgHome);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(180, 330);
            this.LeftPanel.TabIndex = 7;
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            // 
            // ImgHome
            // 
            this.ImgHome.Image = ((System.Drawing.Image)(resources.GetObject("ImgHome.Image")));
            this.ImgHome.Location = new System.Drawing.Point(33, 108);
            this.ImgHome.Margin = new System.Windows.Forms.Padding(4);
            this.ImgHome.Name = "ImgHome";
            this.ImgHome.Size = new System.Drawing.Size(117, 117);
            this.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgHome.TabIndex = 1;
            this.ImgHome.TabStop = false;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.LightGray;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 18;
            this.BtnMinimize.Location = new System.Drawing.Point(587, 9);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 13);
            this.BtnMinimize.Size = new System.Drawing.Size(24, 23);
            this.BtnMinimize.TabIndex = 14;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.BtnExit.IconColor = System.Drawing.Color.LightGray;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 18;
            this.BtnExit.Location = new System.Drawing.Point(614, 9);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(24, 23);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login";
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.LblErrorMessage.Location = new System.Drawing.Point(222, 184);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(72, 13);
            this.LblErrorMessage.TabIndex = 15;
            this.LblErrorMessage.Text = "Mensaje Error";
            this.LblErrorMessage.Visible = false;
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.Transparent;
            this.TxtPass.Location = new System.Drawing.Point(225, 127);
            this.TxtPass.MarkText = "Contraseña";
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(413, 26);
            this.TxtPass.FunctionSystemPasswordChar = true;
            this.TxtPass.TabIndex = 17;
            this.TxtPass.Tag = "";
            this.TxtPass.TxtText = "Contraseña";
            this.TxtPass.ValidatePassword = false;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.Transparent;
            this.TxtUser.CausesValidation = false;
            this.TxtUser.Location = new System.Drawing.Point(225, 75);
            this.TxtUser.MarkText = "Usuario";
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(391, 26);
            this.TxtUser.FunctionSystemPasswordChar = false;
            this.TxtUser.TabIndex = 16;
            this.TxtUser.Tag = "";
            this.TxtUser.TxtText = "Usuario";
            this.TxtUser.ValidatePassword = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(650, 330);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BtnUserRegister);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(650, 330);
            this.MinimumSize = new System.Drawing.Size(650, 330);
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnUserRegister;
        private System.Windows.Forms.Panel LeftPanel;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnExit;
        private System.Windows.Forms.PictureBox ImgHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblErrorMessage;
        private TxtMultiFunctions TxtUser;
        private TxtMultiFunctions TxtPass;
    }
}

