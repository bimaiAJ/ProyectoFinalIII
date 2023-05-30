using System.Collections.Generic;

namespace proyectoFinalHotelAJRC
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        Lista ListaClientes = new Lista();
        Lista ListaHabitaciones = new Lista();
        Lista ListaSalones = new Lista();
        Lista ListaSalonesLunaySol = new Lista();
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, clave;
            usuario = textBox1.Text;
            clave = textBox2.Text;

            if (usuario == "usuario1" && clave == "1234")
            {
                MenuPrincipal principal= new MenuPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Lo datos ingresados son incorrectos", "Datos incorrectos",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                if(respuesta == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if(respuesta==DialogResult.Retry)
                {
                    contador = contador + 1;
                    textBox1.Clear();
                    textBox2.Clear();
                    if (contador == 3)
                    {
                        MessageBox.Show("Se alcanzo el maximo numero de intentos");
                        Application.Exit();
                    }
                }   

            }
        }
        public Lista getListaClientes()
        {
            return ListaClientes;
        }
        public Lista getListaHabitaciones()
        {
            return ListaHabitaciones;
        }
        public Lista getListaSalon()
        {
            return ListaSalones;
        }
        public Lista getListaSalonLunaySol()
        {
            return ListaSalonesLunaySol;
        }
    }
}