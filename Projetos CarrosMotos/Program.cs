using POO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Veiculo> listveiculos = new List<Veiculo>();

        int op;

        do
        {
            Console.WriteLine("___________Menu Loja Automotiva___________");
            Console.WriteLine("1. Cadastrar Carro");
            Console.WriteLine("2. Cadastrar Moto");
            Console.WriteLine("3. Mostrar Dados de Todos os Veículos");
            Console.WriteLine("4. Mostrar Preço Final de um Veículo pelo Modelo");
            Console.WriteLine("5. Sair");
            Console.Write("Oque deseja fazer: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Carro c = new Carro();
                    CadastrarVeiculo(c);

                    Console.Write("Ar Condicionado: (sim/nao) ");
                    c.Aux = Console.ReadLine();

                    listveiculos.Add(c);

                    Console.WriteLine("\nVeiculo Cadastrado com sucesso!");

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 2:
                    Moto m = new Moto();
                    CadastrarVeiculo(m);

                    Console.Write("Cilindrada: ");
                    m.Cilindrada = int.Parse(Console.ReadLine());

                    listveiculos.Add(m);

                    Console.WriteLine("\nVeiculo Cadastrado com sucesso!");

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 3:
                    foreach (Veiculo veiculo in listveiculos)
                    {
                        Console.WriteLine("\n" + veiculo.Mostra());

                        Console.WriteLine("-------------------------------");
                    }
                    
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.Write("\nDigite o modelo: ");
                    string modelo = Console.ReadLine();
                    bool verificar = false;

                    foreach (Veiculo veiculo in listveiculos)
                    {

                        if (modelo == veiculo.Modelo)
                        {
                            Console.WriteLine("\n" + veiculo.Mostra());
                            verificar = true;
                        }
                        
                    }

                    if (verificar == false)
                    {
                        Console.WriteLine("Veiculos nao cadastrado ");
                    }

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    break;

            }

        } while (op != 5);




        static void CadastrarVeiculo(Veiculo v)
        {
            Console.Write("\nMarca: ");
            v.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            v.Modelo = Console.ReadLine();

            Console.Write("Preço: ");
            v.Preco = double.Parse(Console.ReadLine());


        }
    }
}
