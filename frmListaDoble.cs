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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble ListaDoble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();

            Persona.Codigo = Convert.ToInt32(txtAgrCodigo.Text);
            Persona.Nombre = txtAgrNombre.Text;
            Persona.Tramite = txtAgrTramite.Text;

            ListaDoble.Agregar(Persona);
            LosRecorrer();
            limpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodEliminar.SelectedItem != null)
            {
                try
                {
                    ListaDoble.Eliminar(Convert.ToInt32(cmbCodEliminar.SelectedItem));
                    MessageBox.Show("Se Elimino Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un código para eliminar.");
            }
        }

        private void LosRecorrer()
        {
            ListaDoble.RecorrerAsc(dgvListaDoble);
            ListaDoble.RecorrerDesc(dgvListaDoble);
            ListaDoble.RecorrerAsc(lstListaDoble);
            ListaDoble.RecorrerDesc(lstListaDoble);
        }

        private void limpiarTodo()
        {
            txtAgrCodigo.Text = "";
            txtAgrNombre.Text = "";
            txtAgrTramite.Text = "";
            cmbCodEliminar.Text = "";
            LosRecorrer();
        }

    }
}
