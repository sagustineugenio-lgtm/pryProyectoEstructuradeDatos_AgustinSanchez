using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void msCola_Click(object sender, EventArgs e)
        {
           frmCola frmCola = new frmCola();
           frmCola.Show();
        }

        private void msPila_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.Show();
        }

        private void msListaEntraSimple_Click(object sender, EventArgs e)
        {
            frmLista frmLista = new frmLista();
            frmLista.Show();
        }

        private void msListaDobleEnlazada_Click(object sender, EventArgs e)
        {
            frmListaDoble frmListaDoble = new frmListaDoble();
            frmListaDoble.Show();
        }
    }
}
