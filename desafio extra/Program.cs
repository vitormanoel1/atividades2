using System;

namespace desafio_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;

            Console.WriteLine(1);
            Console.WriteLine();
            
            for(int i = 0;a < 610; i++) {
                b = b + a;
                a = b - a;
                Console.WriteLine(a); 
            }
        }
    }
}
