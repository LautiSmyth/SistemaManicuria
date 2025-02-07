using BE;
using BLL;
using SHARED.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormShift : Form
    {
        private readonly ShiftBLL ticketManager = new BLL.ShiftBLL();

        List<BE.Shift> shifts = new List<BE.Shift>();

        private readonly DateTimePicker dateTimePicker = new DateTimePicker();
        private readonly MaskedTextBox maskedTextBox = new MaskedTextBox();

        private bool isDateColumn = false;
        private bool isHourColumn = false;

        public FormShift()
        {
            InitializeComponent();
            UpdateDataGrid();
            InitializeComboBox();
            InitializeDates();
            InitializeDateTimeColumnGrid();
            InitializeMaskHourColumnGrid();
        }

        //Methods
        void InitializeMaskHourColumnGrid()
        {
            maskedTextBox.Visible = false;
            maskedTextBox.Mask = "00:00";
            maskedTextBox.ValidatingType = typeof(DateTime);

            DataGridShifts.Controls.Add(maskedTextBox);
        }
        void InitializeDateTimeColumnGrid()
        {
            dateTimePicker.Visible = false;
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;

            DataGridShifts.Controls.Add(dateTimePicker);
        }
        void InitializeComboBox()
        {
            CustomerBLL customerManager = new CustomerBLL();
            ServiceBLL serviceManager = new ServiceBLL();
            CbCustomer.DataSource = customerManager.ListCustomer();
            CbCustomer.DisplayMember = "Name";
            CbCustomer.SelectedItem = null;
            CbService.DataSource = serviceManager.ListService();
            CbService.DisplayMember = "Description";
            CbService.SelectedItem = null;
            CbFilter.Items.AddRange(new string[] {"Todos","Finalizados","Por Finalizar"});
            CbFilter.SelectedIndex = 0;
        }
        void InitializeDates()
        {
            DateTimeDate.MinDate = DateTime.Now;
            DateTimeDate.Value = DateTime.Now;
            DateTimeRegister.Value = DateTime.Now;
        }
        void UpdateDataGridSource()
        {
            shifts = ticketManager.ListShift();
            DataGridShifts.DataSource = null;
            DataGridShifts.DataSource = shifts;
            DataGridShifts.Columns["IdShift"].ReadOnly = true;
            DataGridShifts.Columns["Customer"].ReadOnly = true;
            DataGridShifts.Columns["User"].ReadOnly = true;
            DataGridShifts.Columns["Service"].ReadOnly = true;
            DataGridShifts.Columns["Finalized"].ReadOnly = true;
            DataGridShifts.Columns["DateRegister"].ReadOnly = true;
        }
        public void UpdateDataGrid()
        {
            UpdateDataGridSource();
            DataGridShifts.EditMode = DataGridViewEditMode.EditOnEnter;
            if (DataGridShifts.DataSource != null)
            {
                AddColumnButton("Eliminar", "Eliminar", "Eliminar");
                AddColumnButton("Editar", "Editar", "Editar");
            }
        }
        private void AddColumnButton(string name, string text, string header)
        {
            if (DataGridShifts.Columns[name] == null)
            {
                DataGridViewButtonColumn columnButton = new DataGridViewButtonColumn
                {
                    Name = name,
                    Text = text,
                    HeaderText = header,
                    UseColumnTextForButtonValue = true
                };
                DataGridShifts.Columns.Insert(0, columnButton);
            }
        }
        private void ResetForm()
        {
            try
            {
                TxtHour.Text = "0000";
                InitializeDates();
                DateTimeRegister.Value = DateTime.Now;
                UpdateDataGridSource();
                CbCustomer.SelectedIndex = -1;
                CbService.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Error al reiniciar el formulario");
            }
        }
        private void Update(BE.Shift shift)
        {
            try
            {
                ticketManager.UpdateShift(shift);
                UpdateDataGridSource();
                MessageBox.Show("Turno(s) Modificado(s)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Delete(BE.Shift shift)
        {
            try
            {
                ticketManager.DeleteShift(shift);
                UpdateDataGridSource();
                MessageBox.Show("Turno Eliminado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ApplyFilters()
        {

            IEnumerable<Shift> filteredShifts = shifts.AsEnumerable();

            switch (CbFilter.Text)
            {
                case "Finalizado":
                    filteredShifts = filteredShifts.Where(shift => shift.Finalized == true);
                    break;
                case "Por Finalizar":
                    filteredShifts = filteredShifts.Where(shift => shift.Finalized == false);
                    break;
                case "Todos":
                    break;
                default:
                    break;
            }

            if (!string.IsNullOrEmpty(TxtSearch.TxtText))
            {
                string searchText = TxtSearch.TxtText;
                filteredShifts = filteredShifts.Where(shift => shift.Customer.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            DataGridShifts.DataSource = new BindingList<Shift>(filteredShifts.ToList());
        }
        //Events
        //BtnAdd
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbCustomer.SelectedItem == null || CbService.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un Cliente y un Servicio.");
                    return;
                }
                BE.Customer customer = (BE.Customer)CbCustomer.SelectedItem;
                BE.Service service = (BE.Service)CbService.SelectedItem;

                BE.Shift shift = new BE.Shift()
                {
                    IdCustomer = customer.IdCustomer,
                    IdService = service.IdService,
                    IdUser = UserLoginCache.IdUser,
                    DateShift = DateTimeDate.Value.ToString("dd/MM/yyyy"),
                    HourShift = DateTimeDate.Value.ToString("HH:mm"),
                    DateRegister = DateTimeRegister.Value.ToString("dd/MM/yyyy"),
                };
                int ar = ticketManager.AddShift(shift);
                UpdateDataGridSource();
                ResetForm();
                MessageBox.Show(ar + " Turno Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //DataGridShifts
        private void DataGridShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            try
            {
                Shift shift = DataGridShifts.Rows[e.RowIndex].DataBoundItem as Shift;
                if (e.ColumnIndex == DataGridShifts.Columns["Eliminar"].Index)
                {
                    Delete(shift);
                    UpdateDataGrid();
                    return;
                }
                if (e.ColumnIndex == DataGridShifts.Columns["Editar"].Index)
                {
                    Update(shift);
                    UpdateDataGrid();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridShifts_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (DataGridShifts.Columns[e.ColumnIndex].Name == "DateShift")
            {
                isDateColumn = true;
                Rectangle rect = DataGridShifts.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                dateTimePicker.Location = rect.Location;
                dateTimePicker.Size = rect.Size;
                dateTimePicker.Value = DateTime.TryParse(DataGridShifts[e.ColumnIndex, e.RowIndex].Value?.ToString(), out DateTime dateValue)
                    ? dateValue
                    : DateTime.Now;

                dateTimePicker.Visible = true;
            }
            else
            {
                isDateColumn = false;
                dateTimePicker.Visible = false;
            }
            if (DataGridShifts.Columns[e.ColumnIndex].Name == "HourShift")
            {
                isHourColumn = true;
                Rectangle rect = DataGridShifts.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                maskedTextBox.Location = rect.Location;
                maskedTextBox.Size = rect.Size;
                maskedTextBox.Text = DataGridShifts[e.ColumnIndex, e.RowIndex].Value?.ToString() ?? string.Empty;

                maskedTextBox.Visible = true;
                maskedTextBox.Focus();
            }
            else
            {
                isHourColumn = false;
                maskedTextBox.Visible = false;
            }
        }
        private void DataGridShifts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isDateColumn)
            {
                DataGridShifts[e.ColumnIndex, e.RowIndex].Value = dateTimePicker.Value.ToString("dd/MM/yyyy");
                dateTimePicker.Visible = false;
            }
            if (isHourColumn)
            {
                if (DateTime.TryParse(maskedTextBox.Text, out DateTime parsedTime))
                {
                    DataGridShifts[e.ColumnIndex, e.RowIndex].Value = parsedTime.ToString("HH:mm");
                }
                else
                {
                    MessageBox.Show("Hora inválida. Por favor, ingrese un valor válido en formato HH:mm.");
                }

                maskedTextBox.Visible = false;
            }
        }
        //DateTimePicker column datagrid
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (DataGridShifts.CurrentCell != null)
            {
                DataGridShifts.CurrentCell.Value = dateTimePicker.Value.ToString("dd/MM/yyyy");
            }
        }
        //TxtSearch
        private void TxtSearch_TextChangedControl(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void CbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

    }
}
