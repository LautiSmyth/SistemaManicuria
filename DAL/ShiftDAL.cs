using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ShiftDAL
    {
        private readonly Access access = new Access();

        public int AddShift(Shift shift)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdTurno", shift.IdShift),
                new SqlParameter("@IdCliente",shift.IdCustomer),
                new SqlParameter("@IdUsuario",shift.IdUser),
                new SqlParameter("@IdServicio",shift.IdService),
                new SqlParameter("@FechaTurno",shift.DateShift),
                new SqlParameter("@HoraTurno",shift.HourShift),
                new SqlParameter("@Finalizado",shift.Finalized),
                new SqlParameter("@FechaRegistro",shift.DateRegister)
            };
            return access.Writer("AltaTurno", sp);
        }

        public void BackUpShift(string archive)
        {
            access.BackUpXML("ListarTurno", null, archive);
        }

        public void DeleteShift(Shift shift)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdTurno", shift.IdShift),
            };
            access.Writer("BajaTurno", sp);
        }

        public int IdShift()
        {
            string data = access.ReadData("IdTurno", null);
            if (string.IsNullOrEmpty(data))
                return 0;
            else return int.Parse(data);
        }

        public List<Shift> ListShift()
        {
            List<Shift> list = new List<Shift>();
            DataTable dt = access.Read("ListarTurno", null,"Turnos");
            foreach (DataRow dr in dt.Rows)
            {
                Shift shift = new Shift()
                {
                    IdShift = int.Parse(dr["IdTurno"].ToString()),
                    IdCustomer = int.Parse(dr["IdCliente"].ToString()),
                    Customer = dr["Cliente"].ToString(),
                    IdUser = int.Parse(dr["IdUsuario"].ToString()),
                    User = dr["usuario"].ToString(),
                    IdService = int.Parse(dr["IdServicio"].ToString()),
                    Service = dr["Servicio"].ToString(),
                    DateShift = dr["FechaTurno"].ToString(),
                    HourShift = dr["HoraTurno"].ToString(),
                    Finalized = bool.Parse(dr["Finalizado"].ToString()),
                    DateRegister = dr["FechaRegistro"].ToString(),
                };
                list.Add(shift);
            }
            return list;
        }

        public int UpdateShift(Shift shift)
        {
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@IdTurno", shift.IdShift),
                new SqlParameter("@Idcliente", shift.IdCustomer),
                new SqlParameter("@IdUsuario",shift.IdUser),
                new SqlParameter("@IdServicio",shift.IdService),
                new SqlParameter("@FechaTurno",shift.DateShift),
                new SqlParameter("@HoraTurno",shift.HourShift),
                new SqlParameter("@Finalizado",shift.Finalized),
                new SqlParameter("@FechaRegistro",shift.DateRegister)
            };
            return access.Writer("ModificacionTurno", sp);
        }
    }
}
