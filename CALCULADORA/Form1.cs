using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operaciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNcero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void BTNpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void BTNdividir_Click(object sender, EventArgs e)
        {
            operaciones = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void BTNmultiplicar_Click(object sender, EventArgs e)
        {
            operaciones = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void BTNmenos_Click(object sender, EventArgs e)
        {
            operaciones = "-";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void BTNmas_Click(object sender, EventArgs e)
        {
            operaciones = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void BTNigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (operaciones)
            {
                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void BTNraiz_Click(object sender, EventArgs e)
        {
            operaciones = "raiz";
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla.Text = Math.Sqrt(primero).ToString();
        }

        private void BTNlimpiar_Click_1(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
