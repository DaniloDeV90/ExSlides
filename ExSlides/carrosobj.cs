using System;
using System.Collections;
using System.Collections.Generic;
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

            ArrayList carros = new ArrayList();

            var i = 0;
            var parar = "";
            do
            {



                Carro carro = new Carro();

                carro.indice = i++;
                Console.WriteLine( "Indice: "+ carro.indice);
                Console.WriteLine("Digite a marca do carro: ");
                carro.marca = (Console.ReadLine());
                Console.WriteLine("Digite o valor do carro: ");
                carro.valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o modelo do carro: ");
                carro.modelo = Console.ReadLine();
                Console.WriteLine("Digite o ano do carro");
                carro.ano = Convert.ToInt32(Console.ReadLine());
                carros.Add(carro);


                Console.WriteLine("Deseja parar?");
                parar = Console.ReadLine();
            } while (parar != "parar");
            Console.Clear();



            int[] arr = new int[i];


            foreach (Carro carro in carros)
            {



                arr[carro.indice] = carro.valor;




                Console.WriteLine("Indice do carro: " + carro.indice +
                        "\nMarca do carro: " + carro.marca +
                         "\n Valor do carro: " + carro.valor +
                         "\n Modelo do carro: " + carro.modelo +
                         "\n Ano de fabrica do carro: " + carro.ano);





            }

            Array.Sort(arr);
            Array.Reverse(arr);
            for (int valoress = 0; valoress< arr.Length; valoress++) {
                Console.WriteLine(arr[valoress]);
            }

        }
    }
}
   



