namespace ejercicio11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "cantidad";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(291, 65);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 26);
            this.txtprecio.TabIndex = 2;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(291, 173);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 26);
            this.txtcantidad.TabIndex = 3;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(521, 82);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(323, 117);
            this.txtresultado.TabIndex = 4;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(402, 107);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(99, 45);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 607);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncalcular;
    }
}

