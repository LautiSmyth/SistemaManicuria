using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class PanelValidationBar : UserControl
    {
        public PanelValidationBar()
        {
            InitializeComponent();
        }
        public void BarraValidacion(string text, bool validacion)
        {
            panel.Visible = true;
            int max = panel.MaximumSize.Width;
            if (text == "")
            {
                panel.Width = 0;
            }
            else if (validacion)
            {
                panel.Width = Convert.ToInt32(max * 1);
                panel.BackColor = Color.Green;
            }
            else
            {
                panel.Width = Convert.ToInt32(max * 0.5);
                panel.BackColor = Color.Orange;
            }
        }
    }
}
