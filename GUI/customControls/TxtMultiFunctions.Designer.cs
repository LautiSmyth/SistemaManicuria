namespace GUI
{
    partial class TxtMultiFunctions
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt = new System.Windows.Forms.TextBox();
            this.LblLine = new System.Windows.Forms.Label();
            this.LblSpecialChar = new System.Windows.Forms.Label();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblLetterUpper = new System.Windows.Forms.Label();
            this.LblLetterLower = new System.Windows.Forms.Label();
            this.LblCaractMin = new System.Windows.Forms.Label();
            this.BtnEyeVisible = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.ForeColor = System.Drawing.Color.DimGray;
            this.Txt.Location = new System.Drawing.Point(0, 0);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(380, 19);
            this.Txt.TabIndex = 12;
            this.Txt.Text = "Text";
            this.Txt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.Txt.Enter += new System.EventHandler(this.Txt_Enter);
            this.Txt.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // LblLine
            // 
            this.LblLine.AutoSize = true;
            this.LblLine.ForeColor = System.Drawing.Color.DimGray;
            this.LblLine.Location = new System.Drawing.Point(-3, 10);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(391, 13);
            this.LblLine.TabIndex = 13;
            this.LblLine.Text = "________________________________________________________________";
            // 
            // LblSpecialChar
            // 
            this.LblSpecialChar.AutoSize = true;
            this.LblSpecialChar.ForeColor = System.Drawing.Color.Red;
            this.LblSpecialChar.Location = new System.Drawing.Point(-4, 83);
            this.LblSpecialChar.Name = "LblSpecialChar";
            this.LblSpecialChar.Size = new System.Drawing.Size(233, 13);
            this.LblSpecialChar.TabIndex = 34;
            this.LblSpecialChar.Text = "*Caractere especiale o símbolo (ej: “[ % , \\ ! @”)";
            this.LblSpecialChar.Visible = false;
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.ForeColor = System.Drawing.Color.Red;
            this.LblNumber.Location = new System.Drawing.Point(-4, 70);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(53, 13);
            this.LblNumber.TabIndex = 33;
            this.LblNumber.Text = "*Numeros";
            this.LblNumber.Visible = false;
            // 
            // LblLetterUpper
            // 
            this.LblLetterUpper.AutoSize = true;
            this.LblLetterUpper.ForeColor = System.Drawing.Color.Red;
            this.LblLetterUpper.Location = new System.Drawing.Point(-4, 57);
            this.LblLetterUpper.Name = "LblLetterUpper";
            this.LblLetterUpper.Size = new System.Drawing.Size(88, 13);
            this.LblLetterUpper.TabIndex = 32;
            this.LblLetterUpper.Text = "*Letra mayuscula";
            this.LblLetterUpper.Visible = false;
            // 
            // LblLetterLower
            // 
            this.LblLetterLower.AutoSize = true;
            this.LblLetterLower.ForeColor = System.Drawing.Color.Red;
            this.LblLetterLower.Location = new System.Drawing.Point(-3, 44);
            this.LblLetterLower.Name = "LblLetterLower";
            this.LblLetterLower.Size = new System.Drawing.Size(85, 13);
            this.LblLetterLower.TabIndex = 31;
            this.LblLetterLower.Text = "*Letra minuscula";
            this.LblLetterLower.Visible = false;
            // 
            // LblCaractMin
            // 
            this.LblCaractMin.AutoSize = true;
            this.LblCaractMin.ForeColor = System.Drawing.Color.Red;
            this.LblCaractMin.Location = new System.Drawing.Point(-3, 31);
            this.LblCaractMin.Name = "LblCaractMin";
            this.LblCaractMin.Size = new System.Drawing.Size(106, 13);
            this.LblCaractMin.TabIndex = 30;
            this.LblCaractMin.Text = "*Minimo 8 caracteres";
            this.LblCaractMin.Visible = false;
            // 
            // BtnEyeVisible
            // 
            this.BtnEyeVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEyeVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.BtnEyeVisible.IconColor = System.Drawing.Color.LightGray;
            this.BtnEyeVisible.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEyeVisible.IconSize = 18;
            this.BtnEyeVisible.Location = new System.Drawing.Point(387, 0);
            this.BtnEyeVisible.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEyeVisible.Name = "BtnEyeVisible";
            this.BtnEyeVisible.Size = new System.Drawing.Size(24, 23);
            this.BtnEyeVisible.TabIndex = 35;
            this.BtnEyeVisible.TabStop = false;
            this.BtnEyeVisible.UseVisualStyleBackColor = true;
            this.BtnEyeVisible.Visible = false;
            this.BtnEyeVisible.Click += new System.EventHandler(this.BtnEyeVisible_Click);
            // 
            // LabelMultiFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BtnEyeVisible);
            this.Controls.Add(this.LblSpecialChar);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.LblLetterUpper);
            this.Controls.Add(this.LblLetterLower);
            this.Controls.Add(this.LblCaractMin);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.LblLine);
            this.Name = "LabelMultiFunctions";
            this.Size = new System.Drawing.Size(412, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.Label LblLine;
        private System.Windows.Forms.Label LblSpecialChar;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblLetterUpper;
        private System.Windows.Forms.Label LblLetterLower;
        private System.Windows.Forms.Label LblCaractMin;
        private FontAwesome.Sharp.IconButton BtnEyeVisible;
    }
}
