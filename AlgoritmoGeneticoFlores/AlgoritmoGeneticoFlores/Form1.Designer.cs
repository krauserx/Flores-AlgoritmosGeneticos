
namespace AlgoritmoGeneticoFlores
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
            this.components = new System.ComponentModel.Container();
            this.gbAltura = new System.Windows.Forms.GroupBox();
            this.rbBajo = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbAmarillo = new System.Windows.Forms.RadioButton();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.gbTamaño = new System.Windows.Forms.GroupBox();
            this.rbPequeno = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.lblGeneracion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbAltura.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.gbTamaño.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAltura
            // 
            this.gbAltura.Controls.Add(this.rbBajo);
            this.gbAltura.Controls.Add(this.rbMedio);
            this.gbAltura.Controls.Add(this.rbAlto);
            this.gbAltura.Location = new System.Drawing.Point(12, 12);
            this.gbAltura.Name = "gbAltura";
            this.gbAltura.Size = new System.Drawing.Size(174, 100);
            this.gbAltura.TabIndex = 0;
            this.gbAltura.TabStop = false;
            this.gbAltura.Text = "Altura";
            this.gbAltura.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbBajo
            // 
            this.rbBajo.AutoSize = true;
            this.rbBajo.Location = new System.Drawing.Point(7, 76);
            this.rbBajo.Name = "rbBajo";
            this.rbBajo.Size = new System.Drawing.Size(57, 21);
            this.rbBajo.TabIndex = 5;
            this.rbBajo.TabStop = true;
            this.rbBajo.Text = "Bajo";
            this.rbBajo.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(6, 48);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(67, 21);
            this.rbMedio.TabIndex = 4;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Medio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbAlto
            // 
            this.rbAlto.AutoSize = true;
            this.rbAlto.Location = new System.Drawing.Point(6, 21);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(53, 21);
            this.rbAlto.TabIndex = 3;
            this.rbAlto.TabStop = true;
            this.rbAlto.Text = "Alto";
            this.rbAlto.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbAzul);
            this.gbColor.Controls.Add(this.rbAmarillo);
            this.gbColor.Controls.Add(this.rbRojo);
            this.gbColor.Location = new System.Drawing.Point(192, 12);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(200, 100);
            this.gbColor.TabIndex = 1;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color de flor";
            // 
            // rbAzul
            // 
            this.rbAzul.AutoSize = true;
            this.rbAzul.Location = new System.Drawing.Point(7, 73);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(56, 21);
            this.rbAzul.TabIndex = 2;
            this.rbAzul.TabStop = true;
            this.rbAzul.Text = "Azul";
            this.rbAzul.UseVisualStyleBackColor = true;
            // 
            // rbAmarillo
            // 
            this.rbAmarillo.AutoSize = true;
            this.rbAmarillo.Location = new System.Drawing.Point(7, 48);
            this.rbAmarillo.Name = "rbAmarillo";
            this.rbAmarillo.Size = new System.Drawing.Size(79, 21);
            this.rbAmarillo.TabIndex = 1;
            this.rbAmarillo.TabStop = true;
            this.rbAmarillo.Text = "Amarillo";
            this.rbAmarillo.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Location = new System.Drawing.Point(7, 22);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(58, 21);
            this.rbRojo.TabIndex = 0;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // gbTamaño
            // 
            this.gbTamaño.Controls.Add(this.rbPequeno);
            this.gbTamaño.Controls.Add(this.rbNormal);
            this.gbTamaño.Controls.Add(this.rbGrande);
            this.gbTamaño.Location = new System.Drawing.Point(398, 12);
            this.gbTamaño.Name = "gbTamaño";
            this.gbTamaño.Size = new System.Drawing.Size(200, 100);
            this.gbTamaño.TabIndex = 2;
            this.gbTamaño.TabStop = false;
            this.gbTamaño.Text = "Tamaño de flor";
            // 
            // rbPequeno
            // 
            this.rbPequeno.AutoSize = true;
            this.rbPequeno.Location = new System.Drawing.Point(7, 76);
            this.rbPequeno.Name = "rbPequeno";
            this.rbPequeno.Size = new System.Drawing.Size(86, 21);
            this.rbPequeno.TabIndex = 2;
            this.rbPequeno.TabStop = true;
            this.rbPequeno.Text = "Pequeño";
            this.rbPequeno.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(7, 48);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(83, 21);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Mediano";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(7, 21);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(77, 21);
            this.rbGrande.TabIndex = 0;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // lblGeneracion
            // 
            this.lblGeneracion.AutoSize = true;
            this.lblGeneracion.Location = new System.Drawing.Point(12, 116);
            this.lblGeneracion.Name = "lblGeneracion";
            this.lblGeneracion.Size = new System.Drawing.Size(101, 17);
            this.lblGeneracion.TabIndex = 3;
            this.lblGeneracion.Text = "Generaciones:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 624);
            this.Controls.Add(this.lblGeneracion);
            this.Controls.Add(this.gbTamaño);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.gbAltura.ResumeLayout(false);
            this.gbAltura.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbTamaño.ResumeLayout(false);
            this.gbTamaño.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAltura;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.GroupBox gbTamaño;
        private System.Windows.Forms.RadioButton rbBajo;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbAlto;
        private System.Windows.Forms.RadioButton rbAzul;
        private System.Windows.Forms.RadioButton rbAmarillo;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbPequeno;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.Label lblGeneracion;
        private System.Windows.Forms.Timer timer1;
    }
}

