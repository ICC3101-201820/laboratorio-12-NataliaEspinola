using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string nombre;
        string carbohidratos;
        string proteinas;
        string grasas;

        public Comida(string n, string p, string g, string c)
        {
            nombre = n;
            proteinas = p;
            carbohidratos = c;
            grasas = g;
        }
        public override string ToString()
        {
            return $"{nombre} (Carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas})";
        }
        public void Calorias()
        {
            //calcula la cantidad de calorías de la comida (4 ∗ carbohidratos+ 4 ∗ proteinas + 9 ∗ grasas)
        }
    }
}
