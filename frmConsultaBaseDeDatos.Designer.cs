namespace pryProyectoEstructuradeDatos_AgustinSanchez
{
    partial class frmConsultaBaseDeDatos
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
            this.lstBaseDatos = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBaseDatos
            // 
            this.lstBaseDatos.FormattingEnabled = true;
            this.lstBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.lstBaseDatos.Name = "lstBaseDatos";
            this.lstBaseDatos.Size = new System.Drawing.Size(776, 199);
            this.lstBaseDatos.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(703, 228);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 257);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(776, 212);
            this.dgvBaseDatos.TabIndex = 2;
            // 
            // frmConsultaBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.dgvBaseDatos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstBaseDatos);
            this.Name = "frmConsultaBaseDeDatos";
            this.Text = "frmConsultaBaseDeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBaseDatos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvBaseDatos;
    }
}