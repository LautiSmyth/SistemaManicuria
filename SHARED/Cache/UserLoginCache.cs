namespace SHARED.Cache
{
    public class UserLoginCache
    {
        private static UserLoginCache instancia;

        public static UserLoginCache Instancia
        {
            get 
            { 
                if(instancia==null)
                    instancia = new UserLoginCache();
                return instancia; 
            }
        }
        private UserLoginCache() { }

        private static int idUser;

        public static int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        private static string name;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        private static BE.Role role;

        public static BE.Role Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}
