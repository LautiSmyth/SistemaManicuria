using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class TxtMultiFunctions : UserControl
    {
        //Propietys
        private string markText;
        [Category("Custom - Appareance")]
        public string MarkText
        {
            get { return markText; }
            set { markText = value; }
        }
        [Category("Custom - Appareance")]
        public string TxtText
        {
            get { return Txt.Text; }
            set { Txt.Text = value; }
        }
        [Category("Custom - Appareance")]
        public Color Forecolor
        {
            get{return Txt.ForeColor;}
            set { Txt.ForeColor = value; }
        }

        //SystemPasswordChar
        private bool systemPasswordChar;
        [Category("Custom - Functions")]
        public bool FunctionSystemPasswordChar
        {
            get { return systemPasswordChar; }
            set
            {
                systemPasswordChar = value;
                BtnEyeVisible.Visible = value;
            }
        }
        public bool UseSystemPasswordChar
        {
            get { return Txt.UseSystemPasswordChar; }
            set
            {
                Txt.UseSystemPasswordChar = value;
            }
        }

        //ValidatePassword
        private bool validatePassword;
        [Category("Custom - Functions")]
        public bool ValidatePassword
        {
            get { return validatePassword; }
            set
            {
                validatePassword = value;
                if (validatePassword)
                    foreach (Control control in Controls)
                    {
                        if (control is Label label && label.Name != "LblLine")
                            label.Visible = true;
                    }
            }
        }
        private bool passSucces = false;

        public bool PassSucces
        {
            get { return passSucces; }
            private set { passSucces = value; }
        }


        //Constructor
        public TxtMultiFunctions()
        {
            InitializeComponent();
        }

        //Events
        //Fill and Focus to textBox
        private void Txt_Enter(object sender, EventArgs e)
        {
            if (Txt.Text == markText)
            {
                Txt.Text = "";
                Txt.ForeColor = Color.LightGray;
                if (systemPasswordChar) Txt.UseSystemPasswordChar = true;
            }
        }
        private void Txt_Leave(object sender, EventArgs e)
        {
            if (Txt.Text == "")
            {
                Txt.Text = markText;
                Txt.ForeColor = Color.DimGray;
                if (systemPasswordChar) Txt.UseSystemPasswordChar = false;
            }
        }
        //Validate Password
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            int val = 0;
            if (validatePassword && TxtText != markText)
            {
                string pass = Txt.Text;
                if (Regex.IsMatch(pass, @".{8,}"))
                {
                    LblCaractMin.ForeColor = Color.Green;
                    val++;
                }
                else 
                { 
                    LblCaractMin.ForeColor = Color.Red;
                    val--;
                }
                if (Regex.IsMatch(pass, @"[a-z]"))
                {
                    LblLetterLower.ForeColor = Color.Green;
                    val++;
                }
                else
                {
                    LblLetterLower.ForeColor = Color.Red;
                    val--;
                }
                if (Regex.IsMatch(pass, @"[A-Z]"))
                {
                    LblLetterUpper.ForeColor = Color.Green;
                    val++;
                }
                else
                {
                    LblLetterUpper.ForeColor = Color.Red;
                    val--;
                }
                if (Regex.IsMatch(pass, @"\d"))
                {
                    LblNumber.ForeColor = Color.Green;
                    val++;
                }
                else
                {
                    LblNumber.ForeColor = Color.Red;
                    val--;
                }
                if (Regex.IsMatch(pass, @"\W"))
                {
                    LblSpecialChar.ForeColor = Color.Green;
                    val++;
                }
                else
                {
                    LblSpecialChar.ForeColor = Color.Red;
                    val--;
                }
                if (val == 5) PassSucces = true;
                else PassSucces = false;
            }
        }

        private void BtnEyeVisible_Click(object sender, EventArgs e)
        {
            if (Txt.Text != markText)
            {
                if (BtnEyeVisible.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
                {
                    BtnEyeVisible.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    Txt.UseSystemPasswordChar = false;
                }
                else
                {
                    BtnEyeVisible.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                    Txt.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
