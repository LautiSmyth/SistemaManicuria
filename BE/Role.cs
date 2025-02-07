using System.ComponentModel;

namespace BE
{
    public class Role
    {
        private int idRole;
        private string name;
        [DisplayName("ID")]
        public int IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }
        [DisplayName("Nombre")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}
