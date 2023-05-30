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
    public partial class EventosSalonLuna : Form
    {
        public EventosSalonLuna()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//regresar
        {
            SalonEventos registro = new SalonEventos();
            registro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime FechaE = dateTimePicker2.Value;
            DateTime fechaS = dateTimePicker3.Value;
            SalonLuna salonLuna = new SalonLuna();
            if (textBox1.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                if (FechaE.Hour >= 8 && fechaS.Hour <= 11 || FechaE.Hour >= 14 && fechaS.Hour <= 17)
                {
                    salonLuna.setName(textBox1.Text);
                    salonLuna.setFechaentrada(dateTimePicker1.Value);
                    salonLuna.setFechaHoraE(FechaE);
                    salonLuna.setFechaHoraS(fechaS);

                    nodo nuevoNodo = new nodo();
                    nuevoNodo.salonLuna = salonLuna;

                    Form1.instance.getListaSalonLunaySol().insertarNodo(nuevoNodo);
                    label2.Visible = false;
                    label6.Visible = false;
                }
                else
                {
                    MessageBox.Show("Los horarios estan de 8:00am a 12:00pm y de 14:00pm a 18:00pm", "Horario no accesible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (FechaE.Hour < 8 || FechaE.Hour < 14)
                    {
                        label2.Visible = true;
                        label6.Visible = false;
                    }
                    if (fechaS.Hour > 12 || fechaS.Hour > 18)
                    {
                        label6.Visible = true;
                        label2.Visible = false;
                    }
                }
                label8.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";

            message += Form1.instance.getListaSalonLunaySol().getnodoSalonesLUNAySOL();

            MessageBox.Show(message);

        }
    }
}
