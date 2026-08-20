namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    partial class frmCola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevoTramite = new System.Windows.Forms.TextBox();
            this.txtNuevoCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEliminarElemento = new System.Windows.Forms.GroupBox();
            this.txtEliminarNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarTramite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEliminarCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbNuevoElemento.SuspendLayout();
            this.gbEliminarElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtNuevoNombre);
            this.gbNuevoElemento.Controls.Add(this.txtNuevoTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNuevoCodigo);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.label3);
            this.gbNuevoElemento.Controls.Add(this.label2);
            this.gbNuevoElemento.Controls.Add(this.label1);
            this.gbNuevoElemento.Location = new System.Drawing.Point(10, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(234, 166);
            this.gbNuevoElemento.TabIndex = 0;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(104, 54);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNuevoNombre.TabIndex = 6;
            // 
            // txtNuevoTramite
            // 
            this.txtNuevoTramite.Location = new System.Drawing.Point(104, 83);
            this.txtNuevoTramite.Name = "txtNuevoTramite";
            this.txtNuevoTramite.Size = new System.Drawing.Size(120, 20);
            this.txtNuevoTramite.TabIndex = 5;
            // 
            // txtNuevoCodigo
            // 
            this.txtNuevoCodigo.Location = new System.Drawing.Point(104, 26);
            this.txtNuevoCodigo.Name = "txtNuevoCodigo";
            this.txtNuevoCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtNuevoCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(104, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tramite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // gbEliminarElemento
            // 
            this.gbEliminarElemento.Controls.Add(this.txtEliminarNombre);
            this.gbEliminarElemento.Controls.Add(this.btnEliminar);
            this.gbEliminarElemento.Controls.Add(this.txtEliminarTramite);
            this.gbEliminarElemento.Controls.Add(this.label6);
            this.gbEliminarElemento.Controls.Add(this.txtEliminarCodigo);
            this.gbEliminarElemento.Controls.Add(this.label4);
            this.gbEliminarElemento.Controls.Add(this.label5);
            this.gbEliminarElemento.Location = new System.Drawing.Point(265, 12);
            this.gbEliminarElemento.Name = "gbEliminarElemento";
            this.gbEliminarElemento.Size = new System.Drawing.Size(234, 166);
            this.gbEliminarElemento.TabIndex = 1;
            this.gbEliminarElemento.TabStop = false;
            this.gbEliminarElemento.Text = "Elemento a Eliminar";
            // 
            // txtEliminarNombre
            // 
            this.txtEliminarNombre.Location = new System.Drawing.Point(109, 54);
            this.txtEliminarNombre.Name = "txtEliminarNombre";
            this.txtEliminarNombre.Size = new System.Drawing.Size(120, 20);
            this.txtEliminarNombre.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(109, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminarTramite
            // 
            this.txtEliminarTramite.Location = new System.Drawing.Point(109, 83);
            this.txtEliminarTramite.Name = "txtEliminarTramite";
            this.txtEliminarTramite.Size = new System.Drawing.Size(120, 20);
            this.txtEliminarTramite.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Codigo:";
            // 
            // txtEliminarCodigo
            // 
            this.txtEliminarCodigo.Location = new System.Drawing.Point(109, 26);
            this.txtEliminarCodigo.Name = "txtEliminarCodigo";
            this.txtEliminarCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtEliminarCodigo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tramite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Listado en una Lista y en una Grilla";
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(10, 239);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(234, 160);
            this.lstCola.TabIndex = 3;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(265, 239);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(344, 160);
            this.dgvCola.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbEliminarElemento);
            this.Controls.Add(this.gbNuevoElemento);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbEliminarElemento.ResumeLayout(false);
            this.gbEliminarElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbEliminarElemento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevoTramite;
        private System.Windows.Forms.TextBox txtNuevoCodigo;
        private System.Windows.Forms.TextBox txtEliminarNombre;
        private System.Windows.Forms.TextBox txtEliminarTramite;
        private System.Windows.Forms.TextBox txtEliminarCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}