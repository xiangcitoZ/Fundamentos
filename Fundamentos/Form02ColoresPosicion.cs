using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posicionX = int.Parse(this.txtPosicion1.Text);
            int posicionY = int.Parse(this.txtPosicion2.Text);
            this.btnPosicion.Location = new Point(posicionX, posicionY);
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);

            //LOS COLORES SON ENTRE 0 Y 255
            if(rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El color rojo debe estar entre 0 y 255");
            }else if(verde < 0 || verde > 255)
            {
                MessageBox.Show("El color verde debe estar entre 0 y 255");
            }else if(azul < 0 || azul > 255)
            {
                MessageBox.Show("El color azul debe estar entre 0 y 255");
            }
            else
            {

                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }


           

        }
    }
}
