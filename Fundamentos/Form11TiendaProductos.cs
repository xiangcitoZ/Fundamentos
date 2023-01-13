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
    public partial class Form11TiendaProductos : Form
    {
        public Form11TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtProducto.Text;
            this.lstTienda.Items.Add(elem);
            this.txtProducto.Focus();
            this.txtProducto.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
        
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {

                int indicie = this.lstTienda.SelectedIndices[i];
              
                this.lstTienda.Items.RemoveAt(indicie);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {

        
            int numProductosSeleccionados = this.lstTienda.SelectedItems.Count;
            for(int i = numProductosSeleccionados - 1; i >= 0; i--)
            {
                int indiceSeleccionado = this.lstTienda.SelectedIndices[i];
                string productoSeleccionado = this.lstTienda.SelectedItems[i].ToString();

                this.lstAlmacen.Items.Add(productoSeleccionado);
                this.lstTienda.Items.RemoveAt(indiceSeleccionado);
            }
           


        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string producto in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(producto);
            }
            this.lstTienda.Items.Clear();


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(this.lstTienda.SelectedIndex != -1)
            {
                int indice = this.lstTienda.SelectedIndex;
                this.lstTienda.Items[indice] = this.txtProducto.Text;
            }

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice - 1, producto);
            this.lstAlmacen.SelectedIndex = indice - 1;


        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, producto);
            this.lstAlmacen.SelectedIndex = indice + 1;

        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            if(indice == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if (indice == this.lstAlmacen.Items.Count-1)
            {
                this.btnBajar.Enabled = false;  
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
