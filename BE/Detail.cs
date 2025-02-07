using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Detail
    {
		private int idTicket;
		private int idService;
		private string service;
		private decimal hours;
		private decimal price;
		private decimal subTotal;

        [Browsable(false)]
        public int IdTicket
		{
			get { return idTicket; }
			set { idTicket = value; }
		}
        [Browsable(false)]
        public int IdService
		{
			get { return idService; }
			set { idService = value; }
		}
        [DisplayName("Servicio")]
        public string Service
		{
			get { return service; }
			set { service = value; }
		}
        [DisplayName("Horas")]
        public decimal Hours
		{
			get { return hours; }
			set { hours = value; }
		}
        [DisplayName("Precio")]
        public decimal Price
		{
			get { return price; }
			set { price = value; }
		}
        [DisplayName("Subtotal")]
        public decimal SubTotal
        {
			get { return subTotal; }
			set { subTotal = value; }
		}







	}
}
