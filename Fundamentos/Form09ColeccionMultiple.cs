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
    public partial class Form09ColeccionMultiple : Form
    {
        public Form09ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.textBox1.Text;
            this.lstElementos.Items.Add(elem);
            this.textBox1.Focus();
            this.textBox1.SelectAll();


        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            //NO PODEMOS ELIMINAR ELEMENTOS UTILIZANDO UN BUCLE REFERENCIA
            //DEBEMOS RECORRER TODOS LOS ELEMENTOS SELECCIONADO 
            //NOS INTERESA EL INDEX DE CADA ELEMENTO
            //NUMERO DE ELEMENTOS SELECCIONADOS
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            //RECORREMOS TODOS LOS INDICES SELECCIONADOS
            for(int i = numSeleccionados - 1; i >=0; i--)
            {
                //RECUPERAMOS EL INDICE SELECCIONADO
                int indicie = this.lstElementos.SelectedIndices[i];
                //POR ULTIMO, ELIMINAMOS EL ELEMENTO POR SU INDICE
                this.lstElementos.Items.RemoveAt(indicie);
            }
        }


        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            //COMO SOLAMENTE VAMOS A DIBUJAR, PODEMOS UTILIZAR 
            //BUCLES DE REFERENCIA
            string indices = "";
            foreach(int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndice.Text = indices.Trim(',');
            string items = "";
            foreach(string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblItem.Text = items;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
    }
}
