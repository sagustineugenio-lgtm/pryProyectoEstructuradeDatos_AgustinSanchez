using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    public class clsNodo
    {
        private int codigo;
        private string nombre;
        private string tramite;
        private clsNodo sig;
        private clsNodo ant;

        public clsNodo siguiente;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tramite { get => tramite; set => tramite = value; }
        public clsNodo Sig { get => sig; set => sig = value; }
        public clsNodo Ant { get => ant; set => ant = value; }

        public clsNodo anterior;
    }
}
