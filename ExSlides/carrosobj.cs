
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
            var parar = "";

            do
            {

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

                Console.WriteLine("Deseja parar?");
                parar = Console.ReadLine();
            } while (parar != "parar");
            Console.Clear();



            carros.Sort((carro1, carro2) => carro2.valor.CompareTo(carro1.valor));
            Console.WriteLine("Carros ordenados pelo o maior valor para o menor valor");
            foreach (Carro carro in carros)
            {
               
                Console.WriteLine("Indice do veiculo: " + carro.indice  +
                "\n Marca " + carro.marca +
                "\n Valor: " + carro.valor +
                "\n Modelo: " + carro.modelo +
                "\n Cor: " + carro.cor +
                "\n ano" + carro.ano);

            }
            Console.ReadLine();
        }
    }
}
