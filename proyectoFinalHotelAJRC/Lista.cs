using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace proyectoFinalHotelAJRC
{
    public class Lista
    {
        //desarrolo de la lista circualar doblemente enlazadas
        nodo primero = new nodo();
        nodo ultimo = new nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }
        public void insertarNodo( nodo nuevo )
        {
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.siguiente = primero;
                primero.atras = ultimo;
            }
            else
            {
                ultimo.siguiente = nuevo;
                nuevo.atras = ultimo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
                primero.atras = ultimo;
            }
            Console.WriteLine("Dato guardado\n");
        }
        public void Eliminar(String eliminar)
        {
            nodo actual = new nodo();
            actual = primero;
            nodo anterior = new nodo();
            anterior = null;
            bool encontrado = false;

            if (actual != null)
            {
                do
                {
                    if (actual.dato.getName() == eliminar)
                    {
                        if (actual == primero)
                        {
                            primero = primero.siguiente;
                            primero.atras = ultimo;
                            ultimo.siguiente = primero;
                        }
                        else if (actual == ultimo)
                        {
                            ultimo = anterior;
                            ultimo.siguiente = primero;
                            primero.atras = ultimo;
                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                            actual.siguiente.atras = anterior;
                        }
                        Console.WriteLine("nodo eliminado");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.siguiente;
                } while (actual != primero && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine(" la lista esta vacia\n");
            }
        }
        public void buscarNodo()
        {
            nodo actual = new nodo();
            actual = primero;
            bool encontrado = false;
            Console.WriteLine("ingrese el nombre que quiere buscar");
            String nodoBuscado = Console.ReadLine();

            if (actual != null)
            {
                do
                {
                    if (actual.dato.getName() == nodoBuscado)
                    {
                        Console.WriteLine("nodo con el dato ({0}) encontrado", actual.dato);
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                } while (actual != primero && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine(" la lista esta vacia\n");
            }
        }
        public void modificarNodo()
        {
            nodo actual = new nodo();
            actual = primero;
            bool encontrado = false;
            Console.WriteLine("ingrese el nombre que quiere modificar");
            String nodoBuscado = Console.ReadLine();

            if (actual != null)
            {
                do
                {
                    if (actual.dato.getName() == nodoBuscado)
                    {
                        Console.WriteLine("nodo con el dato ({0}) encontrado", actual.dato);
                        Console.WriteLine("ingrese el nuevo dato para este nodo: ");
                        actual.dato.setName(Console.ReadLine());
                        Console.WriteLine("Nodo modificado con exito");
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                } while (actual != primero && encontrado != true);
                if (!encontrado)
                {
                    Console.WriteLine("nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine(" la lista esta vacia\n");
            }
        }
        public void desplegarListaPU(nodo actual)
        {
            actual = primero;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.siguiente;
                } while (actual != primero);
            }
            else
            {
                Console.WriteLine(" la lista esta vacia\n");
            }
        }
        public String getNodo()//lista personal
        {
            String message = "";

            nodo actual = this.primero;

            while (actual != null)
            {
                Cliente datos = actual.dato;

                message +="Nombre: "+ datos.getName() + " - "+"Apellido: " + datos.getApellido() + " - "+"Telefono: "+ datos.getTel()+" - "+"Correo: "+datos.getEmail()+" - "+"Adultos: "+datos.getAdultos()+" - "+"Niños: "+datos.getMenoresAGE()+"\n";
                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }
            }
            return message;

        }
        public String getnodoHabitacion()//lista de habitacion
        {
            String message = "";

            nodo actual = this.primero;

            while (actual != null)
            {
                Habitaciones datoss = actual.habitacion;

                message += "Nombre de la reservacion: "+datoss.getName()+" - "+" Fecha de ingreso: "+datoss.getFechaingreso() + " - " +"fecha de salida: "+ datoss.getFechasalida()+" - "+"Noches quedadas: "+datoss.getCantidadN()+" - "+"No. habitaciones: "+datoss.getNoHabitaciones()+"\n";
                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }
            }
            return message;
        }
        public String getnodoSalones()//lista del salon
        {
            String message = "";

            nodo actual = this.primero;

            while (actual != null)
            {
                ReservarSalon data = actual.salon;

                message += "Nombre: "+data.getName()+" - "+"Apellidos: "+ data.getApellido()+" - "+"Telefono: "+data.getTel()+" - "+"Correo: "+data.getEmail()+" - "+"Cantidad de personas: "+data.getCantidadPersonas()+"\n";
                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }
            }
            return message;
        }
        public String getnodoSalonesLUNAySOL()//lista del salon luna y sol
        {
            String message = "";

            nodo actual = this.primero;

            while (actual != null)
            {
                SalonLuna horario = actual.salonLuna;

                message += "Nombre de quien reserva: "+horario.getName()+" - "+"Fecha reervada: "+horario.getFechaentrada()+ " - Horas que inicia: " + horario.getFechaHoraE() + " - Horas que finaliza: " + horario.getFechaHoraS() + "\n";
                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }
            }
            return message;
        }
        public void desplegarListaUP(nodo actual)
        {
         
            actual = ultimo;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.atras;
                } while (actual != ultimo);
            }
            else
            {
                Console.WriteLine("\n la lista esta vacia\n");
            }
        }
        public bool existNode(String identifier)// nodo repetido en la lista personal
        {
            bool exists = false;

            nodo actual = this.primero;

            while (actual != null)
            {
                Cliente cliente = actual.dato;
                if (cliente.getEmail() == identifier)
                {
                    exists = true;
                    break;
                }

                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }
                
            }

            return exists;
        }
        public bool existNodeH(int identificar)// nodo repetido en lista habitacion 
        {
            bool exists = false;

            nodo actual = this.primero;

            while (actual != null)
            {
                Habitaciones mismoH = actual.habitacion;
                if (mismoH.getNoHabitaciones() == identificar)
                {
                    exists = true;
                    break;
                }

                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }

            }

            return exists;
        }
        public bool existNodeSalon(String verificar)// nodo repetido en la lista personal
        {
            bool exists = false;

            nodo actual = this.primero;

            while (actual != null)
            {
                ReservarSalon clientesalon = actual.salon;
                if (clientesalon.getEmail() == verificar)
                {
                    exists = true;
                    break;
                }

                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }

            }

            return exists;
        }
        public bool existNodeDate(DateTime identificar)// nodo repetido en salon luna y sol 
        {
            bool exists = false;

            nodo actual = this.primero;

            while (actual != null)
            {
                SalonLuna mismoDate = actual.salonLuna;
                if (mismoDate.getFechaHoraE() == identificar)
                {
                    exists = true;
                    break;
                }

                actual = actual.siguiente;
                if (actual == ultimo)
                {
                    break;
                }

            }

            return exists;
        }
    }
}
