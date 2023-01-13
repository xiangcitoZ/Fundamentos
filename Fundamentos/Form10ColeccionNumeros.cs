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
    public partial class Form10ColeccionNumeros : Form
    {
        public Form10ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int valor = random.Next(1, 200);
            this.lstNumeros.Items.Add(valor.ToString());

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstNumeros.Items.Count;
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
                
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for (int i = 0 ; i < numSeleccionados; i++)
            {
                int numero = int.Parse(this.lstNumeros.Items[i].ToString());
                //RECUPERAMOS EL INDICE SELECCIONADO
                suma = suma + numero;
               
                if (numero % 2 ==0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
