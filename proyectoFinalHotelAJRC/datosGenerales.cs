using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalHotelAJRC
{
    internal class datosGenerales
    {
        //metodos 
        private String usuario;
        private String clave;
        //constructor
        public datosGenerales(String usuario, String clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        } // fin del constructor

        //set y get
        public string getusuario()
        {
            return this.usuario;
        }

        public String getclave()
        {
            return this.clave;
        }

        public void setclave(String clave)
        {
            this.clave = clave;
        }

        public void setusuario(String usuario)
        {
            this.usuario = usuario;
        }
    }
}
