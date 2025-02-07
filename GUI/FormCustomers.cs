using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormCustomers : Form
    {
        private readonly BLL.CustomerBLL ticketManager = new BLL.CustomerBLL();
        List<BE.Customer> customers = new List<BE.Customer>();

        public FormCustomers()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void ResetForm()
        {
            TxtName.Text = string.Empty;
            TxtPhone.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            PanelVEmail.Visible = false;
            PanelVPhone.Visible = false;
        }

        void UpdateDataGridSource()
        {
            customers = ticketManager.ListCustomer();
            DataGridCustomers.DataSource = null;
            DataGridCustomers.DataSource = customers;
            DataGridCustomers.Columns["IdCustomer"].ReadOnly = true;
            DataGridCustomers.Columns["DateRegister"].ReadOnly = true;
        }

        public void UpdateDataGrid()
        {
            UpdateDataGridSource();
            DataGridCustomers.EditMode = DataGridViewEditMode.EditOnEnter;

            if (DataGridCustomers.DataSource != null)
            {
                AddColumnButton("Eliminar", "Eliminar", "Eliminar");
                AddColumnButton("Editar", "Editar", "Editar");
            }
        }

        private void AddColumnButton(string name, string text, string header)
        {
            if (DataGridCustomers.Columns[name] == null)
            {
                DataGridViewButtonColumn columnButton = new DataGridViewButtonColumn
                {
                    Name = name,
                    Text = text,
                    HeaderText = header,
                    UseColumnTextForButtonValue = true
                };
                DataGridCustomers.Columns.Insert(0, columnButton);
            }
        }
        private void Update(BE.Customer customer)
        {
            try
            {
                ticketManager.UpdateCustomer(customer);
                ResetForm();
                MessageBox.Show("Cliente Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete(BE.Customer customer)
        {
            try
            {
                ticketManager.DeleteCustomer(customer);
                MessageBox.Show("Cliente Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "" && !LblVName.Visible && (TxtPhone.Text != "" || TxtEmail.Text != ""))
            {
                try
                {
                    BE.Customer customer = new BE.Customer()
                    {
                        Name = TxtName.Text,
                        Phone = Regex.Replace(TxtPhone.Text, @"[^\d]", ""),
                        Email = TxtEmail.Text,
                        Address = TxtAddress.Text,
                        DateRegister = DateTimeRegister.Value.ToString("dd/MM/yyyy"),
                    };
                    int ar = ticketManager.AddCustomer(customer);
                    UpdateDataGridSource();
                    ResetForm();
                    MessageBox.Show(ar + " Cliente Agregado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Debe ingresar un nombre valido y al menos una red de contacto");
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            LblVName.Visible = true;
            if (customers.Any(customer => customer.Name.Equals(TxtName.Text, StringComparison.OrdinalIgnoreCase)))
            {
                LblVName.Text = "*El nombre ya esta ocupado";
                LblVName.ForeColor = Color.Red;
            }
            else if (TxtName.Text == "")
            {
                LblVName.Text = "*Campo vacio";
                LblVName.ForeColor = Color.Red;
            }
            else
            {
                LblVName.Visible = false;
            }
        }
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            PanelVEmail.Visible = true;
            PanelVEmail.BarraValidacion(TxtEmail.Text, ticketManager.ValidateEmail(TxtEmail.Text));
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            string numero = Regex.Replace(TxtPhone.Text, @"[^\d]", "");
            PanelVPhone.Visible = true;
            PanelVPhone.BarraValidacion(TxtPhone.Text, ticketManager.ValidatePhone(numero));
        }

        private void DataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            BE.Customer customer = DataGridCustomers.Rows[e.RowIndex].DataBoundItem as BE.Customer;
            if (e.ColumnIndex == DataGridCustomers.Columns["Eliminar"].Index)
            {
                Delete(customer);
                UpdateDataGrid();
            }
            if (e.ColumnIndex == DataGridCustomers.Columns["Editar"].Index)
            {
                Update(customer);
                UpdateDataGrid();
            }
        }
    }
}
