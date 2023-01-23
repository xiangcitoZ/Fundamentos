using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClases;

namespace Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Net Core";
            persona.Edad = 20;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero =TipoGenero.Masculino;
            persona.GetNombreCompleto(Name);

            persona.Domicilio = new Direccion("Calle Pez", "Madrid", 28025);

            this.lstDatos.Items.Add(persona.Nombre + " "
                + persona.Apellidos + ", Edad: " + persona.Edad);
            this.lstDatos.Items.Add(persona.Genero + ", "
                + persona.Nacionalidad);
       
            this.lstDatos.Items.Add(persona.GetNombreCompleto());
            this.lstDatos.Items.Add("DIRECCION: " + persona.Domicilio.Calle);

            this.lstDatos.Items.Add("Nombre: " + persona.Nombre.ToUpper());
            this.lstDatos.Items.Add("Direccion: " + persona.Domicilio.Calle);

        }
    }
}
