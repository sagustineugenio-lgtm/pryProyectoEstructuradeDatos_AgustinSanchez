using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    internal class clsCola
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero { get => primero; set => primero = value; }
        public clsNodo Ultimo { get => ultimo; set => ultimo = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero==null)
            {
                Primero=Nuevo;
                Ultimo=Nuevo;
            }
            else
            {
                Ultimo.siguiente=Nuevo;
                Ultimo=Nuevo;
            }
        }

        public void Recorrer(ListBox lstCola)
        {
            clsNodo aux=Primero;

            while(aux!=null)
            {
                lstCola.Items.Add(aux.Codigo);
                aux=aux.siguiente;
            }
        }

        public void RecorrerDgv(DataGridView dgvCola)
        {
            clsNodo aux = primero;

            while (aux != null)
            {
                dgvCola.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                    );

                aux = aux.siguiente;
            }
        }
       
    }
    

}
