using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Authentication;

namespace ConceitoHeranca
{
    class Carro
    {
        public int indice { get; set; }
        public string marca { get; set; }
        public int valor { get; set; }
        public string cor { get; set; }

        public string modelo { get; set; }
        public int ano { get; set; }


    }

    class program
    {
        static void Main(string[] args)
        {
           

            List<Carro> carros = new List<Carro>();
            var i = 0;
            

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" Digite 1 para cadastrar um veiculo \n" +
                " Digite 2 para excluir um veiculo \n" +
                " Digite 3 para mostrar os carros \n" +
                " Digite 4 para fechar a aplicação \n");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Clear();
                    Carro carro = new Carro();
                    carro.indice = i++;

                    Console.WriteLine("Indice: " + carro.indice);
                    Console.WriteLine("Digite a marca do carro: ");
                    carro.marca = (Console.ReadLine());
                    Console.WriteLine("Digite o valor do carro: ");
                    carro.valor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o modelo do carro: ");
                    carro.modelo = Console.ReadLine();
                    Console.WriteLine("Digite a cor do carro: ");
                    carro.cor = Console.ReadLine();
                    Console.WriteLine("Digite o ano do carro");
                    carro.ano = Convert.ToInt32(Console.ReadLine());
                    carros.Add(carro);


                }
                var excluir = 0;
                if (opcao == 2)
                {

                    Console.Clear();
                    Console.WriteLine("Digite  o índice do carro que deseja excluir");
                    excluir = Convert.ToInt32(Console.ReadLine());

                    carros.RemoveAt(excluir);

                    Console.WriteLine("Carro " + excluir + " Excluido");
                    Console.ReadLine();
                }



                if (opcao == 3)
                {

                   Console.WriteLine();
                    carros.Sort((carro1, carro2) => carro1.valor.CompareTo(carro2.valor));
                    Console.WriteLine("Carros ordenados do menor valor para o maior valor");
                    Console.WriteLine();
                    foreach (Carro carro in carros)
                    {

                        Console.WriteLine("Indice do veiculo: " + carro.indice +
                        "\n Marca " + carro.marca +
                        "\n Valor: " + carro.valor + " R$" +
                        "\n Modelo: " + carro.modelo +
                        "\n Cor: " + carro.cor +
                        "\n ano: " + carro.ano);
                       
                    }
                    Console.ReadLine();
                }


            } while (opcao != 4);
      
        }
    }
}