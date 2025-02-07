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
    public partial class TxtNumbers : UserControl
    {
        public TxtNumbers()
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.') 
            {
                e.Handled = false;
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
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
