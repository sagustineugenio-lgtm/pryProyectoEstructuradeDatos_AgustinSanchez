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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT Titulo FROM Libro");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT Titulo, Precio FROM Libro");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdAutor = 2");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdPais = 3 AND IdAutor = 9");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnSeleccionPorConvolucion_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdAutor = 2 UNION SELECT * FROM Libro WHERE IdAutor = 5 UNION SELECT * FROM Libro WHERE IdAutor = 3");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdAutor > 10 AND IdLibro IN (SELECT IdLibro FROM Libro WHERE IdIdioma > 8)");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar("SELECT * FROM Libro WHERE IdIdioma NOT IN (SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)");
            if (datos.Tables.Count > 0)
            {
                dgvMostrar.DataSource = datos.Tables[0];
            }

        }
    }
}
