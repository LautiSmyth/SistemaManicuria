using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ServiceDAL
    {
        private readonly Access access = new Access();

        public int AddService(Service service)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdServicio", service.IdService),
                new SqlParameter("@Descripcion",service.Description),
                new SqlParameter("@Horas",service.Hours),
                new SqlParameter("@PrecioLabor",service.LaborPrice),
                new SqlParameter("@PrecioServicio",service.ServicePrice),
                new SqlParameter("@PorcentajeComision",service.PctCommission),
                new SqlParameter("@Comision",service.Commission),
            };
            return access.Writer("AltaServicio", sp);
        }

        public void BackUpService(string archive)
        {
            access.BackUpXML("ListarServicio", null, archive);
        }
        public void BackUpService(string query,string archive)
        {
            access.BackUpXML(query, null, archive);
        }

        public void DeleteService(Service service)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdServicio", service.IdService),
            };
            access.Writer("BajaServicio", sp);
        }

        public int IdService()
        {
            string data = access.ReadData("IdServicio", null);
            if (string.IsNullOrEmpty(data))
                return 0;
            else return int.Parse(data);
        }

        public DataTable ListExpensesForService()
        {
            return access.Read("GastosPorServicio", null, "GastosPorServicio");
        }

        public object ListGainsForService()
        {
            return access.Read("GananciaPorServicio", null, "GananciaPorServicio");
        }

        public List<Service> ListService()
        {
            List<Service> list = new List<Service>();
            DataTable dt = access.Read("ListarServicio", null,"Servicios");
            foreach (DataRow dr in dt.Rows)
            {
                Service service = new Service()
                {
                    IdService = int.Parse(dr["IdServicio"].ToString()),
                    Description = dr["Descripcion"].ToString(),
                    Hours = decimal.Parse(dr["Horas"].ToString()),
                    LaborPrice = decimal.Parse(dr["PrecioLabor"].ToString()),
                    ServicePrice = decimal.Parse(dr["PrecioServicio"].ToString()),
                    PctCommission = decimal.Parse(dr["PorcentajeComision"].ToString()),
                    Commission = decimal.Parse(dr["Comision"].ToString())
                };
                list.Add(service);
            }
            return list;
        }

        public int UpdateService(Service service)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdServicio", service.IdService),
                new SqlParameter("@Descripcion",service.Description),
                new SqlParameter("@Horas",service.Hours),
                new SqlParameter("@PrecioLabor",service.LaborPrice),
                new SqlParameter("@PrecioServicio",service.ServicePrice),
                new SqlParameter("@PorcentajeComision",service.PctCommission),
                new SqlParameter("@Comision",service.Commission),
            };
            return access.Writer("ModificacionServicio", sp);
        }
    }
}
