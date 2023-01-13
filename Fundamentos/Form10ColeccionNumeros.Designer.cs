namespace Fundamentos
{
    partial class Form10ColeccionNumeros
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
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.txtImpares = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.AllowDrop = true;
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 15;
            this.lstNumeros.Location = new System.Drawing.Point(37, 92);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(137, 184);
            this.lstNumeros.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Números";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(209, 56);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(188, 40);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(209, 122);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(188, 40);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostar datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Impares";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(262, 178);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 23);
            this.txtSuma.TabIndex = 18;
            // 
            // txtPares
            // 
            this.txtPares.Location = new System.Drawing.Point(262, 214);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(100, 23);
            this.txtPares.TabIndex = 19;
            // 
            // txtImpares
            // 
            this.txtImpares.Location = new System.Drawing.Point(262, 253);
            this.txtImpares.Name = "txtImpares";
            this.txtImpares.Size = new System.Drawing.Size(100, 23);
            this.txtImpares.TabIndex = 20;
            // 
            // Form10ColeccionNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 407);
            this.Controls.Add(this.txtImpares);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.label1);
            this.Name = "Form10ColeccionNumeros";
            this.Text = "Form10ColeccionNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstNumeros;
        private Label label1;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
    }
}