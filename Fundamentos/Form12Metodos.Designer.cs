namespace Fundamentos
{
    partial class Form12Metodos
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
            this.btnValor = new System.Windows.Forms.Button();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnObjetoReferencia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.txtLetras = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValor
            // 
            this.btnValor.Location = new System.Drawing.Point(49, 90);
            this.btnValor.Name = "btnValor";
            this.btnValor.Size = new System.Drawing.Size(146, 45);
            this.btnValor.TabIndex = 0;
            this.btnValor.Text = "Doble() Valor";
            this.btnValor.UseVisualStyleBackColor = true;
            this.btnValor.Click += new System.EventHandler(this.btnValor_Click);
            // 
            // btnReferencia
            // 
            this.btnReferencia.Location = new System.Drawing.Point(49, 153);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(146, 45);
            this.btnReferencia.TabIndex = 1;
            this.btnReferencia.Text = "Doble Referencia";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(106, 33);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 4;
            // 
            // btnObjetoReferencia
            // 
            this.btnObjetoReferencia.Location = new System.Drawing.Point(49, 226);
            this.btnObjetoReferencia.Name = "btnObjetoReferencia";
            this.btnObjetoReferencia.Size = new System.Drawing.Size(146, 45);
            this.btnObjetoReferencia.TabIndex = 5;
            this.btnObjetoReferencia.Text = "Objeto Referencia";
            this.btnObjetoReferencia.UseVisualStyleBackColor = true;
            this.btnObjetoReferencia.Click += new System.EventHandler(this.btnObjetoReferencia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solo números";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Solo letras";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(381, 71);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 23);
            this.txtNumeros.TabIndex = 8;
           
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // txtLetras
            // 
            this.txtLetras.Location = new System.Drawing.Point(381, 117);
            this.txtLetras.Name = "txtLetras";
            this.txtLetras.Size = new System.Drawing.Size(100, 23);
            this.txtLetras.TabIndex = 9;
            this.txtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetras_KeyPress);
            // 
            // lblMouse
            // 
            this.lblMouse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMouse.Location = new System.Drawing.Point(283, 168);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(244, 154);
            this.lblMouse.TabIndex = 10;
            this.lblMouse.Text = "label5";
            this.lblMouse.Click += new System.EventHandler(this.label5_Click_1);
            this.lblMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMouse_MouseMove);
            // 
            // Form12Metodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 359);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtLetras);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObjetoReferencia);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.btnValor);
            this.Name = "Form12Metodos";
            this.Text = "Form12Metodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnValor;
        private Button btnReferencia;
        private Label label1;
        private Label label2;
        private TextBox txtNumero;
        private Button btnObjetoReferencia;
        private Label label3;
        private Label label4;
        private TextBox txtNumeros;
        private TextBox txtLetras;
        private Label lblMouse;
    }
}