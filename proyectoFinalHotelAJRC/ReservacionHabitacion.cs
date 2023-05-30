using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalHotelAJRC
{
    public partial class ReservacionHabitacion : Form
    {
        public ReservacionHabitacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habitaciones habitacion = new Habitaciones();
            nodo nuevoNodo = new nodo();
            nuevoNodo.habitacion = habitacion;
            if (textBox1.Text == "")
            {
                label7.Visible = true;
            }
            else
            {
                if (!Form1.instance.getListaHabitaciones().existNodeH((int)numericUpDown2.Value))
                {
                    habitacion.setName(textBox1.Text);
                    habitacion.setFechaingreso(dateTimePicker1.Value);
                    habitacion.setFechasalida(dateTimePicker2.Value);
                    habitacion.setCantidadN((int)numericUpDown1.Value);
                    habitacion.setNoHabitaciones((int)numericUpDown2.Value);
                    label5.Visible = false;
                    label7.Visible= false;
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
            if (cantidadNoches >= 7)
            {
                message += Form1.instance.getListaHabitaciones().getnodoHabitacion();
                cantidadNoches = (int)numericUpDown1.Value * 8;
                MessageBox.Show("Habitacion simple "+ message + "-" + "$." + cantidadNoches.ToString() + "Dolares");
            }
            else
            {
                message += Form1.instance.getListaHabitaciones().getnodoHabitacion();
                cantidadNoches = (int)numericUpDown1.Value * 12;
                MessageBox.Show("Habitacion simple "+message + "-" + "$." + cantidadNoches.ToString() + "Dolares");
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
            MessageBox.Show("Si el cliente se hospeda mas de 7 noches el precio bajaria a 8 dolares la noche, de lo contrario el precio seria normal");
        }
    }
}
