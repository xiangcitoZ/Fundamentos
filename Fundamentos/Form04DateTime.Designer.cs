namespace Fundamentos
{
    partial class Form04DateTime
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
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.txt = new System.Windows.Forms.Label();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.gpbIncrementar = new System.Windows.Forms.GroupBox();
            this.rdbDias = new System.Windows.Forms.RadioButton();
            this.rdbMes = new System.Windows.Forms.RadioButton();
            this.rdbAños = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.gpbIncrementar.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Location = new System.Drawing.Point(33, 104);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(153, 19);
            this.chkFormato.TabIndex = 0;
            this.chkFormato.Text = "Cambiar Formato Fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(33, 24);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(75, 15);
            this.txt.TabIndex = 1;
            this.txt.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Location = new System.Drawing.Point(33, 57);
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.Size = new System.Drawing.Size(355, 23);
            this.txtFechaActual.TabIndex = 2;
            // 
            // gpbIncrementar
            // 
            this.gpbIncrementar.Controls.Add(this.btnIncrementar);
            this.gpbIncrementar.Controls.Add(this.txtIncremento);
            this.gpbIncrementar.Controls.Add(this.label1);
            this.gpbIncrementar.Controls.Add(this.rdbAños);
            this.gpbIncrementar.Controls.Add(this.rdbMes);
            this.gpbIncrementar.Controls.Add(this.rdbDias);
            this.gpbIncrementar.Location = new System.Drawing.Point(33, 148);
            this.gpbIncrementar.Name = "gpbIncrementar";
            this.gpbIncrementar.Size = new System.Drawing.Size(459, 139);
            this.gpbIncrementar.TabIndex = 3;
            this.gpbIncrementar.TabStop = false;
            this.gpbIncrementar.Text = "Incrementar Fecha";
            // 
            // rdbDias
            // 
            this.rdbDias.AutoSize = true;
            this.rdbDias.Location = new System.Drawing.Point(23, 38);
            this.rdbDias.Name = "rdbDias";
            this.rdbDias.Size = new System.Drawing.Size(47, 19);
            this.rdbDias.TabIndex = 0;
            this.rdbDias.TabStop = true;
            this.rdbDias.Text = "Dias";
            this.rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            this.rdbMes.AutoSize = true;
            this.rdbMes.Location = new System.Drawing.Point(23, 63);
            this.rdbMes.Name = "rdbMes";
            this.rdbMes.Size = new System.Drawing.Size(58, 19);
            this.rdbMes.TabIndex = 1;
            this.rdbMes.TabStop = true;
            this.rdbMes.Text = "Meses";
            this.rdbMes.UseVisualStyleBackColor = true;
            this.rdbMes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbAños
            // 
            this.rdbAños.AutoSize = true;
            this.rdbAños.Location = new System.Drawing.Point(23, 88);
            this.rdbAños.Name = "rdbAños";
            this.rdbAños.Size = new System.Drawing.Size(52, 19);
            this.rdbAños.TabIndex = 2;
            this.rdbAños.TabStop = true;
            this.rdbAños.Text = "Años";
            this.rdbAños.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Incremento";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(188, 63);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(246, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(188, 101);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(167, 32);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(33, 330);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(355, 23);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 402);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbIncrementar);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.chkFormato);
            this.Name = "Form04DateTime";
            this.Text = "Form04DateTime";
            this.Load += new System.EventHandler(this.Form04DateTime_Load);
            this.gpbIncrementar.ResumeLayout(false);
            this.gpbIncrementar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkFormato;
        private Label txt;
        private TextBox txtFechaActual;
        private GroupBox gpbIncrementar;
        private RadioButton rdbAños;
        private RadioButton rdbMes;
        private RadioButton rdbDias;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private Label label1;
        private Label label2;
        private TextBox txtNuevaFecha;
    }
}