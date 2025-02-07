namespace BE
{
    public class User
    {
        private int idUser;
        private string name;
        private int idRole;
        private string hash;
        private string salt;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int IdRole
        {
            get { return idRole; }
            set { idRole = value; }
        }


        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }


    }
}
