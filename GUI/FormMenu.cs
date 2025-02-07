using FontAwesome.Sharp;
using SHARED.Cache;
using System;
using System.ServiceProcess;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace GUI
{
    public partial class FormMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;

        private const int InactivityTimeout = 10 * 1000;
        private readonly Timer inactivityTimer;
        private bool inactivityMessageSent = false;

        //Constructor
        private static FormMenu instance;
        public static FormMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMenu();
                }
                return instance;
            }

        }

        public FormMenu()
        {
            InitializeComponent();
            ManagePermissions();
            LoadExpenses();
            //Lbl UserLoginName
            LblUserLoginName.Text = UserLoginCache.Role.Name + " - " + UserLoginCache.Name;
            //LeftPanel
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            PanelMenu.Controls.Add(leftBorderBtn);
            //Form
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            inactivityTimer = new Timer
            {
                Interval = 1000
            };
            inactivityTimer.Tick += InactivityTimer_Tick;
            inactivityTimer.Start();
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ManagePermissions()
        {
            //if (UserLoginCache.Role == )
            //{
            //}
        }
        private void ActivateButton(object senderBtn, Color customColor)
        {

            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = senderBtn as IconButton;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = customColor;
                currentBtn.IconColor = customColor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //left Border
                leftBorderBtn.BackColor = customColor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //current Form icon
                IconCurrentForm.IconChar = currentBtn.IconChar;
                IconCurrentForm.IconColor = customColor;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Close();
            PanelExpenses.Visible = false;
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitleForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentForm.IconChar = IconChar.Home;
            IconCurrentForm.IconColor = Color.MediumPurple;
            LblTitleForm.Text = "Home";
            LoadExpenses();
        }
        private void LoadExpenses()
        {
            BLL.ServiceBLL serviceManager = new BLL.ServiceBLL();
            BLL.SupplyBLL supplyManager = new BLL.SupplyBLL();
            PanelExpenses.Visible = true;
            DataGridExpenses.DataSource = null;
            DataGridExpenses.DataSource = serviceManager.ListExpensesForService();
            DataGridExpenses.ClearSelection();
            DataGridExpenses.Columns["Gastos"].DefaultCellStyle.Format = "C2";

            DataGridGains.DataSource = null;
            DataGridGains.DataSource = serviceManager.ListGainsForService();
            DataGridGains.ClearSelection();
            DataGridGains.Columns["Precio"].DefaultCellStyle.Format = "C2";
            DataGridGains.Columns["Comision"].DefaultCellStyle.Format = "C2";
            DataGridGains.Columns["Neto"].DefaultCellStyle.Format = "C2";

            LblSupplyExpenses.Text = $"$ {supplyManager.SupplyExpenses()}";
        }

        //Events
        //Reset
        private void ImgHome_Click(object sender, EventArgs e)
        {
            currentChildForm?.Close();
            Reset();
        }

        //Menu Button_Click
        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FormCustomers());
        }
        private void BtnServices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormServices());
        }
        private void BtnTickets_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FormTickets());
        }
        private void BtnShifts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new FormShift());
        }
        private void BtnSupplies_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new FormSupplies());
        }
        //SesionClose
        private void CloseSession()
        {
            inactivityTimer.Stop();
            FormLogin.Instance.CloseSession(this);
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro deseas cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            } 
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close-Maximize-Minimize
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro deseas salir de la aplicacion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) Application.Exit();
        }
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            TimerClock.Interval = 1000;
            TimerClock.Start();

            DataGridExpenses.ClearSelection();
            DataGridExpenses.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            DataGridExpenses.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            DataGridExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridExpenses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;


            DataGridGains.ClearSelection();
            DataGridGains.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            DataGridGains.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            DataGridGains.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DataGridGains.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            LblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        //Service

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            uint idleTime = GetSystemIdleTime();
            if (idleTime > InactivityTimeout && !inactivityMessageSent )
            {
                CloseSession();
                inactivityMessageSent = true;
            }
            else if (idleTime <= InactivityTimeout)
            {
                inactivityMessageSent = false;
            }
        }
        private uint GetSystemIdleTime()
        {
            LASTINPUTINFO inputInfo = new LASTINPUTINFO
            {
                cbSize = (uint)Marshal.SizeOf(typeof(LASTINPUTINFO))
            };

            if (GetLastInputInfo(ref inputInfo))
            {
                uint currentTickCount = (uint)Environment.TickCount;
                uint idleTime = currentTickCount - inputInfo.dwTime;

                if (currentTickCount < inputInfo.dwTime)
                {
                    idleTime = (uint.MaxValue - inputInfo.dwTime) + currentTickCount;
                }

                return idleTime;
            }
            return 0;
        }

        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [StructLayout(LayoutKind.Sequential)]
        private struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }
    }
}
