namespace BE
{
    public class Ticket
    {
        private int idTicket;
        private int idCustomer;
        private string description;
        private decimal total;
        private string dateTicket;

        public int IdTicket
        {
            get { return idTicket; }
            set { idTicket = value; }
        }

        public int IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public string DateTicket
        {
            get { return dateTicket; }
            set { dateTicket = value; }
        }
    }
}
