




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Xml.Linq;


namespace MeuprimeiroProjetoConsole
{


    class Program
    {

        static void Main(string[] args)
        {
            var MediaFilho = 0.0;
            var Mediasalario = 0.0;
            int[] arr = new int[200];

            var totpessoas1500 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                var randNum = new Random();
                var random = randNum.Next(1300, 3000);
                var Nfilhos = randNum.Next(1, 5);

                if (random <= 1500)
                {
                    totpessoas1500++;
                }

                arr[i] = random;



                MediaFilho += Nfilhos;
                Mediasalario += random;

            }
            var Maiorsalario = arr[0];
            var Menorsalario = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (Maiorsalario < arr[i])
                {
                    Maiorsalario = arr[i];
                }


                if (Menorsalario > arr[i])
                {
                    Menorsalario = arr[i];
                }
            }



            decimal numero = ((totpessoas1500 * 200) / 100);


            Console.WriteLine("TOTAL DE SALÁRIOS COMPUTADOS: " + Mediasalario + " R$" +
            "\nTotal de pessoas computadas: " + arr.Length +
            " \nA média de salário é: " + Mediasalario / arr.Length + " R$" +
            "\nO número total de filhos: " + MediaFilho +
            "\nA Média de filhos por pessoa é: " + MediaFilho / arr.Length +
            "\nO maior salário é:  " + Maiorsalario + " R$" +
            "\nO menor salário é: " + Menorsalario + " R$" +
            "\nPessoas com salário menor ou igual a 1500: " + totpessoas1500 +
            "\nA porcentagem de pessoas com salários de até 1500 é: " + numero + "%");

        }

    }
}
