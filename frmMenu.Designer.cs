namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.msEstrucLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.msEstrucNoLineales = new System.Windows.Forms.ToolStripMenuItem();
            this.msBasedeDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.msDatosdelDesarrollador = new System.Windows.Forms.ToolStripMenuItem();
            this.msSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msCola = new System.Windows.Forms.ToolStripMenuItem();
            this.msPila = new System.Windows.Forms.ToolStripMenuItem();
            this.msListaEntraSimple = new System.Windows.Forms.ToolStripMenuItem();
            this.msListaDobleEnlazada = new System.Windows.Forms.ToolStripMenuItem();
            this.msArbolBinario = new System.Windows.Forms.ToolStripMenuItem();
            this.msGrafos = new System.Windows.Forms.ToolStripMenuItem();
            this.msMostrarTabla = new System.Windows.Forms.ToolStripMenuItem();
            this.msConsultaBaseDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.msOperacionesBaseDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.msConsultasOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSistema,
            this.msEstrucLineales,
            this.msEstrucNoLineales,
            this.msBasedeDatos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msSistema
            // 
            this.msSistema.BackColor = System.Drawing.SystemColors.ControlDark;
            this.msSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDatosdelDesarrollador,
            this.msSalir});
            this.msSistema.Name = "msSistema";
            this.msSistema.Size = new System.Drawing.Size(60, 20);
            this.msSistema.Text = "Sistema";
            // 
            // msEstrucLineales
            // 
            this.msEstrucLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCola,
            this.msPila,
            this.msListaEntraSimple,
            this.msListaDobleEnlazada});
            this.msEstrucLineales.Name = "msEstrucLineales";
            this.msEstrucLineales.Size = new System.Drawing.Size(122, 20);
            this.msEstrucLineales.Text = "Estructuras Lineales";
            // 
            // msEstrucNoLineales
            // 
            this.msEstrucNoLineales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArbolBinario,
            this.msGrafos});
            this.msEstrucNoLineales.Name = "msEstrucNoLineales";
            this.msEstrucNoLineales.Size = new System.Drawing.Size(141, 20);
            this.msEstrucNoLineales.Text = "Estructuras No Lineales";
            // 
            // msBasedeDatos
            // 
            this.msBasedeDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMostrarTabla,
            this.msConsultaBaseDatos,
            this.msOperacionesBaseDatos,
            this.msConsultasOperaciones});
            this.msBasedeDatos.Name = "msBasedeDatos";
            this.msBasedeDatos.Size = new System.Drawing.Size(92, 20);
            this.msBasedeDatos.Text = "Base de Datos";
            // 
            // msDatosdelDesarrollador
            // 
            this.msDatosdelDesarrollador.Name = "msDatosdelDesarrollador";
            this.msDatosdelDesarrollador.Size = new System.Drawing.Size(196, 22);
            this.msDatosdelDesarrollador.Text = "Datos del Desarrollador";
            // 
            // msSalir
            // 
            this.msSalir.Name = "msSalir";
            this.msSalir.Size = new System.Drawing.Size(196, 22);
            this.msSalir.Text = "Salir";
            // 
            // msCola
            // 
            this.msCola.Name = "msCola";
            this.msCola.Size = new System.Drawing.Size(215, 22);
            this.msCola.Text = "Cola";
            this.msCola.Click += new System.EventHandler(this.msCola_Click);
            // 
            // msPila
            // 
            this.msPila.Name = "msPila";
            this.msPila.Size = new System.Drawing.Size(215, 22);
            this.msPila.Text = "Pila";
            // 
            // msListaEntraSimple
            // 
            this.msListaEntraSimple.Name = "msListaEntraSimple";
            this.msListaEntraSimple.Size = new System.Drawing.Size(215, 22);
            this.msListaEntraSimple.Text = "Lista Entrada Simple";
            // 
            // msListaDobleEnlazada
            // 
            this.msListaDobleEnlazada.Name = "msListaDobleEnlazada";
            this.msListaDobleEnlazada.Size = new System.Drawing.Size(215, 22);
            this.msListaDobleEnlazada.Text = "Lista Doblemente Enlazada";
            // 
            // msArbolBinario
            // 
            this.msArbolBinario.Name = "msArbolBinario";
            this.msArbolBinario.Size = new System.Drawing.Size(214, 22);
            this.msArbolBinario.Text = "Arbol Binario de Búsqueda";
            // 
            // msGrafos
            // 
            this.msGrafos.Name = "msGrafos";
            this.msGrafos.Size = new System.Drawing.Size(214, 22);
            this.msGrafos.Text = "Grafos";
            // 
            // msMostrarTabla
            // 
            this.msMostrarTabla.Name = "msMostrarTabla";
            this.msMostrarTabla.Size = new System.Drawing.Size(246, 22);
            this.msMostrarTabla.Text = "Mostrar una Tabla";
            // 
            // msConsultaBaseDatos
            // 
            this.msConsultaBaseDatos.Name = "msConsultaBaseDatos";
            this.msConsultaBaseDatos.Size = new System.Drawing.Size(246, 22);
            this.msConsultaBaseDatos.Text = "Consulta una Base de Datos";
            // 
            // msOperacionesBaseDatos
            // 
            this.msOperacionesBaseDatos.Name = "msOperacionesBaseDatos";
            this.msOperacionesBaseDatos.Size = new System.Drawing.Size(246, 22);
            this.msOperacionesBaseDatos.Text = "Operaciones en Base de Datos";
            // 
            // msConsultasOperaciones
            // 
            this.msConsultasOperaciones.Name = "msConsultasOperaciones";
            this.msConsultasOperaciones.Size = new System.Drawing.Size(246, 22);
            this.msConsultasOperaciones.Text = "Consulta Varias con Operaciones";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msSistema;
        private System.Windows.Forms.ToolStripMenuItem msEstrucLineales;
        private System.Windows.Forms.ToolStripMenuItem msEstrucNoLineales;
        private System.Windows.Forms.ToolStripMenuItem msBasedeDatos;
        private System.Windows.Forms.ToolStripMenuItem msDatosdelDesarrollador;
        private System.Windows.Forms.ToolStripMenuItem msSalir;
        private System.Windows.Forms.ToolStripMenuItem msCola;
        private System.Windows.Forms.ToolStripMenuItem msPila;
        private System.Windows.Forms.ToolStripMenuItem msListaEntraSimple;
        private System.Windows.Forms.ToolStripMenuItem msListaDobleEnlazada;
        private System.Windows.Forms.ToolStripMenuItem msArbolBinario;
        private System.Windows.Forms.ToolStripMenuItem msGrafos;
        private System.Windows.Forms.ToolStripMenuItem msMostrarTabla;
        private System.Windows.Forms.ToolStripMenuItem msConsultaBaseDatos;
        private System.Windows.Forms.ToolStripMenuItem msOperacionesBaseDatos;
        private System.Windows.Forms.ToolStripMenuItem msConsultasOperaciones;
    }
}

