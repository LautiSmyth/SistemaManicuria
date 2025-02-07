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
    public class SupplyDAL
    {
        private readonly Access access = new Access();
        public int AddSupply(Supply supply)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdInsumo", supply.IdSupply),
                new SqlParameter("@Producto",supply.Product),
                new SqlParameter("@PrecioInsumo",supply.SupplyPrice),
                new SqlParameter("@Rendimiento",supply.Yield),
                new SqlParameter("@PrecioCliente",supply.CustomerPrice)
            };
            return access.Writer("AltaInsumo", sp);
        }

        public void DeleteSupply(Supply supply)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdInsumo", supply.IdSupply),
            };
            access.Writer("BajaInsumo", sp);
        }
        public int UpdateSupply(Supply supply)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdInsumo", supply.IdSupply),
                new SqlParameter("@Producto",supply.Product),
                new SqlParameter("@PrecioInsumo",supply.SupplyPrice),
                new SqlParameter("@Rendimiento",supply.Yield),
                new SqlParameter("@PrecioCliente",supply.CustomerPrice)
            };
            return access.Writer("ModificacionInsumo", sp);
        }

        public int IdSupply()
        {
            string data = access.ReadData("IdInsumo", null);
            if (string.IsNullOrEmpty(data))
                return 0;
            else return int.Parse(data);
        }
        public List<Supply> ListSupply()
        {
            List<Supply> list = new List<Supply>();
            DataTable dt = access.Read("ListarInsumo", null,"Insumos");
            foreach (DataRow dr in dt.Rows)
            {
                Supply supply = new Supply()
                {
                    IdSupply = int.Parse(dr["IdInsumo"].ToString()),
                    Product = dr["Producto"].ToString(),
                    SupplyPrice = decimal.Parse(dr["PrecioInsumo"].ToString()),
                    Yield = decimal.Parse(dr["Rendimiento"].ToString()),
                    CustomerPrice = decimal.Parse(dr["PrecioCliente"].ToString())
                };
                list.Add(supply);
            }
            return list;
        }
        public void BackUpSupply(string archive)
        {
            access.BackUpXML("ListarInsumo",null,archive);
        }

        public string SupplyExpenses()
        {
            string data = access.ReadData("GastosInsumos", null);
            if (string.IsNullOrEmpty(data))
                return "0";
            else return data;
        }
    }
}
