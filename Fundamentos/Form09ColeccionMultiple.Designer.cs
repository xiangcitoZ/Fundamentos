namespace Fundamentos
{
    partial class Form09ColeccionMultiple
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
            this.lblItem = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.bntEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItem.Location = new System.Drawing.Point(172, 335);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(83, 30);
            this.lblItem.TabIndex = 17;
            this.lblItem.Text = "lblItem";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIndice.Location = new System.Drawing.Point(172, 287);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(98, 30);
            this.lblIndice.TabIndex = 16;
            this.lblIndice.Text = "lblIndice";
            // 
            // btnBorrar
            // 
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(447, 274);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(149, 43);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // bntEliminar
            // 
            this.bntEliminar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bntEliminar.Location = new System.Drawing.Point(447, 225);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(149, 43);
            this.bntEliminar.TabIndex = 14;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = false;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnInsertar.Location = new System.Drawing.Point(447, 176);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(149, 43);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 23);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(447, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nuevo elemento";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.ItemHeight = 15;
            this.lstElementos.Location = new System.Drawing.Point(172, 137);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(198, 109);
            this.lstElementos.TabIndex = 10;
            this.lstElementos.SelectedIndexChanged += new System.EventHandler(this.lstElementos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            this.btnSeleccionados.Location = new System.Drawing.Point(455, 356);
            this.btnSeleccionados.Name = "btnSeleccionados";
            this.btnSeleccionados.Size = new System.Drawing.Size(151, 23);
            this.btnSeleccionados.TabIndex = 18;
            this.btnSeleccionados.Text = "Seleccionados";
            this.btnSeleccionados.UseVisualStyleBackColor = true;
            this.btnSeleccionados.Click += new System.EventHandler(this.btnSeleccionados_Click);
            // 
            // Form09ColeccionMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionados);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.bntEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.label1);
            this.Name = "Form09ColeccionMultiple";
            this.Text = "Form09ColeccionMultiple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblItem;
        private Label lblIndice;
        private Button btnBorrar;
        private Button bntEliminar;
        private Button btnInsertar;
        private TextBox textBox1;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}