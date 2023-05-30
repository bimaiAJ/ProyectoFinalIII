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
    public partial class EventosSalonSol : Form
    {
        public EventosSalonSol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime FechaE = dateTimePicker2.Value;
            DateTime fechaS = dateTimePicker3.Value;
            SalonSol salonSol = new SalonSol();
            if (textBox1.Text == "")
            {
                label8.Visible = true;
            }
            else
            {
                if (FechaE.Hour >= 8 && fechaS.Hour <= 12 || FechaE.Hour >= 14 && fechaS.Hour <= 18)
                {
                    salonSol.setName(textBox1.Text);
                    salonSol.setFechaentrada(dateTimePicker1.Value);
                    salonSol.setFechaHoraE(FechaE);
                    salonSol.setFechaHoraS(fechaS);

                    nodo nuevoNodo = new nodo();
                    nuevoNodo.salonSol = salonSol;

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

        private void button2_Click(object sender, EventArgs e)
        {
            SalonEventos registro = new SalonEventos();
            registro.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";

            message += Form1.instance.getListaSalonLunaySol().getnodoSalonesLUNAySOL();

            MessageBox.Show(message);
        }
    }
}
