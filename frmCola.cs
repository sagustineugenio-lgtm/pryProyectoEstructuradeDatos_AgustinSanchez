using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
           
        }
        clsCola objCola = new clsCola();
        clsNodo objNodo = new clsNodo();


        private void frmCola_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objNodo.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            objNodo.Nombre = txtNuevoNombre.Text;
            objNodo.Tramite = txtNuevoTramite.Text;

            objCola.Agregar(objNodo);
            objCola.Recorrer(lstCola);

        }
    }
}
