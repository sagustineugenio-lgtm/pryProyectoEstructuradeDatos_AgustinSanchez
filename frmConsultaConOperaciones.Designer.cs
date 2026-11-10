namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    partial class frmConsultaConOperaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsultaOperaciones = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstConsulta = new System.Windows.Forms.ListBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacion a Realizar";
            // 
            // cmbConsultaOperaciones
            // 
            this.cmbConsultaOperaciones.FormattingEnabled = true;
            this.cmbConsultaOperaciones.Items.AddRange(new object[] {
            "Proyeccion Simple",
            "Proyeccion  Multiatributo",
            "Juntar",
            "Seleccion Simple",
            "Seleccion Multiatributo",
            "Seleccion por Convolucion",
            "Union",
            "Interseccion",
            "Diferencia"});
            this.cmbConsultaOperaciones.Location = new System.Drawing.Point(191, 1);
            this.cmbConsultaOperaciones.Name = "cmbConsultaOperaciones";
            this.cmbConsultaOperaciones.Size = new System.Drawing.Size(418, 21);
            this.cmbConsultaOperaciones.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(677, 1);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(111, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lstConsulta
            // 
            this.lstConsulta.FormattingEnabled = true;
            this.lstConsulta.Location = new System.Drawing.Point(13, 44);
            this.lstConsulta.Name = "lstConsulta";
            this.lstConsulta.Size = new System.Drawing.Size(775, 134);
            this.lstConsulta.TabIndex = 3;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(15, 194);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(773, 244);
            this.dgvMostrar.TabIndex = 4;
            // 
            // frmConsultaConOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lstConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cmbConsultaOperaciones);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaConOperaciones";
            this.Text = "frmConsultaConOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsultaOperaciones;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstConsulta;
        private System.Windows.Forms.DataGridView dgvMostrar;
    }
}