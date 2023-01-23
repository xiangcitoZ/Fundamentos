using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using LibreriaClases.Models;
using System.IO;

namespace Fundamentos
{
    public partial class Form23ObejtoXMLMascota : Form
    {
        //EL OBJETO PARA SERIALIZAR EN XML
        XmlSerializer serializer;
        public Form23ObejtoXMLMascota()
        {
            InitializeComponent();
            //EN EL MOMENTO DE INSTANCIAR EL OBJETO
            //SERA NECESARIO INDICAR LA CLASE QUE UTILIARA
            //EN EL SERIALIZACION
            this.serializer = new XmlSerializer(typeof(Mascota));

        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;

            using (StreamReader reader = new StreamReader("mascotas.xml"))
            {

                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();


            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Years.ToString();

        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);
            
            using(StreamWriter writer = new StreamWriter("mascotas.xml"))
            {
                this.serializer.Serialize(writer, mascota);

                await writer.FlushAsync();
                writer.Close();

            }
            this.txtEdad.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";


        }
    }
}
