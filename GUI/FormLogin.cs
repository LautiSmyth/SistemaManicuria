using SHARED.Cache;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLogin : Form
    {
        //Singleton
        private static FormLogin _instance;
        public static FormLogin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FormLogin();
                }
                return _instance;
            }
        }

        //Field
        private readonly BLL.RoleBLL managerRole = new BLL.RoleBLL();
        private readonly string userText = "Usuario";
        private readonly string passText = "Contraseña";

        //Constructor
        public FormLogin()
        {
            InitializeComponent();
            Roles.List = managerRole.ListRole();
        }

        //Methods
        void ValidateUser()
        {
            BLL.UserBLL ticketManager = new BLL.UserBLL();
            try
            {
                ticketManager.ValidateUser(TxtUser.TxtText, TxtPass.TxtText);
                FormMenu Menu = new FormMenu();
                Menu.Show();
                Menu.FormClosed += Logout;
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                TxtPass.TxtText = passText;
                TxtPass.UseSystemPasswordChar = false;
                TxtPass.Forecolor = Color.DimGray;
                TxtUser.Focus();
            }
        }
        private void MsgError(string msg)
        {
            LblErrorMessage.Text = "*" + msg;
            LblErrorMessage.Visible = true;
        }

        //Events
        //Login/out
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.TxtText != userText)
            {
                if (TxtPass.TxtText != passText)
                {
                    ValidateUser();
                }
                else MsgError("Por favor ingresa la contraseña.");
            }
            else MsgError("Por favor ingresa el nombre de usuario.");
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            TxtPass.TxtText = passText;
            TxtPass.UseSystemPasswordChar = false;
            TxtPass.Forecolor = Color.DimGray;
            TxtUser.TxtText = userText;
            LblErrorMessage.Visible = false;
            TxtUser.Forecolor = Color.DimGray;
            Show();
        }
        public void CloseSession(Form menu)
        {
            menu.Close();
            MessageBox.Show("La sesión ha sido cerrada debido a inactividad.");
            
        }
        //Btn Register
        private void BtnUserRegister_Click(object sender, EventArgs e)
        {
            Hide();
            FormRegister formUser = new FormRegister();
            formUser.ShowDialog();
            Show();
        }

        //Close-Minimize
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
