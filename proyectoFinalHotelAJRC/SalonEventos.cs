using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoFinalHotelAJRC
{
    public partial class SalonEventos : Form
    {
        public SalonEventos()
        {
            InitializeComponent();
        }
        public static bool ValidarEmail(string comprobarEmail)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w)*@gmail.com";
            if (Regex.IsMatch(comprobarEmail, emailFormato))
            {
                if (Regex.Replace(comprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static bool ValidarNumeroTelefono(string telNumber)
        {
            if (telNumber.Length != 8)
            {
                return false;
            }

            foreach (char c in telNumber)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
        private void SalonEventos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string Nombre = textBox1.Text;
            string Apellidos = textBox2.Text;
            String Telefono = textBox3.Text;
            DateTime Fecha = dateTimePicker1.Value;
            DateTime horaEntrada = dateTimePicker2.Value;
            DateTime horaSalida = dateTimePicker3.Value;

            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellidos) || string.IsNullOrWhiteSpace(Telefono))
            {
                MessageBox.Show("Por favor ingresar los datos que se le piden, Gracias!");
                return;
            }

            string mensaje = string.Format("¡Salon reservado exitosamente!\n\nNombre: {0}\nApellidos: {1}\n Fecha: {2}\n Telefono: {3}\nHorario de Entrada: {4}\nHorario de Salida:{5} ",
                  Nombre, Apellidos, Telefono, Fecha.ToString("dd/MM/yyyy"), horaEntrada, horaSalida);
            MessageBox.Show(mensaje);
            */
            ReservarSalon clienteSalon = new ReservarSalon();
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                label10.Visible = true;
                label11.Visible = true;
            }
            else if (textBox1.Text == "")
            {
                label10.Visible = true;
                label11.Visible = false;
            }
            else if (textBox2.Text == "")
            {
                label10.Visible = false;
                label11.Visible = true;
            }
            else
            {
                if (ValidarEmail(textBox4.Text) == true)
                {
                    if (ValidarNumeroTelefono(textBox3.Text))
                    {
                        if (!Form1.instance.getListaSalon().existNodeSalon(textBox4.Text))
                        {
                            clienteSalon.setName(textBox1.Text);
                            clienteSalon.setApellido(textBox2.Text);
                            clienteSalon.setTel(textBox3.Text);
                            clienteSalon.setEmail(textBox4.Text);
                            clienteSalon.setCantidadPersonas((int)numericUpDown1.Value);

                            nodo nuevoNodo = new nodo();
                            nuevoNodo.salon = clienteSalon;
                            Form1.instance.getListaSalon().insertarNodo(nuevoNodo);
                            label9.Visible = false;
                            label4.Visible = false;
                            label5.Visible = false;
                            label10.Visible = false;
                            label11.Visible = false;
                        }
                        else
                        {
                            label9.Visible = true;
                        }
                    }
                    else
                    {
                        label5.Visible = true;
                    }
                }
                else
                {
                    label4.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
            this.Hide();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresarAlMenusPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sesion = new Form1();
            sesion.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";

            message += Form1.instance.getListaSalon().getnodoSalones();

            MessageBox.Show(message);
        }

        private void button4_Click(object sender, EventArgs e)
        {
           int CantidadP = (int)numericUpDown1.Value;
            if(CantidadP >= 101 && CantidadP <= 300)
            {
                EventosSalonSol salonSol = new EventosSalonSol();
                salonSol.Show();
                this.Hide();
            }
            else
            {
                EventosSalonLuna salonLuna = new EventosSalonLuna();
                salonLuna.Show();
                this.Hide();
            }
        }
    }
}
