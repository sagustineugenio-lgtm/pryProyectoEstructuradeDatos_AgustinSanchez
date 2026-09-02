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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsPila p = new clsPila();
            clsNodo x = new clsNodo();

            x.Codigo = Convert.ToInt32(txtElimCodigo.Text);
            x.Nombre = txtElimNombre.Text;
            x.Tramite = txtElimTramite.Text;

            p.Eliminar(x);
            p.Recorrer(lstListaPila);
            p.RecorrerDgv(dgvPila);
        }
    }
}
