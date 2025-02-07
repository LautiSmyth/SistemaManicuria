using SHARED.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormRegister : Form
    {
        readonly BLL.UserBLL ticketManager = new BLL.UserBLL();
        readonly List<BE.User> users = new List<BE.User>();
        public FormRegister()
        {
            InitializeComponent();
            InitializeComboBox();
            users = ticketManager.ListUser();
        }

        private void InitializeComboBox()
        {
            CbRole.DataSource = Roles.List;
            CbRole.DisplayMember = "Name";
            CbRole.SelectedIndex = -1;
            CbRole.Texts = "Rol";
        }

        private void MsgError(string msg)
        {
            LblErrorMessage.Text = "*" + msg;
            LblErrorMessage.Visible = true;
        }

        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            if (TxtUser.TxtText != TxtUser.MarkText && !users.Any(user => user.Name == TxtUser.TxtText))
            {
                if (TxtPass.TxtText != TxtPass.MarkText && TxtPass.PassSucces)
                {
                    if (CbRole.Texts != "Rol" && CbRole.SelectedItem != null)
                    {
                        AddUser();
                    }
                    else MsgError("Por favor seleccionar un rol.");
                }
                else if (TxtPass.TxtText != TxtPass.MarkText && !TxtPass.PassSucces) 
                    MsgError("La contraseña no cumple los requisistos.");
                else MsgError("Por favor ingresa la contraseña.");
            }
            else if (TxtUser.TxtText != TxtUser.MarkText && users.Any(user => user.Name.Equals(TxtUser.TxtText, StringComparison.OrdinalIgnoreCase)))
                MsgError("El nombre de usuario ya se encuentra en uso.");
            else MsgError("Por favor ingresa el nombre de usuario.");

        }

        private void AddUser()
        {
            if (TxtUser.TxtText != TxtUser.MarkText && TxtPass.TxtText != TxtPass.MarkText && CbRole.SelectedItem != null)
            {
                try
                {
                    BE.Role role = CbRole.SelectedItem as BE.Role;
                    BE.User user = new BE.User()
                    {
                        Name = TxtUser.Text,
                        IdRole = role.IdRole,
                        Hash = TxtPass.Text,
                    };
                    int ar = ticketManager.AddUser(user);
                    MessageBox.Show(ar + " Usuario Registrado");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
