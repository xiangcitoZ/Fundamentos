namespace Fundamentos
{
    partial class Form06DiaNacimiento
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(147, 53);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 23);
            this.txtDia.TabIndex = 0;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(147, 99);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 23);
            this.txtMes.TabIndex = 1;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(147, 155);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 23);
            this.txtAno.TabIndex = 2;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(44, 60);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(24, 15);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Dia";
            this.lblDia.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(44, 102);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(44, 163);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 15);
            this.lblAño.TabIndex = 5;
            this.lblAño.Text = "Año";
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(165, 224);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(38, 15);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "label4";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(289, 122);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(131, 32);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular día";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form06DiaNacimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Name = "Form06DiaNacimiento";
            this.Text = "Form06DiaNacimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAno;
        private Label lblDia;
        private Label lblMes;
        private Label lblAño;
        private Label txtResultado;
        private Button btnCalcular;
    }
}