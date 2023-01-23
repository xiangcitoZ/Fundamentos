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
    public partial class Form12Metodos : Form
    {
        public Form12Metodos()
        {
            InitializeComponent();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDoble(num);
            //DIBUJAMOS EN RESULTADO
            this.label2.Text = num.ToString();
        }

        void GetDoble(int numero)
        {
            //CAMBIAMOS EL VALOR DEL PARAMETRO WRAPPER RECIBIDO
            numero = numero * 2;
        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //TANTO EN EL METODO COMO EN LA LLAMADA
            //DEBEMOS UTILIZAR ref
            this.GetDobleReferencia(ref num);
            this.label2.Text = num.ToString();
        }

        void GetDobleReferencia(ref int numero)
        {
            //CAMBIAMOS EL VALOR DE LA VARIABLE RECIBIDA
            numero = numero * 2;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnObjetoReferencia);
            this.CambiarColor(this.btnValor);
        }

        void CambiarColor(Button boton)
        {
            //CAMBIAMOS ALGO DEL OBJETO
            boton.BackColor = Color.Yellow;
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {   //LA TECLA PULSADA
            //e.KeyChar
            //DESACTIVA LAS ACCIONES POSTERIORES AL EVENTO
            //e.Handled = true;
            char teclaBorrar = (char) Keys.Back;
            if(char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }


        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
