using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ShiftBLL
    {
        private readonly ShiftDAL mapper = new ShiftDAL();

        public int AddShift(BE.Shift shift)
        {
            shift.IdShift = mapper.IdShift() + 1;
            shift.Finalized = false;
            int ar = mapper.AddShift(shift);
            if (ar == -1)
            {
                throw new Exception("Error al agregar el turno");
            }
            else
                BackUpShift("Turnos");
            return ar;
        }

        public void DeleteShift(BE.Shift shift)
        {
            try
            {
                mapper.DeleteShift(shift);
                BackUpShift("Turnos");
            }
            catch
            {
                throw new Exception("Error al eliminar el turno");
            }
        }

        public List<BE.Shift> ListShift()
        {
            try
            {
                return mapper.ListShift();
            }
            catch
            {
                throw new Exception("Error al cargar los turnos");
            }
        }

        public int UpdateShift(BE.Shift shift)
        {
            int ar = mapper.UpdateShift(shift);
            if (ar == -1)
            {
                throw new Exception("Error al modificar el turno");
            }
            else
                BackUpShift("Turnos");
            return ar;
        }

        public void BackUpShift(string archive)
        {
            mapper.BackUpShift(archive);
        }
    }
}
