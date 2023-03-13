using Exercicios_Lista_Um;
using System.Collections;

namespace VarList
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var opcao = "";
            var result = new ArrayList();
            do
            {
                Console.Clear();
                Console.WriteLine("Digite 1 para carregar  um vetor" +
                    "\nDigite 2 para listar o vetor" +
                    "\nDigite 3 para mostrar apenas os numeros impares do vetor" +
                    "\nDigite 4 para mostrar apenas os numeros pares do vetor" +
                    "\nDigite 5 para mostrar a quantidade de numeros impares no vetor" +
                    "\nDigite 6 para mostrar a quantidade de numeros pares no vetor" +
                    "\nDigite 7 para finalizar");
                opcao = Console.ReadLine();

                Console.Clear();
                if (opcao == "1")
                {
                    CarregarV carregarV = new CarregarV();
                    result = carregarV.Carregar();



                }
                if (opcao =="2")
                {

                    CarregarV Listar = new CarregarV();
                    
                    Console.WriteLine (Listar.Listar(result));
                }
                if (opcao == "3")
                {
                    CarregarV  impar = new CarregarV();
                    Console.WriteLine(impar.impar(result));
                }
                if (opcao == "4")
                {
                    CarregarV par = new CarregarV();
                    Console.WriteLine(par.par(result));
                }
                if (opcao == "5")
                {
                    CarregarV qntsimpar = new CarregarV();
                    Console.WriteLine(qntsimpar.qntsimpar(result));
                }
                if (opcao == "6")
                {
                    CarregarV qntspar = new CarregarV();
                    Console.WriteLine(qntspar.qntspar(result));
                }

            } while (opcao != "7");
            Console.ReadLine();
        }
    }
}