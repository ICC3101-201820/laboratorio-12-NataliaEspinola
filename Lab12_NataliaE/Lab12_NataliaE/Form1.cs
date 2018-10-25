using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Lab12_NataliaE
{
    public delegate void AgregarComidaDelegate(string nombre, string proteinas, string grasas, string carbohidratos);
    public delegate void EliminarComidaDelegate(string nombre, string proteinas, string grasas, string carbohidratos);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;
        public Form1()
        {
            InitializeComponent();
        }

        private void listado_Click(object sender, EventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            { 
                OnAgregarComida.Invoke(nombreTextBox.Text, proteinasTextBox.Text, grasasTextBox.Text, CarbohidratosTextBox.Text);
            }
        }
        public void AgregarComida(Comida comida)
        {
            listBox1.Items.Add(comida);
        }

        public void EliminarComida(Comida comida)
        {
            listBox1.Items.Remove(comida);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (OnEliminarComida != null)
            {
                OnEliminarComida.Invoke(nombreTextBox.Text, proteinasTextBox.Text, grasasTextBox.Text, CarbohidratosTextBox.Text);
            }
        }
    }
}
