using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplyServiceDAL
    {
        private readonly Access access = new Access();
        public int AddSupplyService(SupplyService supplyService)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdServicio", supplyService.IdService),
                new SqlParameter("@IdInsumo",supplyService.IdSupply),
            };
            return access.Writer("AltaInsumoServicio", sp);
        }

        public void DeleteSupplyService(SupplyService supplyService)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdServicio", supplyService.IdService),
                new SqlParameter("@IdInsumo", supplyService.IdSupply)
            };
            access.Writer("BajaInsumoServicio", sp);
        }

        public List<SupplyService> ListSupplyService(Service service)
        {
            List<SupplyService> list = new List<SupplyService>();
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdServicio", service.IdService),
            };
            DataTable dt = access.Read("ListarInsumoServicio", sp);
            foreach (DataRow dr in dt.Rows)
            {
                SupplyService customer = new SupplyService()
                {
                    IdService = int.Parse(dr["IdServicio"].ToString()),
                    IdSupply = int.Parse(dr["IdInsumo"].ToString())
                };
                list.Add(customer);
            }
            return list;
        }
    }
}
