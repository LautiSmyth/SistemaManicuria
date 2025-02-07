using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetailDAL
    {
        private readonly Access access = new Access();
        public int AddDetail(Detail detail)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdFactura", detail.IdTicket),
                new SqlParameter("@IdServicio",detail.IdService),
                new SqlParameter("@Servicio",detail.Service),
                new SqlParameter("@Horas",detail.Hours),
                new SqlParameter("@Precio",detail.Price),
                new SqlParameter("@SubTotal",detail.SubTotal)
            };
            return access.Writer("AltaDetalle", sp);
        }
    }
}
