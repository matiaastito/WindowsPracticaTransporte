namespace WindowsTripulacion
{
    partial class frmTripulacion
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
            this.btnAgregarAzafata = new System.Windows.Forms.Button();
            this.btnQuitarAzafata = new System.Windows.Forms.Button();
            this.btnCrearJet = new System.Windows.Forms.Button();
            this.gridAzafatas = new System.Windows.Forms.DataGridView();
            this.btnAgregarHelicoptero = new System.Windows.Forms.Button();
            this.btnMostrarListaAzafatas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAzafatas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAzafata
            // 
            this.btnAgregarAzafata.Location = new System.Drawing.Point(30, 27);
            this.btnAgregarAzafata.Name = "btnAgregarAzafata";
            this.btnAgregarAzafata.Size = new System.Drawing.Size(126, 23);
            this.btnAgregarAzafata.TabIndex = 1;
            this.btnAgregarAzafata.Text = "Agregar Azafata";
            this.btnAgregarAzafata.UseVisualStyleBackColor = true;
            this.btnAgregarAzafata.Click += new System.EventHandler(this.btnAgregarAzafata_Click);
            // 
            // btnQuitarAzafata
            // 
            this.btnQuitarAzafata.Location = new System.Drawing.Point(30, 71);
            this.btnQuitarAzafata.Name = "btnQuitarAzafata";
            this.btnQuitarAzafata.Size = new System.Drawing.Size(126, 25);
            this.btnQuitarAzafata.TabIndex = 2;
            this.btnQuitarAzafata.Text = "Quitar Azafata";
            this.btnQuitarAzafata.UseVisualStyleBackColor = true;
            this.btnQuitarAzafata.Click += new System.EventHandler(this.btnQuitarAzafata_Click);
            // 
            // btnCrearJet
            // 
            this.btnCrearJet.Location = new System.Drawing.Point(322, 27);
            this.btnCrearJet.Name = "btnCrearJet";
            this.btnCrearJet.Size = new System.Drawing.Size(124, 23);
            this.btnCrearJet.TabIndex = 3;
            this.btnCrearJet.Text = "Agregar Jet";
            this.btnCrearJet.UseVisualStyleBackColor = true;
            this.btnCrearJet.Click += new System.EventHandler(this.btnCrearJet_Click);
            // 
            // gridAzafatas
            // 
            this.gridAzafatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAzafatas.Location = new System.Drawing.Point(30, 228);
            this.gridAzafatas.Name = "gridAzafatas";
            this.gridAzafatas.Size = new System.Drawing.Size(718, 150);
            this.gridAzafatas.TabIndex = 4;
            // 
            // btnAgregarHelicoptero
            // 
            this.btnAgregarHelicoptero.Location = new System.Drawing.Point(640, 27);
            this.btnAgregarHelicoptero.Name = "btnAgregarHelicoptero";
            this.btnAgregarHelicoptero.Size = new System.Drawing.Size(124, 23);
            this.btnAgregarHelicoptero.TabIndex = 5;
            this.btnAgregarHelicoptero.Text = "Agregar Helicoptero";
            this.btnAgregarHelicoptero.UseVisualStyleBackColor = true;
            this.btnAgregarHelicoptero.Click += new System.EventHandler(this.btnAgregarHelicoptero_Click);
            // 
            // btnMostrarListaAzafatas
            // 
            this.btnMostrarListaAzafatas.Location = new System.Drawing.Point(347, 384);
            this.btnMostrarListaAzafatas.Name = "btnMostrarListaAzafatas";
            this.btnMostrarListaAzafatas.Size = new System.Drawing.Size(90, 41);
            this.btnMostrarListaAzafatas.TabIndex = 6;
            this.btnMostrarListaAzafatas.Text = "Mostrar Lista Azafatas";
            this.btnMostrarListaAzafatas.UseVisualStyleBackColor = true;
            this.btnMostrarListaAzafatas.Click += new System.EventHandler(this.btnMostrarListaAzafatas_Click);
            // 
            // frmTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarListaAzafatas);
            this.Controls.Add(this.btnAgregarHelicoptero);
            this.Controls.Add(this.gridAzafatas);
            this.Controls.Add(this.btnCrearJet);
            this.Controls.Add(this.btnQuitarAzafata);
            this.Controls.Add(this.btnAgregarAzafata);
            this.Name = "frmTripulacion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridAzafatas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarAzafata;
        private System.Windows.Forms.Button btnQuitarAzafata;
        private System.Windows.Forms.Button btnCrearJet;
        private System.Windows.Forms.DataGridView gridAzafatas;
        private System.Windows.Forms.Button btnAgregarHelicoptero;
        private System.Windows.Forms.Button btnMostrarListaAzafatas;
    }
}

