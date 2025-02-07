using System.ComponentModel;

namespace BE
{
    public class Shift
    {
        private int idShift;
        private int idCustomer;
        private string customer;
        private int idUser;
        private string user;
        private int idService;
        private string service;
        private string dateShift;
        private string hourShift;
        private bool finalized;
        private string dateRegister;
        [DisplayName("ID")]
        public int IdShift
        {
            get { return idShift; }
            set { idShift = value; }
        }
        [Browsable(false)]
        public int IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }
        [DisplayName("Cliente")]
        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        [Browsable(false)]
        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        [DisplayName("Usuario")]
        public string User
        {
            get { return user; }
            set { user = value; }
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
        [DisplayName("Dia")]
        public string DateShift
        {
            get { return dateShift; }
            set { dateShift = value; }
        }
        [DisplayName("Hora")]
        public string HourShift
        {
            get { return hourShift; }
            set { hourShift = value; }
        }
        [DisplayName("Finalizado")]
        public bool Finalized
        {
            get { return finalized; }
            set { finalized = value; }
        }
        [DisplayName("Registro")]
        public string DateRegister
        {
            get { return dateRegister; }
            set { dateRegister = value; }
        }
    }
}
