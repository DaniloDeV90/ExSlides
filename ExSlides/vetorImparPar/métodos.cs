
using Microsoft.VisualBasic;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exercicios_Lista_Um
{

    public class CarregarV
    {


        public ArrayList Carregar()
        {
            ArrayList vetor = new ArrayList();

            
            var stoppU = "";
            do
            {
                Console.WriteLine("Digite o valor do vetor");

                vetor.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Aperte s para parar de adicionar numeros no vetor ou enter para adicionar mais");

               string  stopp = Console.ReadLine();
                 stoppU = stopp.ToUpper();
            } while (stoppU != "S" );
            return vetor;

        }


        public string Listar(ArrayList result)
        {

            var numeros = "";
            foreach (var item in result)
            {
                numeros += item + " ";

            }
            return "Lista de valores no vetor: " + numeros;

        }

        public string impar(ArrayList ar)
        {
            if (ar.Count == 0) return "Nao existem numeros no vetor";

            var impar = "";
            int numerop = 34;


            foreach (int numero in ar)
            {
                if (numero % 2 == 1)
                {
                    impar += numero + " ";

                }

            }

            if (impar.Length == 0) return "Não existem numeros impares no vetor";
            return "Os numeros impares do vetor são: " + impar;
        }
        public string par(ArrayList ar)
        {

            if (ar.Count == 0) return "Não existem numeros no vetor";


            var par = "";

            foreach (int numero in ar)
            {
                if (numero % 2 == 0)
                {
                    par += numero + " ";


                }

            }
            if (par.Length == 0) return "Não existem numeros pares no vetor";
            return "O numeros pares são: " + par;
        }



        public string qntsimpar(ArrayList ar)
        {
            var impar = 0;

            foreach (int numero in ar)
            {
                if (numero % 2 == 1)
                {
                    impar++;

                }

            }
            return "A quantidade de numeros impares são: " + impar;

        }

        public string qntspar(ArrayList ar)
        {
            var impar = 0;

            foreach (int numero in ar)
            {
                if (numero % 2 == 0)
                {
                    impar++;

                }

            }

            return "A quantidade de numeros pares são: " + impar;

        }
    }


    

}
