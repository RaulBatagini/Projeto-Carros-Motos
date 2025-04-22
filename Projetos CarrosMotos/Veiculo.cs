using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Veiculo
    {
        private string marca;
        private string modelo;
        private double preco;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        virtual public double CalculoPreco()
        {
            return preco;
        }

        virtual public string Mostra()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nPreco base: " + Preco;
        }
    }
}