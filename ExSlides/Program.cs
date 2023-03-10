using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loj
{
    class loja
    {
        static void Main(string[] args)
        {

            int[] arr = new int[15];
            var valueCompra = 0;
            var Avista = 0;
            var Prazo = 0;
            for (int i = 0; i < 15; i++)
            {
                string vp;


                Random randNum = new Random();
                var random = randNum.Next(600, 3000);
                Console.WriteLine("Valor da compra: " + random + "\nDigite V para Comprar A vista ou P para comprar a Prazo");
                vp = Console.ReadLine();
                string? VPU = vp.ToUpper();

                if (VPU == "V")
                {
                    Avista += random;
                }
                else if (VPU == "P")
                {
                    Prazo += random;
                }
                else
                {
                    Console.WriteLine("Valor incorreto");
                    break;
                }

            }
            Console.Clear();

            Console.WriteLine("Compras A vista " + Avista + " R$");
            Console.WriteLine("Compras A prazo " + Prazo + " R$");
            Console.WriteLine("Valor total das compras: " + (Avista + Prazo) + " R$");
            Console.ReadLine();

        }




    }
        
}
    