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
    public partial class Form06DiaNacimiento : Form
    {
        public Form06DiaNacimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int ano = int.Parse(this.txtAno.Text);

            if (mes == 1)
            {
                mes = 13;
            }

            if (mes == 2)
            {
                mes = 14;
            }

            int paso1 = ((mes + 1) * 3) / 5;
            int paso2 = ano/4;
            int paso3 = ano/100;
            int paso4 = ano / 400;
            int paso5 = dia +(mes * 2) + ano + paso1 + paso2 - paso3 + paso4 + 2;
            int paso6 = paso5 / 7;
            int paso7 = paso5 - (paso6 * 7);

            switch (paso7)
            {
                case 0:
                    this.txtResultado.Text = "Sabado";
                    break;
                case 1:
                    this.txtResultado.Text = "Domingo";
                    break;
                case 2:
                    this.txtResultado.Text = "Lunes";
                    break;

                case 3:
                    this.txtResultado.Text = "Martes";
                    break ;
                case 4:
                    this.txtResultado.Text = "Miercoles";
                    break;
                case 5:
                    this.txtResultado.Text = "Jueves";
                    break;
                case 6:
                    this.txtResultado.Text = "Viernes";
                    break;

            }


        }
    }
}
