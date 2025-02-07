using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL
    {
        private readonly Access access = new Access();

        public int AddUser(User user)
        {
            PBKDF pbkdf = new PBKDF(user.Hash);
            user.IdUser = IdUser() + 1;
            user.Hash = pbkdf.Hash;
            user.Salt = Convert.ToBase64String(pbkdf.Salt);

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdUsuario", user.IdUser),
                new SqlParameter("@Nombre",user.Name),
                new SqlParameter("@IdRol",user.IdRole),
                new SqlParameter("@Hash",user.Hash),
                new SqlParameter("@Salt",user.Salt)
            };
            return access.Writer("AltaUsuario", sp);
        }

        public void DeleteUser(User user)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdUsuario", user.IdUser),
            };
            access.Writer("BajaUsuario", sp);
        }

        public int IdUser()
        {
            string data = access.ReadData("IdUsuario", null);
            if (string.IsNullOrEmpty(data))
                return 0;
            else return int.Parse(data);
        }

        public List<User> ListUser()
        {
            List<User> list = new List<User>();
            DataTable dt = access.Read("ListarUsuario", null);
            foreach (DataRow dr in dt.Rows)
            {
                User usuario = new User()
                {
                    IdUser = int.Parse(dr["IdUsuario"].ToString()),
                    Name = dr["Nombre"].ToString(),
                    IdRole = int.Parse(dr["IdRol"].ToString()),
                    Hash = dr["Hash"].ToString(),
                    Salt = dr["Salt"].ToString(),
                };
                list.Add(usuario);
            }
            return list;
        }

        public int UpdateUser(User user)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdUsuario", user.IdUser),
                new SqlParameter("@Nombre",user.Name),
                new SqlParameter("@IdRol",user.IdRole)
            };
            return access.Writer("ModificacionUsuario", sp);
        }

        public int ChangePass(User user)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdUsuario", user.IdUser),
                new SqlParameter("@Hash",user.Hash),
            };
            return access.Writer("CambiarContraseña", sp);
        }

        public User ValidateUser(string user, string pass)
        {
            List<User> listUsers = ListUser();
            foreach (User row in listUsers)
            {
                if (row.Name == user && PBKDF.ValidatePassword(pass, row.Hash, row.Salt))
                {
                    return row;
                }
            }
            throw new Exception("Usuario o contraseña incorrectos. \n Intenta de nuevo.");
        }
    }
}
