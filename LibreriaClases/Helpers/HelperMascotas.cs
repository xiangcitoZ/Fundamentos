using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClases.Models;

namespace LibreriaClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        //TENDREMOS METODOS QUE SERAN LAS TRIPAS DE LA CLASE
        //VAMOS A LEER UN FILE Y CONTENDRA UN TEXTO CON LAS MASCOTAS
        // GARFIELD#GATO, REX#PERRO

        private void CreateMascotas(string data)
        {
            //LIMPIAMOS LA COLECCION 
            this.Mascotas.Clear();
            //SEPARAMOS LOS OBJETOS
            string[] datosmascotas = data.Split(',');
            foreach(string d in datosmascotas)
            {
                //GARFIELD#GATO
                //SEPARAMOS CADA PROPIEDAD
                string[] propiedades = d.Split('#');
                //INSTANCIAMOS OBJETO MASCOTA
                Mascota mascotas = new Mascota();
                mascotas.Nombre = propiedades[0];
                mascotas.Raza = propiedades[1];
                this.Mascotas.Add(mascotas);

            }
        }

        //CUANDO LEAMOS EL FICHERO DE MASCOTAS , LAS CREAREMOS
        //NECESITAMOS LA RUTA
        public async Task ReadFileMascotasAsync(string path)
        {
            //EXTRAEMOS EL CONTENIDO DEL FICHERO
            string data = await HelperFiles.ReadFileAsync(path);
            this.CreateMascotas(data);
        }

        //AL ESCRIBIR VAMOS A DIBUJAR TODAS LAS MASCOTAS
        //CON LOS SPERARADORES QUE HEMOS PENSADO
        // GARFIELD#GATO, REX#PERRO
        private string GetMascotasString()
        {
            string data = "";
            //RECORREMOS LA COLECCION List<Mascota>
            //Y LE DAMOS FORMATO STRING
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "#" + mascota.Raza;
                data += temp + ",";
                
            }
            data = data.Trim(',');
            return data;
        }

        public async Task SaveFileMascotasAsync(string path)
        {
            string data = this.GetMascotasString();
            await HelperFiles.WriteFileAsync(path,data);
        }


    }

   
}
