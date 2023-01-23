﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        //CONSTRUCTOR VACIO
        public Direccion( string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor Direccion sin parámetros");
        }
         
        public Direccion(string calle, string ciudad, int cp) 
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor Direccion TRES parámetros");
        }
    }
}
