using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalHotelAJRC
{
    public class SalonLuna:VariablesH
    {
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public DateTime getFechaentrada()
        {
            return this.fechaIngreso;
        }
        public void setFechaentrada(DateTime fechaEntrada)
        {
            this.fechaIngreso = fechaEntrada;
        }
        public DateTime getFechaHoraE()
        {
            return this.horaIn;
        }
        public void setFechaHoraE(DateTime horaIn)
        {
            this.horaIn = horaIn;
        }
        public DateTime getFechaHoraS()
        {
            return this.horaout;
        }
        public void setFechaHoraS(DateTime horaout)
        {
            this.horaout = horaout;
        }

    }
}
