using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTickets : Form
    {
        private readonly BLL.TicketBLL ticketManager = new BLL.TicketBLL();
        private readonly BLL.ShiftBLL shiftManager = new BLL.ShiftBLL();
        private readonly BLL.CustomerBLL customerManager = new BLL.CustomerBLL();
        private readonly BLL.ServiceBLL serviceManager = new BLL.ServiceBLL();
        private readonly BLL.DetailBLL detailManager = new BLL.DetailBLL();

        private List<Ticket> tickets = new List<Ticket>();
        private List<Customer> customers = new List<Customer>();
        private List<Shift> shifts = new List<Shift>();
        private List<Service> services = new List<Service>();
        private List<Detail> details = new List<Detail>();

        private Customer selectedCustomer;
        private Shift selectedShift;
        private bool servicesSaved = true;

        public FormTickets()
        {
            InitializeComponent();
            LoadData();
            ConfigureComboBox();
            UpdateDataGridSource();
            DateTimeRegister.Value = DateTime.Now;
        }

        //Methods
        private void LoadData()
        {
            try
            {
                customers = customerManager.ListCustomer();
                shifts = shiftManager.ListShift().Where(s => !s.Finalized).ToList();
                services = serviceManager.ListService();
            }
            catch (Exception ex)
            {
                ShowError("Error al cargar los datos", ex);     
            }
        }
        void ConfigureComboBox()
        {
            try
            {
                CbCustomer.SelectedIndexChanged -= CbCustomer_SelectedIndexChanged;
                CbCustomer.DataSource = customers.Where(c => shifts.Any(s => s.IdCustomer == c.IdCustomer)).ToList();
                CbCustomer.DisplayMember = "Name";
                CbCustomer.SelectedItem = null;
                CbCustomer.SelectedIndexChanged += CbCustomer_SelectedIndexChanged;

                CbShift.DisplayMember = "DateShift";
                CbShift.SelectedItem = null;
            }
            catch (Exception ex)
            {
                ShowError("Error al configurar los combos", ex);
            }
        }
        private void UpdateDataGridSource()
        {
            try
            {
                if (DataGridTickets.Columns.Contains("Agregar"))
                    DataGridTickets.Columns.Remove("Agregar");
                tickets = ticketManager.ListTicket();
                DataGridTickets.DataSource = null;
                DataGridTickets.DataSource = tickets;
                DataGridTickets.Columns["Total"].DefaultCellStyle.Format = "C2";
                ConfigureGridColumns();
            }
            catch (Exception ex)
            {
                ShowError("Error al actualizar la grilla de tickets", ex);
            }
        }
        private void ConfigureGridColumns()
        {
            foreach (DataGridViewColumn column in DataGridTickets.Columns)
            {
                column.ReadOnly = true;
            }
        }
        private void ResetForm()
        {
            try
            {
                LoadData();
                ConfigureComboBox();
                TxtHour.Text = "0000";
                TxtDescription.Clear();
                TxtServiceCost.Text = "0,0";
                TxtTotal.Text = "0,0";
                TxtExtra.TxtText = "0,0";
                DateTimeRegister.Value = DateTime.Now;
                UpdateDataGridSource();
                CbShift.DataSource = null;

                selectedCustomer = null;
                selectedShift = null;
                details.Clear();
                servicesSaved = true;
            }
            catch (Exception ex)
            {
                ShowError("Error al reiniciar el formulario", ex);
            }
        }
        private void SaveSelectedServices()
        {
            try
            {
                details = DataGridTickets.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => Convert.ToBoolean(row.Cells["Agregar"].Value))
                    .Select(row => new Detail
                    {
                        IdService = Convert.ToInt32(row.Cells["IdService"].Value),
                        Service = row.Cells["Description"].Value.ToString(),
                        Hours = Convert.ToDecimal(row.Cells["Hours"].Value),
                        Price = Convert.ToDecimal(row.Cells["LaborPrice"].Value),
                        SubTotal = Convert.ToDecimal(row.Cells["ServicePrice"].Value)
                    }).ToList();

                TxtDescription.Text = string.Join(", ", details.Select(d => d.Service));
                TxtServiceCost.Text = details.Sum(d => d.SubTotal).ToString("F2");
                servicesSaved = true;
            }
            catch (Exception ex)
            {
                ShowError("Error al guardar los servicios seleccionados", ex);
            }
        }

        Ticket GetSelectedTicket()
        {
            if (DataGridTickets.SelectedRows.Count > 0)
            {
                return DataGridTickets.SelectedRows[0].DataBoundItem as Ticket;
            }

            MessageBox.Show("Debe seleccionar una factura.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
        private void ConfigureServicesGrid()
        {
            DataGridTickets.DataSource = null;
            DataGridTickets.DataSource = services;
            ConfigureGridColumns();
            DataGridTickets.Columns["IdService"].Visible = false;

            if (!DataGridTickets.Columns.Contains("Agregar"))
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Agregar",
                    Name = "Agregar",
                    DisplayIndex = 0,
                    ReadOnly = false
                };
                DataGridTickets.Columns.Add(checkColumn);
            }
            foreach (DataGridViewRow row in DataGridTickets.Rows)
            {
                int rowServiceId = Convert.ToInt32(row.Cells["IdService"].Value);
                if (rowServiceId == selectedShift.IdService || details.Any(detail => rowServiceId == detail.IdService))
                {
                    row.Cells["Agregar"].Value = true;
                }
            }
        }

        private void ShowError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null || selectedShift == null || decimal.Parse(TxtTotal.Text) < 0)
            {
                MessageBox.Show("Debe seleccionar un cliente y completar validamente los campos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!servicesSaved)
            {
                DialogResult result = MessageBox.Show("Los servicios no se guardaron. ¿Desea guardarlos?", "Guardar cambios",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveSelectedServices();
                    UpdateDataGridSource();
                }
                else if (result == DialogResult.No)
                { 
                    UpdateDataGridSource();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            try
            {
                Ticket ticket = new Ticket()
                {
                    IdCustomer = selectedCustomer.IdCustomer,
                    Description = TxtDescription.Text,
                    Total = Decimal.Parse(TxtTotal.Text),
                    DateTicket = DateTimeRegister.Value.ToString("dd/MM/yyyy HH:mm")
                };

                ticketManager.AddTicket(ticket);
                selectedShift.Finalized = true;
                shiftManager.UpdateShift(selectedShift);


                int servicesCount = detailManager.AddDetail(ticket.IdTicket, details);
                MessageBox.Show($"Factura registrada exitosamente con {servicesCount} servicio(s).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetSelectedTicket();
            if (ticket != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta factura?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ticketManager.DeleteTicket(ticket);
                        UpdateDataGridSource();
                        MessageBox.Show("Factura eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        ShowError("Error al eliminar el ticket", ex);
                    }
                }
            }
        }

        private void CbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbCustomer.SelectedItem == null)
            {
                CbShift.DataSource = null;
                return;
            }
            selectedCustomer = CbCustomer.SelectedItem as Customer;
            List<Shift> shiftcustomer = shifts.Where(s => s.IdCustomer == selectedCustomer.IdCustomer).ToList(); ;

            if (shiftcustomer.Count > 0)
            {
                CbShift.DataSource = shiftcustomer;
                CbShift.DisplayMember = "DateShift";
            }
            else
            {
                CbShift.DataSource = null;
            }
        }
        private void CbShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbShift.SelectedItem == null)
            {
                TxtHour.Text = "";
                TxtDescription.Text = "";
                TxtServiceCost.Text = "";
                return;
            }

            selectedShift = CbShift.SelectedItem as Shift;

            if (selectedShift != null)
            {
                TxtHour.Text = selectedShift.HourShift.ToString();
                TxtDescription.Text = selectedShift.Service.ToString();
                TxtServiceCost.Text = services.FirstOrDefault(s => s.IdService == selectedShift.IdService)?.ServicePrice.ToString();
            }
        }

        private void CaculateTotal_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(TxtExtra.TxtText, out decimal extra) &&
                decimal.TryParse(TxtServiceCost.Text, out decimal serviceCost))
            {
                TxtTotal.Text = ticketManager.CalculateTotal(extra, serviceCost).ToString("F2");
            }
            else
            {
                TxtTotal.Text = "0";
            }
        }

        private void BtnSeeServices_Click(object sender, EventArgs e)
        {
            if(CbShift.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un turno");
                return;
            }
            else if (DataGridTickets.DataSource == tickets && CbShift.SelectedItem != null)
            {
                servicesSaved = false;
                ConfigureServicesGrid();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Deseas guardar los cambios?", "Guardar Cambios",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveSelectedServices();
                    UpdateDataGridSource();
                }
                else if (result == DialogResult.No)
                {
                    UpdateDataGridSource();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }
    }
}

