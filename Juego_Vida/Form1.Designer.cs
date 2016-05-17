namespace Juego_Vida
{
    partial class Juego_Vida
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tamaño_Celdas = new System.Windows.Forms.NumericUpDown();
            this.Elegir_Medida = new System.Windows.Forms.Button();
            this.MSJ_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tamaño_Celdas)).BeginInit();
            this.SuspendLayout();
            // 
            // Tamaño_Celdas
            // 
            this.Tamaño_Celdas.Location = new System.Drawing.Point(58, 96);
            this.Tamaño_Celdas.Name = "Tamaño_Celdas";
            this.Tamaño_Celdas.Size = new System.Drawing.Size(120, 20);
            this.Tamaño_Celdas.TabIndex = 1;
            this.Tamaño_Celdas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tamaño_Celdas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Tamaño_Celdas.ValueChanged += new System.EventHandler(this.Tamaño_Celdas_ValueChanged);
            // 
            // Elegir_Medida
            // 
            this.Elegir_Medida.Location = new System.Drawing.Point(77, 135);
            this.Elegir_Medida.Name = "Elegir_Medida";
            this.Elegir_Medida.Size = new System.Drawing.Size(75, 23);
            this.Elegir_Medida.TabIndex = 0;
            this.Elegir_Medida.Text = "Elegir";
            this.Elegir_Medida.UseVisualStyleBackColor = true;
            this.Elegir_Medida.Click += new System.EventHandler(this.Elegir_Medida_Click);
            // 
            // MSJ_1
            // 
            this.MSJ_1.AutoSize = true;
            this.MSJ_1.Location = new System.Drawing.Point(45, 64);
            this.MSJ_1.Name = "MSJ_1";
            this.MSJ_1.Size = new System.Drawing.Size(147, 13);
            this.MSJ_1.TabIndex = 2;
            this.MSJ_1.Text = "Elige el tamaño de las celdas.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reinicio (R)";
            // 
            // Juego_Vida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MSJ_1);
            this.Controls.Add(this.Elegir_Medida);
            this.Controls.Add(this.Tamaño_Celdas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Juego_Vida";
            this.Text = "Juego de la Vida";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Tamaño_Celdas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Tamaño_Celdas;
        private System.Windows.Forms.Button Elegir_Medida;
        private System.Windows.Forms.Label MSJ_1;
        private System.Windows.Forms.Label label1;
    }
}

