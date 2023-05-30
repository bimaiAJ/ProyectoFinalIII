using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalHotelAJRC
{
    public class ReservarSalon:VariablesH
    {
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public string getTel()
        {
            return this.tel;
        }
        public void setTel(string tel)
        {
            this.tel = tel;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public int getCantidadPersonas()
        {
            return this.cantiadPersonas;
        }
        public void setCantidadPersonas(int cantidadPersonas)
        {
            this.cantiadPersonas = cantidadPersonas;
        }
    }
}
