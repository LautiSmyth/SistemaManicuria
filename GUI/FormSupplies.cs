using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSupplies : Form
    {
        readonly BLL.SupplyBLL supplyManager = new BLL.SupplyBLL();
        List<BE.Supply> supplies = new List<BE.Supply>();
        public FormSupplies()
        {
            InitializeComponent();
            UpdateDataGrid();
        }
        //Methods
        void UpdateDataGridSource()
        {
            supplies = supplyManager.ListSupply();
            DataGridSupplies.DataSource = null;
            DataGridSupplies.DataSource = supplies;
            DataGridSupplies.Columns["idSupply"].ReadOnly = true;
            DataGridSupplies.Columns["customerPrice"].ReadOnly = true;
            DataGridSupplies.Columns["SupplyPrice"].DefaultCellStyle.Format = "C2";
            DataGridSupplies.Columns["CustomerPrice"].DefaultCellStyle.Format = "C2";
        }
        private void ResetControls(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
                if (ctrl is PanelValidationBar panel_BarValidacion)
                {
                    panel_BarValidacion.Visible = false;
                }
            }
        }
        public void UpdateDataGrid()
        {
            UpdateDataGridSource();
            DataGridSupplies.EditMode = DataGridViewEditMode.EditOnEnter;
            if (DataGridSupplies.DataSource != null)
            {
                AddColumnButton("Eliminar", "Eliminar", "Eliminar");
                AddColumnButton("Editar", "Editar", "Editar");
            }
        }
        private void AddColumnButton(string name, string text, string header)
        {
            if (DataGridSupplies.Columns[name] == null)
            {
                DataGridViewButtonColumn columnButton = new DataGridViewButtonColumn
                {
                    Name = name,
                    Text = text,
                    HeaderText = header,
                    UseColumnTextForButtonValue = true
                };
                DataGridSupplies.Columns.Insert(0, columnButton);
            }
        }
        private void Update(BE.Supply supply)
        {
            try
            {
                supplyManager.UpdateSupply(supply);
                UpdateDataGridSource();
                ResetControls(this);
                MessageBox.Show("Insumo Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete(BE.Supply supply)
        {
            try
            {
                supplyManager.DeleteSupply(supply);
                UpdateDataGridSource();
                MessageBox.Show("Insumo Eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Events
        //Button Add
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtProducto.Text != "" && !LblVName.Visible && (TxtSupplyPrice.TxtText != "" || TxtYield.TxtText != ""))
            {
                try
                {
                    BE.Supply supply = new BE.Supply()
                    {
                        Product = TxtProducto.Text,
                        SupplyPrice = decimal.Parse(TxtSupplyPrice.TxtText),
                        Yield = decimal.Parse(TxtYield.TxtText),
                        CustomerPrice = supplyManager.CalculateCustomerPrice(decimal.Parse(TxtSupplyPrice.TxtText), decimal.Parse(TxtYield.TxtText)),
                    };
                    int ar = supplyManager.AddSupply(supply);
                    UpdateDataGridSource();
                    ResetControls(this);
                    MessageBox.Show(ar + " Insumo Agregado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Debe ingresar un nombre valida y al menos una red de contacto");
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
        //DataGridSupplies
        private void DataGridSupplies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            try
            {
                Supply supply = DataGridSupplies.Rows[e.RowIndex].DataBoundItem as Supply;
                if (e.ColumnIndex == DataGridSupplies.Columns["Eliminar"].Index)
                {
                    Delete(supply);
                    UpdateDataGrid();
                    return;
                }
                if (e.ColumnIndex == DataGridSupplies.Columns["Editar"].Index)
                {
                    Update(supply);
                    UpdateDataGrid();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridSupplies_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridSupplies.Rows[e.RowIndex];

                int colSupplyPrice = DataGridSupplies.Columns["SupplyPrice"].Index;
                int colYield = DataGridSupplies.Columns["Yield"].Index;
                int colCustomerPrice = DataGridSupplies.Columns["CustomerPrice"].Index;

                decimal supplyPrice = Convert.ToDecimal(row.Cells[colSupplyPrice].Value ?? 0);
                decimal yield = Convert.ToDecimal(row.Cells[colYield].Value ?? 0);
                if (yield > 0)
                {
                    decimal customerPrice = supplyManager.CalculateCustomerPrice(supplyPrice, yield);
                    row.Cells[colCustomerPrice].Value = customerPrice;
                }
            }
        }
        //TxtName
        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            LblVName.Visible = true;
            if (supplies.Any(supply => supply.Product.Equals(TxtProducto.Text, StringComparison.OrdinalIgnoreCase)))
            {
                LblVName.Text = "*El nombre ya esta ocupado";
                LblVName.ForeColor = Color.Red;
            }
            else if (TxtProducto.Text == "")
            {
                LblVName.Text = "*Campo vacio";
                LblVName.ForeColor = Color.Red;
            }
            else
            {
                LblVName.Visible = false;
            }
        }
        //TxtNumers
        private void TxtCalculateCustomPrice_TextChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(TxtYield.TxtText) > 0 && decimal.Parse(TxtSupplyPrice.TxtText) > 0)
            {
                TxtCustomPrice.TxtText = supplyManager.CalculateCustomerPrice(decimal.Parse(TxtSupplyPrice.TxtText), decimal.Parse(TxtYield.TxtText)).ToString();
            }
        }
    }
}
