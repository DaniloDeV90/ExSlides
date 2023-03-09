
namespace dowhile
{

    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int num = 0;
            do
            {
                int numero;
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                arr[num] = numero;

                num++;

            } while (num != 6);
            Console.WriteLine("-------");

            var Maior = arr[0];
            var Menor = arr[0];
            var result = 0;
            var tot = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Menor > arr[i])
                {
                    Menor = arr[i];
                }

                if (Maior < arr[i])
                {
                    Maior = arr[i];
                }


                tot += arr[i];


                result = tot / arr.Length;

            }
            Console.WriteLine("O maior número é: " + Maior);
            Console.WriteLine("O menor número é: " + Menor);
            Console.WriteLine("A média dos valores é: " + result);
            Console.ReadLine();
        }
    }
}

