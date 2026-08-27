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
        
        


        private void frmCola_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            clsCola c = new clsCola();

            x.Codigo = Convert.ToInt32(txtNuevoCodigo.Text);
            x.Nombre = txtNuevoNombre.Text;
            x.Tramite = txtNuevoTramite.Text;

            c.Agregar(x);
            c.Recorrer(lstCola);
            c.RecorrerDgv(dgvCola);
        }
    }
}
