namespace Fundamentos
{
    partial class Form24ColeccionXMLMascotas
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
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGurdarRegistro = new System.Windows.Forms.Button();
            this.btnLeerRegistro = new System.Windows.Forms.Button();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.btnNuevoMascota = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(25, 225);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Edad";
            // 
            // btnGurdarRegistro
            // 
            this.btnGurdarRegistro.Location = new System.Drawing.Point(163, 209);
            this.btnGurdarRegistro.Name = "btnGurdarRegistro";
            this.btnGurdarRegistro.Size = new System.Drawing.Size(136, 39);
            this.btnGurdarRegistro.TabIndex = 13;
            this.btnGurdarRegistro.Text = "Guardar Registro";
            this.btnGurdarRegistro.UseVisualStyleBackColor = true;
            this.btnGurdarRegistro.Click += new System.EventHandler(this.btnGurdarRegistro_Click);
            // 
            // btnLeerRegistro
            // 
            this.btnLeerRegistro.Location = new System.Drawing.Point(163, 139);
            this.btnLeerRegistro.Name = "btnLeerRegistro";
            this.btnLeerRegistro.Size = new System.Drawing.Size(136, 39);
            this.btnLeerRegistro.TabIndex = 12;
            this.btnLeerRegistro.Text = "Leer Registro";
            this.btnLeerRegistro.UseVisualStyleBackColor = true;
            this.btnLeerRegistro.Click += new System.EventHandler(this.btnLeerRegistro_Click);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(25, 143);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(100, 23);
            this.txtRaza.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.ItemHeight = 15;
            this.lstMascotas.Location = new System.Drawing.Point(338, 76);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(120, 184);
            this.lstMascotas.TabIndex = 17;
            this.lstMascotas.SelectedIndexChanged += new System.EventHandler(this.lstMascotas_SelectedIndexChanged);
            // 
            // btnNuevoMascota
            // 
            this.btnNuevoMascota.Location = new System.Drawing.Point(163, 76);
            this.btnNuevoMascota.Name = "btnNuevoMascota";
            this.btnNuevoMascota.Size = new System.Drawing.Size(136, 39);
            this.btnNuevoMascota.TabIndex = 18;
            this.btnNuevoMascota.Text = "Nueva mascota";
            this.btnNuevoMascota.UseVisualStyleBackColor = true;
            this.btnNuevoMascota.Click += new System.EventHandler(this.btnNuevoMascota_Click);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(25, 276);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(181, 122);
            this.ptbImagen.TabIndex = 19;
            this.ptbImagen.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(251, 320);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(177, 44);
            this.btnExaminar.TabIndex = 20;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            // 
            // Form24ColeccionXMLMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 410);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.btnNuevoMascota);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGurdarRegistro);
            this.Controls.Add(this.btnLeerRegistro);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form24ColeccionXMLMascotas";
            this.Text = "Form24ColeccionXMLMascotas";
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEdad;
        private Label label3;
        private Button btnGurdarRegistro;
        private Button btnLeerRegistro;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnNuevoMascota;
        private PictureBox ptbImagen;
        private Button btnExaminar;
    }
}