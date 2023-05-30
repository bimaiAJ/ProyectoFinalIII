using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinalHotelAJRC
{
    public partial class ventanaControl : Form
    {
        
        public ventanaControl()
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
        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sesion = new Form1();
            sesion.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string Nombre = textBox1.Text;
            string Apellidos = textBox2.Text;
            string numero = textBox3.Text;
            DateTime FechaIngreso = dtIngreso.Value;
            DateTime FechaSalida = dtSalida.Value;
            int Mayores = (int)chkAdultos.Value;
            int Menores = (int)chkMenores.Value;

            if(string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Apellidos) || string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Es necesario colocar los datos solicitados!");
                return;
            }
            */

            Cliente nuevoCliente = new Cliente();
            if(textBox1.Text == "" && textBox2.Text=="") 
            {
                label11.Visible = true;
                label12.Visible = true;
            }
            else if (textBox1.Text == "")
            {
                label11.Visible = true;
                label12.Visible = false;
            }
            else if (textBox2.Text == "")
            {
                label11.Visible = false;
                label12.Visible = true;
            }
            else
            {
                if (ValidarEmail(textBox4.Text) == true)
                {
                    if (ValidarNumeroTelefono(textBox3.Text))
                    {
                        if (!Form1.instance.getListaClientes().existNode(textBox4.Text))
                        {

                            nuevoCliente.setName(textBox1.Text);
                            nuevoCliente.setApellido(textBox2.Text);
                            nuevoCliente.setTel(textBox3.Text);
                            nuevoCliente.setEmail(textBox4.Text);
                            nuevoCliente.setAdultos((int)chkAdultos.Value);
                            nuevoCliente.setMenoresAGE((int)chkMenores.Value);

                            nodo nuevoNodo = new nodo();
                            nuevoNodo.dato = nuevoCliente;


                            Form1.instance.getListaClientes().insertarNodo(nuevoNodo);
                            label10.Visible = false;
                            label5.Visible = false;
                            label6.Visible = false;
                            label11.Visible = false;
                        }
                        else
                        {
                            label10.Visible = true;
                        }
                    }
                    else
                    {
                        label6.Visible = true;
                    }
                }
                else
                {
                    label5.Visible = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
            this.Hide();
        }

        private void ventanaControl_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "";
            
            message += Form1.instance.getListaClientes().getNodo();

            MessageBox.Show(message);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int totalP = (int)chkAdultos.Value + (int)chkMenores.Value;

            if (totalP <= 3)
            {
                ReservacionHabitacion Reservar = new ReservacionHabitacion();
                Reservar.Show();
                this.Hide();
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Se recomienda que utilice las habitaciones dobles ", "Sugerencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    ReservacionHabitacion Reservar = new ReservacionHabitacion();
                    Reservar.Show();
                    this.Hide();
                }
                if (respuesta == DialogResult.Yes)
                {
                    HabitacionesDobles reservar = new HabitacionesDobles();
                    reservar.Show();
                    this.Hide();
                }
            }
        }


    }
}
