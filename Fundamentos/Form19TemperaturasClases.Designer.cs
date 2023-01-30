namespace Fundamentos
{
    partial class Form19TemperaturasClases
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.btnGenerarTemperaturas = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tmeperatura máxima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(275, 199);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtMaxima.TabIndex = 2;
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(275, 254);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(100, 23);
            this.txtMinima.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempearatura mínima";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(273, 309);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 23);
            this.txtMedia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Temperatura media";
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(45, 103);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(175, 229);
            this.lstMeses.TabIndex = 7;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged_1);
            // 
            // btnGenerarTemperaturas
            // 
            this.btnGenerarTemperaturas.Location = new System.Drawing.Point(275, 57);
            this.btnGenerarTemperaturas.Name = "btnGenerarTemperaturas";
            this.btnGenerarTemperaturas.Size = new System.Drawing.Size(155, 31);
            this.btnGenerarTemperaturas.TabIndex = 8;
            this.btnGenerarTemperaturas.Text = "Generar temperaturas";
            this.btnGenerarTemperaturas.UseVisualStyleBackColor = true;
            this.btnGenerarTemperaturas.Click += new System.EventHandler(this.btnGenerarTemperaturas_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(275, 103);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(155, 31);
            this.btnMostrarDatos.TabIndex = 9;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // Form19TemperaturasClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 400);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerarTemperaturas);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form19TemperaturasClases";
            this.Text = "Form19TemperaturasClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtMaxima;
        private TextBox txtMinima;
        private Label label3;
        private TextBox txtMedia;
        private Label label4;
        private ListBox lstMeses;
        private Button btnGenerarTemperaturas;
        private Button btnMostrarDatos;
    }
}