namespace LibreriaClases
{   
    public enum TipoGenero { Masculino, Femenino}
    public enum Paises { España, Italia, Francia, Brasil}

    public class Persona
    {
        public Persona()
        {
            this.DomicilioVacaciones = new Direccion("AA", "AAA", 7777);
        }

        public string PropiedadAutoImplementada { get; set; }

        public string Nombre;
        public string Apellidos;

        #region CAMPO DE PROPIEDAD
        private TipoGenero _Genero;

        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor no disponible en enumeración");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        #endregion


        #region PROPIEDADES
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }


        public Paises Nacionalidad { get; set; }
        private int _Edad;
        public int Edad
        {
            get
            {
                //DEVOLVEMOS UN VALOR
                return this._Edad;
            }

            set
            {
                if(value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");

                }
                else
                {
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region METODOS

        public string GetNombreCompleto()
        {
            return this.Nombre +" " + this.Apellidos;
        }
        //QUEREMOS DEVOLVER EL NOMBRE COMPLETO EN ORDEN INVERSO
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else    {
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(string dato) { }

        public void GetNombreCompleto(int numero) { }

        public void MetodoParametrosOpcionales( int num1, 
            int num2 = 199)
        {

        }


        


        #endregion
    }



}