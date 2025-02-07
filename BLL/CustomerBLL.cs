using DAL;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BLL
{
    public class CustomerBLL
    {
        private readonly CustomerDAL mapper = new CustomerDAL();

        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        public bool ValidatePhone(string phone)
        {
            string pattern = @"^(?:(54)\s?)?(?:9\s?)?(?:\d{2,3})\s?(\d{3,4})\s?(\d{4})$";
            return Regex.IsMatch(phone, pattern);
        }
        public int AddCustomer(BE.Customer customer)
        {
            customer.IdCustomer = mapper.IdCustomer() + 1;
            int ar = mapper.AddCustomer(customer);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el cliente");
            }
            else
                BackUpCustomer("Clientes");
            return ar;
        }

        public void DeleteCustomer(BE.Customer customer)
        {
            try
            {
                mapper.DeleteCustomer(customer);
                BackUpCustomer("Clientes");
            }
            catch 
            {
                throw new Exception("Error al eliminar el cliente");
            }
        }

        public List<BE.Customer> ListCustomer()
        {
            try
            {
                return mapper.ListCustomer();
            }
            catch
            {
                throw new Exception("Error al cargar la lista de clientes");
            }
        }

        public int UpdateCustomer(BE.Customer customer)
        {
            int ar = mapper.UpdateCustomer(customer);
            if (ar == -1)
            {
                throw new Exception("Error al modificar el cliente");
            }
            else
                BackUpCustomer("Clientes");
            return ar;
        }
        public void BackUpCustomer(string archive)
        {
            mapper.BackUpCustomer(archive);
        }
    }
}
