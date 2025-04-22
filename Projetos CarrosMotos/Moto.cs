using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Moto : Veiculo
    {
        private int cilindrada;

        public int Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        override public double CalculoPreco()
        {
            if (Cilindrada >= 300)
            {
                return Preco + 2500;
            }
            else
            {
                return Preco;
            }
        }

        public override string Mostra()
        {
            return base.Mostra() + "\nCilindradas: " + Cilindrada + "\nValor total: " + CalculoPreco();
        }
    }
}
