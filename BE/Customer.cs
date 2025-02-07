using System.ComponentModel;

namespace BE
{
    public class Customer
    {
        private int idCustomer;
        private string name;
        private string phone;
        private string email;
        private string address;
        private string dateRegister;

        [DisplayName("ID")]
        public int IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        [DisplayName("Nombre")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Telefono")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DisplayName("Direccion")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        [DisplayName("Registro")]
        public string DateRegister
        {
            get { return dateRegister; }
            set { dateRegister = value; }
        }
    }
}
