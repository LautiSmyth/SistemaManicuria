using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class TicketBLL
    {
        private readonly TicketDAL mapper = new TicketDAL();

        public int AddTicket(BE.Ticket ticket)
        {
            ticket.IdTicket = mapper.IdTicket() + 1;
            int ar = mapper.AddTicket(ticket);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el factura");
            }else
                BackUpTicket("Facturas");
            return ar;
        }

        public void DeleteTicket(BE.Ticket ticket)
        {
            try
            {
                mapper.DeleteTicket(ticket);
                BackUpTicket("Facturas");
            }
            catch
            {
                throw new Exception("Error al eliminar la factura");
            }
        }

        public decimal CalculateTotal(decimal extra, decimal ServiceCost)
        {
            return Math.Round(extra + ServiceCost, 2);
        }

        public List<BE.Ticket> ListTicket()
        {
            try
            {
                return mapper.ListTicket();
            }
            catch
            {
                throw new Exception("Error al cargar las facturas");
            }
        }
        public void BackUpTicket(string archive)
        {
            mapper.BackUpTicket(archive);
        }
    }
}
