namespace GUI
{
    partial class FormRegister
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
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbRole = new GUI.CustomComboBox();
            this.TxtPass = new GUI.TxtMultiFunctions();
            this.TxtUser = new GUI.TxtMultiFunctions();
            this.SuspendLayout();
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.LblErrorMessage.Location = new System.Drawing.Point(29, 328);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(72, 13);
            this.LblErrorMessage.TabIndex = 22;
            this.LblErrorMessage.Text = "Mensaje Error";
            this.LblErrorMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(185, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Register";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegister.Location = new System.Drawing.Point(32, 357);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(382, 33);
            this.BtnRegister.TabIndex = 18;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(30, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "________________________________________________________________";
            // 
            // CbRole
            // 
            this.CbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CbRole.BorderColor = System.Drawing.Color.DimGray;
            this.CbRole.BorderSize = 0;
            this.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CbRole.ForeColor = System.Drawing.Color.DimGray;
            this.CbRole.IconColor = System.Drawing.Color.DimGray;
            this.CbRole.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CbRole.ListTextColor = System.Drawing.Color.DimGray;
            this.CbRole.Location = new System.Drawing.Point(33, 264);
            this.CbRole.MinimumSize = new System.Drawing.Size(200, 30);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(383, 30);
            this.CbRole.TabIndex = 27;
            this.CbRole.Texts = "Rol";
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.Transparent;
            this.TxtPass.Location = new System.Drawing.Point(33, 121);
            this.TxtPass.MarkText = "Contraseña";
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(416, 116);
            this.TxtPass.FunctionSystemPasswordChar = true;
            this.TxtPass.TabIndex = 26;
            this.TxtPass.TxtText = "Contraseña";
            this.TxtPass.ValidatePassword = true;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.Transparent;
            this.TxtUser.Location = new System.Drawing.Point(33, 55);
            this.TxtUser.MarkText = "Usuario";
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(380, 29);
            this.TxtUser.FunctionSystemPasswordChar = false;
            this.TxtUser.TabIndex = 25;
            this.TxtUser.TxtText = "Usuario";
            this.TxtUser.ValidatePassword = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.CbRole);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRegister";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblErrorMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label2;
        private TxtMultiFunctions TxtUser;
        private TxtMultiFunctions TxtPass;
        private CustomComboBox CbRole;
    }
}