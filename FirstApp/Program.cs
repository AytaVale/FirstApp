using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 100;
            int sum = 0;
            while (n<m)
            {
                if (n%3==0 && n%4==0)
                {
                    sum++;
                    Console.WriteLine("Hem 3, hem de 4 bolunen reqemler {0}", n);
                }
                n++;
            }
            Console.WriteLine("Hem 3, hem de 4 bolunenlerin SAYI {0}",sum);
        }
    }
}
