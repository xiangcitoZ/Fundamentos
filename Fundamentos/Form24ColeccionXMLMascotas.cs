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
    public partial class Form24ColeccionXMLMascotas : Form
    {
        XmlSerializer serializer;
        List<Mascota> coleccionMascotas;


        public Form24ColeccionXMLMascotas()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
            this.coleccionMascotas = new List<Mascota>();
        }

        private void btnNuevoMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);

            //mascota.Imagen = Image.FromFile(@"C:/Users/Alumnos MCSD Mañana/Downloads/casa.jpg");
           // this.ptbImagen.Image = mascota.Imagen;
            this.coleccionMascotas.Add(mascota);
            this.txtNombre.Text = "";
            this.txtEdad.Text = "";
            this.txtRaza.Text = "";
            this.DibujarMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach(Mascota mascota in this.coleccionMascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnLeerRegistro_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("coleccionmascotas.xml"))
            {
                this.coleccionMascotas = (List<Mascota>)this.serializer.Deserialize(reader);
            }
            this.DibujarMascotas();
        }

        private async void btnGurdarRegistro_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("coleccionmascotas.xml"))
            {
                this.serializer.Serialize(writer, this.coleccionMascotas);
                await writer.FlushAsync();
                writer.Close();

            }

            this.lstMascotas.Items.Clear();
            this.coleccionMascotas.Clear();


        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {



            int indice = this.lstMascotas.SelectedIndex;
            if(indice != -1)
            {
                Mascota mascota = this.coleccionMascotas[indice];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Years.ToString();
            }
        }

        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public static Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }

    }
}
