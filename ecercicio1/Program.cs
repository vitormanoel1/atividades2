using System;

namespace atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            //pedir o valor da nota
            do{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
            Console.Write("digite o valor da nota entre 0 e 10: ");
            nota = int.Parse(Console.ReadLine());
        
            if(nota <0 || nota >10){
                Console.Write("error!. por favor digite uma nota válida!: ");
            }

            }while (nota < 0 || nota > 10);
            Console.WriteLine("sua nota foi aceita, parabéns!");
        }
    }
}
