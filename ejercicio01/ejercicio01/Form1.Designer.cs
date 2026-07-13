namespace ejercicio01
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
            this.Txthoras = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttarifa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "horas trabajadas";
            // 
            // Txthoras
            // 
            this.Txthoras.Location = new System.Drawing.Point(171, 24);
            this.Txthoras.Name = "Txthoras";
            this.Txthoras.Size = new System.Drawing.Size(100, 26);
            this.Txthoras.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(304, 40);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(91, 37);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(415, 41);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(238, 26);
            this.txtresultado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "tarifa por hora";
            // 
            // txttarifa
            // 
            this.txttarifa.Location = new System.Drawing.Point(171, 63);
            this.txttarifa.Name = "txttarifa";
            this.txttarifa.Size = new System.Drawing.Size(100, 26);
            this.txttarifa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttarifa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.Txthoras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txthoras;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttarifa;
    }
}

