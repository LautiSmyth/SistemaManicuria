using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TxtLetters : UserControl
    {
        public TxtLetters()
        {
            InitializeComponent();
        }

        public string TxtText
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        public event EventHandler TextChangedControl;

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar !=' ')
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextChangedControl?.Invoke(this, e);
        }
    }
}
