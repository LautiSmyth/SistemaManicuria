using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Supply
    {
		private int idSupply;
		private string product;
		private decimal supplyPrice;
		private decimal yield;
		private decimal customerPrice;

        [DisplayName("ID")]
        public int IdSupply
		{
			get { return idSupply; }
			set { idSupply = value; }
		}
        [DisplayName("Producto")]
        public string Product
		{
			get { return product; }
			set { product = value; }
		}
        [DisplayName("$Precio")]
        public decimal SupplyPrice
		{
			get { return supplyPrice; }
			set { supplyPrice = value; }
		}
        [DisplayName("Rinde")]
        public decimal Yield
        {
			get { return yield; }
			set { yield = value; }
		}
        [DisplayName("$Cliente")]
        public decimal CustomerPrice
		{
			get { return customerPrice; }
			set { customerPrice = value; }
		}





	}
}
