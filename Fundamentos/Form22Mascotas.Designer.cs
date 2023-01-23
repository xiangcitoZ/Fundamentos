namespace Fundamentos
{
    partial class Form22Mascotas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeerRegistros = new System.Windows.Forms.Button();
            this.btnGuardarRegistros = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(12, 186);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(100, 38);
            this.btnNuevoRegistro.TabIndex = 2;
            this.btnNuevoRegistro.Text = "Nuevo registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raza";
            // 
            // btnLeerRegistros
            // 
            this.btnLeerRegistros.Location = new System.Drawing.Point(12, 244);
            this.btnLeerRegistros.Name = "btnLeerRegistros";
            this.btnLeerRegistros.Size = new System.Drawing.Size(100, 38);
            this.btnLeerRegistros.TabIndex = 5;
            this.btnLeerRegistros.Text = "Leer Registros";
            this.btnLeerRegistros.UseVisualStyleBackColor = true;
            this.btnLeerRegistros.Click += new System.EventHandler(this.btnLeerRegistros_Click);
            // 
            // btnGuardarRegistros
            // 
            this.btnGuardarRegistros.Location = new System.Drawing.Point(12, 302);
            this.btnGuardarRegistros.Name = "btnGuardarRegistros";
            this.btnGuardarRegistros.Size = new System.Drawing.Size(100, 38);
            this.btnGuardarRegistros.TabIndex = 6;
            this.btnGuardarRegistros.Text = "Guardar Registros";
            this.btnGuardarRegistros.UseVisualStyleBackColor = true;
            this.btnGuardarRegistros.Click += new System.EventHandler(this.btnGuardarRegistros_Click);
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(163, 86);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(157, 214);
            this.lstMascotas.TabIndex = 7;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mascotas";
            // 
            // Form22Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.btnGuardarRegistros);
            this.Controls.Add(this.btnLeerRegistros);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form22Mascotas";
            this.Text = "Form22Mascotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnNuevoRegistro;
        private TextBox textBox2;
        private Label label2;
        private Button btnLeerRegistros;
        private Button btnGuardarRegistros;
        private ListBox lstMascotas;
        private Label label3;
    }
}