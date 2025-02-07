using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class RoleBLL
    {
        private readonly RoleDAL mapper = new RoleDAL();
        public List<BE.Role> ListRole()
        {
            try
            {
                return mapper.ListRole();
            }
            catch
            {
                throw new Exception("Error al cargar los roles");
            }
            
        }
    }
}
