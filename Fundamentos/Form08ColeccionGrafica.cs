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
    public partial class Form08ColeccionGrafica : Form
    {
        public Form08ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblIndice_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string elem = this.textBox1.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            //NECESITAMOS RECUPERAR EL OBJETO SELECCIONADO DEL CONTROL LISTBOX
            //CONTROL LISTBOX
            string seleccionado = this.lstElementos.SelectedItem.ToString();
            this.lstElementos.Items.Remove(seleccionado);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndice.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblItem.Text = this.lstElementos.SelectedItem.ToString();
            }
            
        }
    }
}
