namespace Fundamentos
{
    partial class Form01SumarNumeros
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(235, 62);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(162, 23);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(235, 97);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(162, 23);
            this.txtNumero2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(106, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuma.Location = new System.Drawing.Point(256, 220);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(110, 30);
            this.lblSuma.TabIndex = 4;
            this.lblSuma.Text = "Resultado";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(235, 154);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(155, 31);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form01SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 362);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Form01SumarNumeros";
            this.Text = "Form01SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label label1;
        private Label label2;
        private Label lblSuma;
        private Button btnSumar;
    }
}