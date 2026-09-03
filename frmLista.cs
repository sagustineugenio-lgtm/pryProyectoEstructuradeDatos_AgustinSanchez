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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
            
        }

        clsListaSimple ListaSimple = new clsListaSimple();

        private void frmLista_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();

            Persona.Codigo = Convert.ToInt32(txtAgrCodigo.Text);
            Persona.Nombre = txtAgrNombre.Text;
            Persona.Tramite = txtAgrTramite.Text;

            ListaSimple.Agregar(Persona);
            LosRecorrer();
            limpiarTodo();
            
        }

       private void limpiarTodo()
        {
            txtAgrCodigo.Text = "";
            txtAgrNombre.Text = "";
            txtAgrTramite.Text = "";
            cmbCodElim.Text = "";
            LosRecorrer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(cmbCodElim.SelectedItem != null)
            {
                try
                {
                    ListaSimple.Eliminar(Convert.ToInt32(cmbCodElim.SelectedItem));
                    MessageBox.Show("Se Elimino Correctamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrió un Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún valor a eliminar");
            }
            limpiarTodo();
        }

        private void LosRecorrer()
        {
            ListaSimple.Recorrer(cmbCodElim);
            ListaSimple.Recorrer(dgvLista);
            ListaSimple.Recorrer(lstListaSimple);
        }

        private void lstListaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
