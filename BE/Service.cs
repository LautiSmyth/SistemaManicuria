using System.ComponentModel;

namespace BE
{
    public class Service
    {
        private int idService;
        private string description;
        private decimal hours;
        private decimal laborPrice;
        private decimal servicePrice;
        private decimal pctCommission;
        private decimal commission;
        [DisplayName("ID")]
        public int IdService
        {
            get { return idService; }
            set { idService = value; }
        }
        [DisplayName("Descripcion")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [DisplayName("Horas")]
        public decimal Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        [DisplayName("$Labor")]
        public decimal LaborPrice
        {
            get { return laborPrice; }
            set { laborPrice = value; }
        }
        [DisplayName("$Servicio")]
        public decimal ServicePrice
        {
            get { return servicePrice; }
            set { servicePrice = value; }
        }
        [DisplayName("%Comision")]
        public decimal PctCommission
        {
            get { return pctCommission; }
            set { pctCommission = value; }
        }
        [DisplayName("Comision")]
        public decimal Commission
        {
            get { return commission; }
            set { commission = value; }
        }
    }
}
