using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TicketDAL
    {
        private readonly Access access = new Access();

        public int AddTicket(Ticket ticket)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdFactura", ticket.IdTicket),
                new SqlParameter("@IdCliente",ticket.IdCustomer),
                new SqlParameter("@Descripcion",ticket.Description),
                new SqlParameter("@Total",ticket.Total),
                new SqlParameter("@FechaFacturacion",ticket.DateTicket),
            };
            return access.Writer("AltaFactura", sp);
        }

        public void BackUpTicket(string archive)
        {
            access.BackUpXML("ListarFactura", null, archive);
        }

        public void DeleteTicket(Ticket ticket)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdFactura", ticket.IdTicket),
            };
            access.Writer("BajaFactura", sp);
        }

        public int IdTicket()
        {
            string data = access.ReadData("IdFactura", null);
            if (string.IsNullOrEmpty(data))
                return 0;
            else return int.Parse(data);
        }

        public List<Ticket> ListTicket()
        {
            List<Ticket> list = new List<Ticket>();
            DataTable dt = access.Read("ListarFactura", null,"Facturas");
            foreach (DataRow dr in dt.Rows)
            {
                Ticket ticket = new Ticket()
                {
                    IdTicket = int.Parse(dr["IdFactura"].ToString()),
                    IdCustomer = int.Parse(dr["IdCliente"].ToString()),
                    Description = dr["Descripcion"].ToString(),
                    Total = decimal.Parse(dr["Total"].ToString()),
                    DateTicket = dr["FechaFacturacion"].ToString(),
                };
                list.Add(ticket);
            }
            return list;
        }
    }
}
