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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventanaControl reservacion = new ventanaControl();
            reservacion.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalonEventos salon = new SalonEventos();
            salon.Show();
            this.Hide();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sesion = new Form1();
            sesion.Show();
            this.Close();
        }
    }
}
