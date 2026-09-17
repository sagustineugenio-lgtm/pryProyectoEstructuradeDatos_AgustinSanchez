using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero { get => pri; set => pri = value; }
        public clsNodo Ultimo { get => ult; set => ult = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo > Primero.Codigo)
                {
                    Nuevo.Sig = Primero;
                    Primero.Ant = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo < Ultimo.Codigo)
                    {
                        Ultimo.Sig = Nuevo;
                        Nuevo.Ant = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = aux.Ant;
                        while (aux.Codigo < Nuevo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Sig;
                        }
                        ant.Sig = Nuevo;
                        Nuevo.Sig = aux;
                        aux.Ant = Nuevo;
                        Nuevo.Sig = ant;
                    }
                }
            }
        }

        public void Eliminar(Int32 codigo)
        {
            if (Primero.Codigo == codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.Codigo == codigo)
                {
                    Primero = Primero.Sig;
                    Primero.Ant = null;
                }
                else
                {
                    if (Ultimo.Codigo == codigo)
                    {
                        Ultimo = Ultimo.Ant;
                        Ultimo.Sig = null;
                    }
                    else
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < codigo)
                        {
                            ant = aux;
                            aux = aux.Sig;
                        }
                        ant.Sig = aux.Sig;
                        aux = aux.Sig;
                        aux.Ant = ant;
                    }
                }
            }
        }

        public void RecorrerAsc(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Sig;
            }
        }

        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Ant;
            }
        }

        public void RecorrerAsc(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Sig;
            }
        }

        public void RecorrerDesc(ListBox Lista)
        {
            clsNodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " - " + aux.Nombre + " - " + aux.Tramite);
                aux = aux.Ant;
            }
        }
    }
}
