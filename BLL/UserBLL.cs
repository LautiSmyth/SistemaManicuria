using BE;
using DAL;
using SHARED.Cache;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class UserBLL
    {
        private readonly UserDAL mapper = new UserDAL();

        public void ValidateUser(string userName, string pass)
        {
            try
            {
                User user = mapper.ValidateUser(userName, pass);
                UserLoginCache.IdUser = user.IdUser;
                UserLoginCache.Name = user.Name;
                UserLoginCache.Role = Roles.List.FirstOrDefault(role => role.IdRole == user.IdRole);
            }
            catch
            {
                throw new Exception("Error al validar el usuario");
            }
        }

        public int AddUser(User user)
        {
            user.IdUser = mapper.IdUser() + 1;
            int ar = mapper.AddUser(user);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el usuario");
            }
            return ar;
        }

        public List<User> ListUser()
        {
            try
            {
                return mapper.ListUser();
            }
            catch
            {
                throw new Exception("Error al cargar los usuarios");
            }
        }
    }
}
