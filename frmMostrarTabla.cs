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
    public partial class frmMostrarTabla : Form
    {
        public frmMostrarTabla()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos bd = new clsBaseDeDatos();
            bd.Listar(dgvTabla, cmbLista.Text);
        }
    }
}
