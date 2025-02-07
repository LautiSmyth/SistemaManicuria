using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplyServiceBLL
    {
        private readonly SupplyServiceDAL mapper = new SupplyServiceDAL();

        public void AddSupplyService(BE.SupplyService supplyService)
        {
            int ar = mapper.AddSupplyService(supplyService);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el insumo");
            }
        }
        public void DeleteSupplyService(BE.SupplyService supplyService)
        {
            try
            {
                mapper.DeleteSupplyService(supplyService);
            }
            catch
            {
                throw new Exception("Error al quitar el insumo");
            }
        }
        public List<BE.SupplyService> ListSupplyService(BE.Service service)
        {
            try
            {
                return mapper.ListSupplyService(service);
            }
            catch
            {
                throw new Exception("Error al cargar la lista de insumos");
            }
        }

    }
}
