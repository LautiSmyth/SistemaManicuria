using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class RoleDAL
    {
        private readonly Access access = new Access();
        public List<Role> ListRole()
        {
            List<Role> list = new List<Role>();
            DataTable dt = access.Read("ListarRol", null);
            foreach (DataRow dr in dt.Rows)
            {
                Role role = new Role()
                {
                    IdRole = int.Parse(dr["IdRol"].ToString()),
                    Name = dr["Nombre"].ToString(),
                };
                list.Add(role);
            }
            return list;
        }
    }
}
