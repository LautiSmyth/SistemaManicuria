using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplyBLL
    {
        private readonly SupplyDAL mapper = new SupplyDAL();
        public int AddSupply(BE.Supply supply)
        {
            supply.IdSupply = mapper.IdSupply() + 1;
            int ar = mapper.AddSupply(supply);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el insumo");
            }
            else
                BackUpSupply("Insumos");
            return ar;
        }
        public int UpdateSupply(BE.Supply supply)
        {
            int ar = mapper.UpdateSupply(supply);
            if (ar == -1)
            {
                throw new Exception("Error al modificar el insumo");
            }
            else 
                BackUpSupply("Insumos");
            return ar;
        }

        public void DeleteSupply(BE.Supply supply)
        {
            try
            {
                mapper.DeleteSupply(supply);
                BackUpSupply("Insumos");
            }
            catch
            {
                throw new Exception("Error al eliminar el insumo");
            }
        }

        public decimal CalculateCustomerPrice(decimal supplyPrice, decimal yield)
        {
            return Math.Round(supplyPrice / yield,2);
        }

        public List<BE.Supply> ListSupply()
        {
            try
            {
                return mapper.ListSupply();
            }
            catch
            {
                throw new Exception("Error al cargar los insumos");
            }
        }

        public void BackUpSupply(string archive)
        {
            mapper.BackUpSupply(archive);
        }

        public string SupplyExpenses()
        {
            return mapper.SupplyExpenses();
        }
    }
}
