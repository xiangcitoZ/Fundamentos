using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Fundamentos
{
    public partial class Form13ArrayList : Form
    {
        public Form13ArrayList()
        {
            InitializeComponent();

            this.button3.Click += Button3_Click;
            //VAMOS A TENER UNA COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //AÑADIMOS LA CAJA A NUESTRA COLECCION
            coleccion.Add(this.textBox1);
            //SI INTENTAMOS ACCEDER A LAS PROPIEDADES
            //NO LAS VEREMOS
            ((Button)coleccion[0]).Text = "Soy un botón";
            //LOS BUCLE FOREACH PUEDE REALIZAR EL CASTING DE 
            //FORMA AUTOMATICA
            //DEBEMOS UTILIZAR LA ABSTRACCION
            foreach(Control control in coleccion)
            {
                control.BackColor = Color.Yellow;

                if (control is TextBox)
                {   
                    ((TextBox)control).Paste();
                }
            }
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
