using System;

namespace minmax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5] { 3, 6, -3, 5, 7 };

            int min = vet[0];
            for(int i = 1; i < vet.Length; i++)
            {
                if (vet[i] < min)
                {
                    min = vet[i];
                }
            }
            Console.WriteLine("MINIMO: "+min);
            Console.ReadKey();
        }
    }
}
