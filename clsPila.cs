using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    internal class clsPila
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero { get => primero; set => primero = value; }
        public clsNodo Ultimo { get => ultimo; set => ultimo = value; }

        public void AgregarPila(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.siguiente = Primero;
                Primero = Nuevo;
            }
        }

        public void Eliminar(clsNodo Nuevo)
        {
            if (Primero != null)
            {
                Primero = Primero.siguiente;
            }
        }

        public void Recorrer(ListBox lstPila)
        {
            clsNodo aux = Primero;
            lstPila.Items.Clear();
            while (aux != null)
            {
                lstPila.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }

        }

        public void RecorrerDgv(DataGridView dgvPila)
        {
            clsNodo aux = primero;
            dgvPila.Rows.Clear();
            while (aux != null)
            {
                dgvPila.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                    );

                aux = aux.siguiente;
            }
        }

    }
}
