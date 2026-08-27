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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            clsPila p = new clsPila();

            x.Codigo = Convert.ToInt32(txtAgrCodigo.Text);
            x.Nombre = txtAgrNombre.Text;
            x.Tramite = txtAgrTramite.Text;

            p.AgregarPila(x);
            p.Recorrer(lstListaPila);
            p.RecorrerDgv(dgvPila);
        }
    }
}
