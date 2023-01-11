namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {   
            //AQUI ESCRIBIMOS NUESTRAS ACCIONES AL PULSAR EL BOTON
            //TENEMOS PROPIEDAS DE TIPO PRIMITIVO
            this.txtName.Width = 150;
            this.btnName.Text = "Botón pulsado!!";
            //TENEMOS PROPIEDADES QUE SON DE TIPO OBJETO
            this.txtName.Location = new Point(70, 100);
            //TENEMOS PROPIEDADES DE TIPO ENUMERADAS
            //UNA ENUMERACION SON UNA SERIE DE VALOR QUE
            //SE REPRESENTAN DE FORMA GRAFICA Y AYUDAN AL PROGRAMADOR
            this.txtName.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Beige;
            this.btnName.BackColor = Color.LightGreen;

            //CONVERSION AUTOMATICA 
            short numero = 99;
            int mayor = numero;

            //CASTING ENTRE OBJETOS
            int numeroMayor = 99;
            short numeroMenor = 888;
            //NECESITAMOS ALMACENAR EN
            //EL NUMERO MENOR EL DATO DEL MAYOR
            numeroMenor = (short) numeroMayor;

            //CONVERTIR STRING A PRIMITIVO
            string textoNumero = "1444";
            int numeroEntero = int.Parse(textoNumero);
            double doble = double.Parse(textoNumero);

            //CONVERTIR OBJETOS A STRING 
            int valor = 8888;
            string texto = valor.ToString();
            string boton = this.btnName.ToString();


        }
    }
}