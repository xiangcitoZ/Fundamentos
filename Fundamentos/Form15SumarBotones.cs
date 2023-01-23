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
    public partial class Form15SumarBotones : Form
    {

        List<Button> botones;
        int suma;

        public Form15SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.suma = 0;
            
            foreach(Control control in this.panelBotones.Controls)
            {
                if(control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }

            Random random = new Random();
            foreach(Button boton in botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.Click += SumarNumeros;
            }


        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            //RECUPERAMOS EL NUMERO DEL CONTROL PULSADO
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text);
            this.suma += numero;
            this.textBox1.Text = this.suma.ToString();
            boton.BackColor = Color.LightBlue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.textBox1.Text = "0";
            foreach (Button boton in this.botones)
            {
                int num = random.Next(1, 200);
                boton.Text = num.ToString();
                boton.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
        }
    }
}
