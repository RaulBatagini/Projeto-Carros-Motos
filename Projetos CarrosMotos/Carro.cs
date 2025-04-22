using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Carro : Veiculo
    {
        private bool arcondicionado = false;
        private string aux;

        public string Aux
        {
            get { return aux; }
            set
            {
                if (value == "sim")
                {
                    arcondicionado = true;
                }
                else
                {
                    arcondicionado = false;
                }
            }
        }

        public bool ArCondicionado
        {
            get { return arcondicionado; }
            set { arcondicionado = value; }
        }

        override public double CalculoPreco()
        {
            if (arcondicionado == true)
            {
                return Preco + 5000;
            }
            else
            {
                return Preco;
            }
        }

        public override string Mostra()
        {
            return base.Mostra() + "\nValor total: " + CalculoPreco();
        }
    }
}