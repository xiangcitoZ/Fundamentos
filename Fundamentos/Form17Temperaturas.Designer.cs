namespace Fundamentos
{
    partial class Form17Temperaturas
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.txtTemperaturaMedia = new System.Windows.Forms.TextBox();
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(249, 77);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(124, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar meses";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(249, 113);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempearatura máxima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tempeartura minima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Media anual";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(249, 177);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMaxima.TabIndex = 7;
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(249, 253);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMinima.TabIndex = 8;
            // 
            // txtTemperaturaMedia
            // 
            this.txtTemperaturaMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperaturaMedia.Location = new System.Drawing.Point(249, 317);
            this.txtTemperaturaMedia.Name = "txtTemperaturaMedia";
            this.txtTemperaturaMedia.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMedia.TabIndex = 9;
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(40, 127);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(127, 229);
            this.lstMeses.TabIndex = 10;
            // 
            // Form17Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 423);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.txtTemperaturaMedia);
            this.Controls.Add(this.txtTemperaturaMinima);
            this.Controls.Add(this.txtTemperaturaMaxima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label1);
            this.Name = "Form17Temperaturas";
            this.Text = "Form17Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTemperaturaMaxima;
        private TextBox txtTemperaturaMinima;
        private TextBox txtTemperaturaMedia;
        private ListBox lstMeses;
    }
}