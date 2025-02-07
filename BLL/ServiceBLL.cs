using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class ServiceBLL
    {
        private readonly ServiceDAL mapper = new ServiceDAL();

        public int AddService(BE.Service service)
        {
            service.IdService = mapper.IdService() + 1;
            int ar = mapper.AddService(service);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el servicio");
            }
            else
            {
                BackUpService("Servicios");
                mapper.BackUpService("GastosPorServicio", "GastosPorServicio");
                mapper.BackUpService("GananciaPorServicio","GananciaPorServicio");
            }
            return ar;
        }

        public void DeleteService(BE.Service service)
        {
            try
            {
                mapper.DeleteService(service);
                BackUpService("Servicios");
                mapper.BackUpService("GastosPorServicio", "GastosPorServicio");
                mapper.BackUpService("GananciaPorServicio", "GananciaPorServicio");
            }
            catch
            {
                throw new Exception("Error al eliminar el servicio");
            }
        }

        public List<BE.Service> ListService()
        {
            try
            {
                return mapper.ListService();
            }
            catch
            {
                throw new Exception("Error al cargar los servicios");
            }
        }

        public int UpdateService(BE.Service service)
        {
            int ar = mapper.UpdateService(service);
            if (ar == -1)
            {
                throw new Exception("Error al modificar el servicio");
            }
            else
            {
                BackUpService("Servicios");
                mapper.BackUpService("GastosPorServicio", "GastosPorServicio");
                mapper.BackUpService("GananciaPorServicio", "GananciaPorServicio");
            }
            return ar;
        }

        public void BackUpService(string archive)
        {
            mapper.BackUpService(archive);
        }

        public decimal CalculateServicePrice(decimal hours, decimal price)
        {
            return Math.Round(hours * price,2);
        }

        public decimal CalculateComission(decimal price, decimal pct)
        {
            return Math.Round(price * pct / 100,2);
        }

        public DataTable ListExpensesForService()
        {
            try
            {
                return mapper.ListExpensesForService();
            }
            catch
            {
                throw new Exception("Error al cargar la tabla de gastos");
            }
        }

        public object ListGainsForService()
        {
            try
            {
                return mapper.ListGainsForService();
            }
            catch
            {
                throw new Exception("Error al cargar la tabla de gastos");
            }
        }
    }
}
