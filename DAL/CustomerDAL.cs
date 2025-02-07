using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CustomerDAL
    {
        private readonly Access access = new Access();

        public int AddCustomer(Customer customer)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdCliente", customer.IdCustomer),
                new SqlParameter("@Nombre",customer.Name),
                new SqlParameter("@Telefono",customer.Phone),
                new SqlParameter("@Email",customer.Email),
                new SqlParameter("@Direccion",customer.Address),
                new SqlParameter("@FechaRegistro",customer.DateRegister)
            };
            return access.Writer("AltaCliente", sp);
        }

        public void BackUpCustomer(string archive)
        {
            access.BackUpXML("ListarCliente", null, archive);
        }

        public void DeleteCustomer(Customer customer)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdCliente", customer.IdCustomer),
            };
            access.Writer("BajaCliente", sp);
        }

        public int IdCustomer()
        {
            string data = access.ReadData("IdCliente", null);
            if (string.IsNullOrEmpty(data))
                return 0;
            else return int.Parse(data);
        }

        public List<Customer> ListCustomer()
        {
            List<Customer> list = new List<Customer>();
            DataTable dt = access.Read("ListarCliente", null,"Clientes");
            foreach (DataRow dr in dt.Rows)
            {
                Customer customer = new Customer()
                {
                    IdCustomer = int.Parse(dr["IdCliente"].ToString()),
                    Name = dr["Nombre"].ToString(),
                    Phone = dr["Telefono"].ToString(),
                    Email = dr["Email"].ToString(),
                    Address = dr["Direccion"].ToString(),
                    DateRegister = dr["FechaRegistro"].ToString(),
                };
                list.Add(customer);
            }
            return list;
        }

        public int UpdateCustomer(Customer customer)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdCliente", customer.IdCustomer),
                new SqlParameter("@Nombre",customer.Name),
                new SqlParameter("@Telefono",customer.Phone),
                new SqlParameter("@Email",customer.Email),
                new SqlParameter("@Direccion",customer.Email),
                new SqlParameter("@FechaRegistro",customer.DateRegister)
            };
            return access.Writer("ModificacionCliente", sp);
        }
    }
}
