using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalHotelAJRC
{
    public class Habitaciones:VariablesH
    {
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public DateTime getFechaingreso()
        {
            return this.fechaIngreso;
        }
        public void setFechaingreso(DateTime fechaIngreso)
        {
            this.fechaIngreso = fechaIngreso;
        }
        public DateTime getFechasalida()
        {
            return this.fechaSalida;
        }
        public void setFechasalida(DateTime fechaSalida)
        {
            this.fechaSalida = fechaSalida;
        }
        public int getCantidadN()
        {
            return this.cantidadnoches;
        }
        public void setCantidadN(int cantidadN)
        {
            this.cantidadnoches= cantidadN;
        }
        public int getNoHabitaciones()
        {
            return this.numerohabitaciones;
        }
        public void setNoHabitaciones(int numerohabitaciones)
        {
            this.numerohabitaciones = numerohabitaciones;
        }
    }
}
