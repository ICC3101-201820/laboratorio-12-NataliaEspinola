using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Lab12_NataliaE
{
    class Controlador
    {
        public Form1 form1;
        private ListaComida comidas;

        public Controlador()
        {
            comidas = new ListaComida();
        }

        public void OnAgregarComida(string n, string p, string g, string c)
        {
            Comida comida = new Comida(n, p, g, c);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
        public void OnEliminarComida(string n, string p, string g, string c)
        {
            Comida comida = new Comida(n, p, g, c);
            comidas.Eliminar(comida);
            form1.EliminarComida(comida);
        }
    }
}
