using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetailBLL
    {
        private readonly DetailDAL mapper = new DetailDAL();

        public int AddDetail(int idTicket, List<BE.Detail> list)
        {
            int rsa=0;
            foreach(BE.Detail detail in list)
            {
                detail.IdTicket = idTicket;
                int ra = mapper.AddDetail(detail);
                if (ra == -1)
                    throw new Exception("Error al agregar los servicios");
                else rsa++;
            }
                return rsa;            
        }
    }
}
