namespace Fundamentos
{
    partial class Form20TemperaturasAnualesClases
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarTemperaturas = new System.Windows.Forms.Button();
            this.cmbAños = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbDatosAnuales = new System.Windows.Forms.GroupBox();
            this.gpbDatosMes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperaturaMaxima = new System.Windows.Forms.TextBox();
            this.txtTemperaturaMinima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTemperaturaMediaMensual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbDatosAnuales.SuspendLayout();
            this.gpbDatosMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 15;
            this.lstMeses.Location = new System.Drawing.Point(37, 125);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(175, 229);
            this.lstMeses.TabIndex = 9;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Meses";
            // 
            // btnGenerarTemperaturas
            // 
            this.btnGenerarTemperaturas.Location = new System.Drawing.Point(274, 65);
            this.btnGenerarTemperaturas.Name = "btnGenerarTemperaturas";
            this.btnGenerarTemperaturas.Size = new System.Drawing.Size(216, 38);
            this.btnGenerarTemperaturas.TabIndex = 10;
            this.btnGenerarTemperaturas.Text = "Generar Temperaturas";
            this.btnGenerarTemperaturas.UseVisualStyleBackColor = true;
            this.btnGenerarTemperaturas.Click += new System.EventHandler(this.btnGenerarTemperaturas_Click);
            // 
            // cmbAños
            // 
            this.cmbAños.FormattingEnabled = true;
            this.cmbAños.Location = new System.Drawing.Point(37, 66);
            this.cmbAños.Name = "cmbAños";
            this.cmbAños.Size = new System.Drawing.Size(121, 23);
            this.cmbAños.TabIndex = 11;
            this.cmbAños.SelectedIndexChanged += new System.EventHandler(this.cmbAños_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Años";
            // 
            // gpbDatosAnuales
            // 
            this.gpbDatosAnuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpbDatosAnuales.Controls.Add(this.txtMediaAnual);
            this.gpbDatosAnuales.Controls.Add(this.label6);
            this.gpbDatosAnuales.Controls.Add(this.txtMinima);
            this.gpbDatosAnuales.Controls.Add(this.label7);
            this.gpbDatosAnuales.Controls.Add(this.txtMaxima);
            this.gpbDatosAnuales.Controls.Add(this.label8);
            this.gpbDatosAnuales.Location = new System.Drawing.Point(427, 151);
            this.gpbDatosAnuales.Name = "gpbDatosAnuales";
            this.gpbDatosAnuales.Size = new System.Drawing.Size(187, 203);
            this.gpbDatosAnuales.TabIndex = 13;
            this.gpbDatosAnuales.TabStop = false;
            this.gpbDatosAnuales.Text = "Datos Anuales";
            // 
            // gpbDatosMes
            // 
            this.gpbDatosMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gpbDatosMes.Controls.Add(this.txtTemperaturaMediaMensual);
            this.gpbDatosMes.Controls.Add(this.label5);
            this.gpbDatosMes.Controls.Add(this.txtTemperaturaMinima);
            this.gpbDatosMes.Controls.Add(this.label4);
            this.gpbDatosMes.Controls.Add(this.txtTemperaturaMaxima);
            this.gpbDatosMes.Controls.Add(this.label3);
            this.gpbDatosMes.Location = new System.Drawing.Point(238, 151);
            this.gpbDatosMes.Name = "gpbDatosMes";
            this.gpbDatosMes.Size = new System.Drawing.Size(187, 203);
            this.gpbDatosMes.TabIndex = 14;
            this.gpbDatosMes.TabStop = false;
            this.gpbDatosMes.Text = "Datos del mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Temperatura máxima";
            // 
            // txtTemperaturaMaxima
            // 
            this.txtTemperaturaMaxima.Location = new System.Drawing.Point(24, 47);
            this.txtTemperaturaMaxima.Name = "txtTemperaturaMaxima";
            this.txtTemperaturaMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMaxima.TabIndex = 1;
            // 
            // txtTemperaturaMinima
            // 
            this.txtTemperaturaMinima.Location = new System.Drawing.Point(24, 107);
            this.txtTemperaturaMinima.Name = "txtTemperaturaMinima";
            this.txtTemperaturaMinima.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMinima.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Temperatura mínima";
            // 
            // txtTemperaturaMediaMensual
            // 
            this.txtTemperaturaMediaMensual.Location = new System.Drawing.Point(24, 158);
            this.txtTemperaturaMediaMensual.Name = "txtTemperaturaMediaMensual";
            this.txtTemperaturaMediaMensual.Size = new System.Drawing.Size(100, 23);
            this.txtTemperaturaMediaMensual.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Temperatura media mensual";
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Location = new System.Drawing.Point(31, 154);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(100, 23);
            this.txtMediaAnual.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Media Anual";
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(31, 103);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(100, 23);
            this.txtMinima.TabIndex = 9;
            this.txtMinima.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mínima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(31, 43);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(100, 23);
            this.txtMaxima.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Máxima";
            // 
            // Form20TemperaturasAnualesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 386);
            this.Controls.Add(this.gpbDatosAnuales);
            this.Controls.Add(this.gpbDatosMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAños);
            this.Controls.Add(this.btnGenerarTemperaturas);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Name = "Form20TemperaturasAnualesClases";
            this.Text = "Form20TemperaturasAnualesClases";
            this.gpbDatosAnuales.ResumeLayout(false);
            this.gpbDatosAnuales.PerformLayout();
            this.gpbDatosMes.ResumeLayout(false);
            this.gpbDatosMes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstMeses;
        private Label label1;
        private Button btnGenerarTemperaturas;
        private ComboBox cmbAños;
        private Label label2;
        private GroupBox gpbDatosAnuales;
        private TextBox txtMediaAnual;
        private Label label6;
        private TextBox txtMinima;
        private Label label7;
        private TextBox txtMaxima;
        private Label label8;
        private GroupBox gpbDatosMes;
        private TextBox txtTemperaturaMediaMensual;
        private Label label5;
        private TextBox txtTemperaturaMinima;
        private Label label4;
        private TextBox txtTemperaturaMaxima;
        private Label label3;
    }
}