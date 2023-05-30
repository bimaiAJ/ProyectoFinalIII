using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFinalHotelAJRC
{
    public class nodo
    {
        private Cliente Dato;//cliente
        private Habitaciones Habitacion;//habitacion
        private ReservarSalon Salon;//salon eventos
        private SalonLuna salonLUNA;//salon luna 
        private SalonSol salonSOL;//salon sol
        private nodo Siguiente;
        private nodo Atras;

        public Cliente dato
        {
            get { return Dato; }
            set { Dato = value; }
        }
        public Habitaciones habitacion
        {
            get { return Habitacion; }
            set { Habitacion = value; }
        }
        public ReservarSalon salon
        {
            get { return Salon; }
            set { Salon = value; }
        }
        public SalonLuna salonLuna
        {
            get { return salonLUNA; }
            set { salonLUNA = value; }
        }
        public SalonSol salonSol
        {
            get { return salonSOL; }
            set { salonSOL = value; }
        }
        public nodo siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }
        public nodo atras
        {
            get { return Atras; }
            set { Atras = value; }
        }
    }
}
