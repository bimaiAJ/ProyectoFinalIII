using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoFinalHotelAJRC
{
    public partial class HabitacionesDobles : Form
    {
        public HabitacionesDobles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();
            nodo nuevoNodo = new nodo();
            nuevoNodo.habitacion = habitaciones;
            if (textBox1.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                if (!Form1.instance.getListaHabitaciones().existNodeH((int)numericUpDown2.Value))
                {
                    habitaciones.setName(textBox1.Text);
                    habitaciones.setFechaingreso(dateTimePicker1.Value);
                    habitaciones.setFechasalida(dateTimePicker2.Value);
                    habitaciones.setCantidadN((int)numericUpDown1.Value);
                    habitaciones.setNoHabitaciones((int)numericUpDown2.Value);
                    label5.Visible = false;
                    label7.Visible = false;
                }
                else
                {
                    label5.Visible = true;
                }
            }


            Form1.instance.getListaHabitaciones().insertarNodo(nuevoNodo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            int cantidadNoches = (int)numericUpDown1.Value;
            int cantidad = 0;
            if (cantidadNoches >= 7)
            {
                message += Form1.instance.getListaHabitaciones().getnodoHabitacion();
                cantidadNoches = (int)numericUpDown1.Value * 16;
                cantidad = cantidad + 1;
                MessageBox.Show("Habitaciones dobles " + message + "-" + "$." + cantidadNoches.ToString() + "Dolares" +" caantidad de reservaciones: "+cantidad);
            }
            else
            {
                message += Form1.instance.getListaHabitaciones().getnodoHabitacion();
                cantidadNoches = (int)numericUpDown1.Value * 20;
                cantidad = cantidad + 1;
                MessageBox.Show("Habitaciones dobles "+message + "-" + "$." + cantidadNoches.ToString() + "Dolares" + " caantidad de reservaciones: " + cantidad);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ventanaControl Huesped = new ventanaControl();
            Huesped.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si el cliente se hospeda mas de 7 noches el precio bajaria a 16 dolares la noche, de lo contrario el precio seria normal");
        }
    }
}
