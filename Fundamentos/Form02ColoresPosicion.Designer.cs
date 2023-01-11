namespace Fundamentos
{
    partial class Form02ColoresPosicion
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
            this.txtPosicion1 = new System.Windows.Forms.TextBox();
            this.txtPosicion2 = new System.Windows.Forms.TextBox();
            this.btnPosicion = new System.Windows.Forms.Button();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPosicion1
            // 
            this.txtPosicion1.Location = new System.Drawing.Point(134, 35);
            this.txtPosicion1.Name = "txtPosicion1";
            this.txtPosicion1.Size = new System.Drawing.Size(178, 23);
            this.txtPosicion1.TabIndex = 0;
            this.txtPosicion1.Text = "X";
            this.txtPosicion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPosicion2
            // 
            this.txtPosicion2.Location = new System.Drawing.Point(134, 73);
            this.txtPosicion2.Name = "txtPosicion2";
            this.txtPosicion2.Size = new System.Drawing.Size(178, 23);
            this.txtPosicion2.TabIndex = 1;
            this.txtPosicion2.Text = "Y";
            this.txtPosicion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPosicion
            // 
            this.btnPosicion.BackColor = System.Drawing.Color.Yellow;
            this.btnPosicion.Location = new System.Drawing.Point(134, 102);
            this.btnPosicion.Name = "btnPosicion";
            this.btnPosicion.Size = new System.Drawing.Size(178, 29);
            this.btnPosicion.TabIndex = 2;
            this.btnPosicion.Text = "Cambiar Posicion";
            this.btnPosicion.UseVisualStyleBackColor = false;
            this.btnPosicion.Click += new System.EventHandler(this.btnPosicion_Click);
            // 
            // txtRojo
            // 
            this.txtRojo.BackColor = System.Drawing.Color.Red;
            this.txtRojo.Location = new System.Drawing.Point(134, 169);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(183, 23);
            this.txtRojo.TabIndex = 3;
            this.txtRojo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVerde
            // 
            this.txtVerde.BackColor = System.Drawing.Color.Lime;
            this.txtVerde.Location = new System.Drawing.Point(134, 211);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(183, 23);
            this.txtVerde.TabIndex = 4;
            this.txtVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAzul
            // 
            this.txtAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAzul.Location = new System.Drawing.Point(134, 250);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(183, 23);
            this.txtAzul.TabIndex = 5;
            this.txtAzul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(134, 295);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(183, 22);
            this.btnColor.TabIndex = 6;
            this.btnColor.Text = "CambiarColor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form02ColoresPosicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 397);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.btnPosicion);
            this.Controls.Add(this.txtPosicion2);
            this.Controls.Add(this.txtPosicion1);
            this.Name = "Form02ColoresPosicion";
            this.Text = "Form02ColoresPosicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPosicion1;
        private TextBox txtPosicion2;
        private Button btnPosicion;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnColor;
    }
}