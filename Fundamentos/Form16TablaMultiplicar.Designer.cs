namespace Fundamentos
{
    partial class Form16TablaMultiplicar
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
            this.panelTabla = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.textBox6);
            this.panelTabla.Controls.Add(this.textBox4);
            this.panelTabla.Controls.Add(this.textBox5);
            this.panelTabla.Controls.Add(this.textBox3);
            this.panelTabla.Controls.Add(this.textBox2);
            this.panelTabla.Location = new System.Drawing.Point(171, 77);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(152, 184);
            this.panelTabla.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(18, 132);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(18, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(31, 111);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.Location = new System.Drawing.Point(31, 196);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarTabla.TabIndex = 3;
            this.btnMostrarTabla.Text = "Mostrar Tabla";
            this.btnMostrarTabla.UseVisualStyleBackColor = true;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tabla Multiplicar";
            // 
            // Form16TablaMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.label1);
            this.Name = "Form16TablaMultiplicar";
            this.Text = "Form16TablaMultiplicar";
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panelTabla;
        private TextBox textBox2;
        private TextBox txtNumero;
        private Button btnMostrarTabla;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
    }
}