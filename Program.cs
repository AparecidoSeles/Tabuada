using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma tabuada");
            int tabuada = int.Parse(Console.ReadLine());

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(tabuada+ " x " +i+ " = "+tabuada*i);
            }
        }
    }
}
