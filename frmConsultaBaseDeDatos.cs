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
    public partial class frmConsultaBaseDeDatos : Form
    {
        public frmConsultaBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos BD = new clsBaseDeDatos();
            DataSet datos = BD.Listar(lstBaseDatos.Text);
            if (datos.Tables.Count > 0)
            {
                dgvBaseDatos.DataSource = datos.Tables[0];
            }
        }
    }
}
