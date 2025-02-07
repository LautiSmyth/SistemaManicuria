using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class FormServices : Form
    {
        private readonly BLL.ServiceBLL serviceManager = new BLL.ServiceBLL();
        private readonly BLL.SupplyBLL supplyManager = new BLL.SupplyBLL();
        private readonly BLL.SupplyServiceBLL supplyServiceManager = new BLL.SupplyServiceBLL();

        List<Service> services = new List<Service>();
        List<Supply> supplies = new List<Supply>();
        List<SupplyService> suppliesSavedList = new List<SupplyService>();

        public FormServices()
        {
            InitializeComponent();
            LoadData();
            UpdateDataGrid();            
        }

        //Methods
        private void LoadData()
        {
            try
            {
                supplies = supplyManager.ListSupply();
                DataGridSupplies.DataSource = null;
                DataGridSupplies.DataSource = supplies;
                DataGridSupplies.Columns["SupplyPrice"].DefaultCellStyle.Format = "C2";
                DataGridSupplies.Columns["CustomerPrice"].DefaultCellStyle.Format = "C2";
                foreach (DataGridViewColumn column in DataGridSupplies.Columns)
                {
                    column.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void UpdateDataGridSource()
        {
            services = serviceManager.ListService();
            DataGridServices.DataSource = null;
            DataGridServices.DataSource = services;
            DataGridServices.Columns["IdService"].ReadOnly = true;
            DataGridServices.Columns["ServicePrice"].ReadOnly = true;
            DataGridServices.Columns["Commission"].ReadOnly = true;

            DataGridServices.Columns["LaborPrice"].DefaultCellStyle.Format = "C2";
            DataGridServices.Columns["ServicePrice"].DefaultCellStyle.Format = "C2";
            DataGridServices.Columns["Commission"].DefaultCellStyle.Format = "C2";
        }
        void InitializeSuppliesGrid()
        {
            Service service = DataGridServices.SelectedRows[0].DataBoundItem as Service;
            UpdateSuppliedGrid(service);
        }
        void UpdateSuppliedGrid(Service service)
        {
            suppliesSavedList = supplyServiceManager.ListSupplyService(service);
            DataGridSupplies.CellValueChanged -= DataGridSupplies_CellValueChanged;
            foreach (DataGridViewRow row in DataGridSupplies.Rows)
            {
                var rowSupplyId = Convert.ToInt32(row.Cells["IdSupply"].Value);

                bool existsInList = suppliesSavedList.Any(supply => supply.IdSupply == rowSupplyId);

                row.Cells["Agregar"].Value = existsInList;
            }
            DataGridSupplies.CellValueChanged += DataGridSupplies_CellValueChanged;
        }
        private void ResetForm()
        {
            try
            {
                TxtHours.TxtText = "0,0";
                TxtService.TxtText = string.Empty;
                TxtLaborPrice.TxtText = "0,0";
                TxtServicePrice.TxtText = "0,0";
                TxtPctComission.TxtText = "0,0";
                UpdateDataGrid();
            }
            catch
            {
                MessageBox.Show("Error al reiniciar el formulario");
            }
        }
        public void UpdateDataGrid()
        {
            DataGridServices.CellValueChanged -= DataGridServices_CellValueChanged;
            DataGridSupplies.CellValueChanged -= DataGridSupplies_CellValueChanged;
            UpdateDataGridSource();
            DataGridServices.EditMode = DataGridViewEditMode.EditOnEnter;

            if (DataGridServices.DataSource != null)
            {
                AddColumnButton("Eliminar", "Eliminar", "Eliminar");
                AddColumnButton("Editar", "Editar", "Editar");
            }
            if(DataGridSupplies.DataSource != null && DataGridSupplies.Columns["Agregar"] == null)
            {
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn
                {
                    HeaderText = "Agregar",
                    Name = "Agregar",
                    DisplayIndex = 0,
                    ReadOnly = false
                };
                DataGridSupplies.Columns.Add(checkColumn);
            }
            DataGridServices.CellValueChanged += DataGridServices_CellValueChanged;
            DataGridSupplies.CellValueChanged += DataGridSupplies_CellValueChanged;
        }

        private void AddColumnButton(string name, string text, string header)
        {
            if (DataGridServices.Columns[name] == null)
            {
                DataGridViewButtonColumn columnButton = new DataGridViewButtonColumn
                {
                    Name = name,
                    Text = text,
                    HeaderText = header,
                    UseColumnTextForButtonValue = true
                };
                DataGridServices.Columns.Insert(0, columnButton);
            }
        }

        private void Update(Service service)
        {
            if (service != null)
            {
                if (service.Description != "" && service.ServicePrice >= 0)
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea modificar este servicio?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            serviceManager.UpdateService(service);
                            ResetForm();
                            MessageBox.Show("Servicio Modificado");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else MessageBox.Show("Debe ingresar un nombre y precio valido");
            }
        }

        private void Delete(Service service)
        {
            if (service != null)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este servicio?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        serviceManager.DeleteService(service);
                        MessageBox.Show("Servicio eliminado.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        //Events
        //Form
        private void FormServices_Load(object sender, EventArgs e)
        {
            InitializeSuppliesGrid();
        }
        //BtnAdd
        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (TxtService.TxtText != "" && !LblVService.Visible && decimal.Parse(TxtServicePrice.TxtText) >= 0)
            {
                try
                {
                    Service service = new Service()
                    {                        
                        Description = TxtService.TxtText,
                        Hours = decimal.Parse(TxtHours.TxtText),
                        LaborPrice = decimal.Parse(TxtLaborPrice.TxtText),
                        ServicePrice = decimal.Parse(TxtServicePrice.TxtText),
                        PctCommission = decimal.Parse(TxtPctComission.TxtText),
                        Commission = decimal.Parse(TxtComission.TxtText),
                    };
                    int ar = serviceManager.AddService(service);
                    UpdateDataGridSource();
                    ResetForm();
                    MessageBox.Show(ar + " Servicio Agregado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Debe ingresar un nombre y precio valido");
        }
        //DataGrid
        private void DataGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = sender as DataGridView;
            DataGridViewCell selectedCell = dataGrid.SelectedCells[0];
            if (selectedCell.RowIndex > -1 && selectedCell.ColumnIndex > -1)
            {
                if (dataGrid.IsCurrentCellDirty)
                {
                    dataGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }
        //DataGridServices
        private void DataGridServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            try
            {
                Service service = DataGridServices.Rows[e.RowIndex].DataBoundItem as Service;
                if (e.ColumnIndex == DataGridServices.Columns["Eliminar"].Index)
                {
                    Delete(service);
                    UpdateDataGrid();
                    return;
                }
                if (e.ColumnIndex == DataGridServices.Columns["Editar"].Index)
                {
                    Update(service);
                    UpdateDataGrid();
                    return;
                }
                if (service != null)
                {
                    UpdateSuppliedGrid(service);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridServices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridServices.Rows[e.RowIndex];

                int colHours = DataGridServices.Columns["Hours"].Index;
                int colLaborPrice = DataGridServices.Columns["LaborPrice"].Index;
                int colServicePrice = DataGridServices.Columns["ServicePrice"].Index;
                int colPctCommission = DataGridServices.Columns["PctCommission"].Index;
                int colCommission = DataGridServices.Columns["Commission"].Index;

                decimal hours = Convert.ToDecimal(row.Cells[colHours].Value ?? 0);
                decimal laborPrice = Convert.ToDecimal(row.Cells[colLaborPrice].Value ?? 0);
                decimal pctCommission = Convert.ToDecimal(row.Cells[colPctCommission].Value ?? 0);

                decimal servicePrice = serviceManager.CalculateServicePrice(hours, laborPrice);
                row.Cells[colServicePrice].Value = servicePrice;

                row.Cells[colCommission].Value = serviceManager.CalculateComission(servicePrice, pctCommission);
            }
        }
        //DataGridSupplies
        private void DataGridSupplies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (DataGridSupplies.Columns[e.ColumnIndex].Name == "Agregar")
                {
                    if (!(DataGridSupplies.Rows[e.RowIndex].DataBoundItem is Supply supply)) return;

                    bool isAddSelected = Convert.ToBoolean(DataGridSupplies.Rows[e.RowIndex].Cells["Agregar"].Value);

                    if (e.ColumnIndex == DataGridSupplies.Columns["Agregar"].Index)
                    {
                        if (DataGridServices.SelectedRows.Count > 0)
                        {
                            if (!(DataGridServices.SelectedRows[0].DataBoundItem is Service service)) return;
                            SupplyService supplyService = new SupplyService
                            {
                                IdService = service.IdService,
                                IdSupply = supply.IdSupply,
                            };

                            if (isAddSelected)
                                supplyServiceManager.AddSupplyService(supplyService);
                            else
                                supplyServiceManager.DeleteSupplyService(supplyService);
                        }
                        else
                            MessageBox.Show("Debe seleccionar un servicio antes de agregar un insumo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //TxtNumbers
        private void TxtCalculations_TextChangedControl(object sender, EventArgs e)
        {
            if (TxtHours.TxtText != "" && TxtLaborPrice.TxtText != "")
            {
                TxtServicePrice.TxtText = serviceManager.CalculateServicePrice(decimal.Parse(TxtHours.TxtText),decimal.Parse(TxtLaborPrice.TxtText)).ToString();
                if (TxtPctComission.TxtText != "")
                {
                    TxtComission.TxtText = serviceManager.CalculateComission(decimal.Parse(TxtServicePrice.TxtText),decimal.Parse(TxtPctComission.TxtText)).ToString();
                }
            }
        }
        //TxtSearch
        private void TxtSearch_TextChangedControl(object sender, EventArgs e)
        {
            string searchText = TxtSearch.TxtText;
            var filterSupplies = supplies.Where(supply => supply.Product.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();
            DataGridSupplies.DataSource = new BindingList<Supply>(filterSupplies);
            InitializeSuppliesGrid();
        }
        //TxtService
        private void TxtService_TextChangedControl(object sender, EventArgs e)
        {
            LblVService.Visible = true;
            if (services.Any(service => service.Description.Equals(TxtService.TxtText, StringComparison.OrdinalIgnoreCase)))
            {
                LblVService.Text = "*El nombre ya esta ocupado";
                LblVService.ForeColor = Color.Red;
            }
            else if (TxtService.TxtText == "")
            {
                LblVService.Text = "*Campo vacio";
                LblVService.ForeColor = Color.Red;
            }
            else
            {
                LblVService.Visible = false;
            }
        }
    }
}
