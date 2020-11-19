using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que leia e valide as seguintes informações:

                /*1 Nome: diferente de vazio;*/
                string nome;

                Console.Write("digite o nome: ");
                nome = Console.ReadLine();
                while (nome == "")
                {
                    Console.Write("error, tente novamente!: ");
                    break;
                }
                /*2 Idade: entre 0 e 150;*/
                Console.Write("digite a idade entre 0 e 150: ");
                int idade = int.Parse(Console.ReadLine());
                while(!(idade >0 && idade <150)){
                    Console.Write("error, tente novamente!: ");
                    break;
                }
                /*3 Salário: maior que zero;*/
                Console.Write("digite um salário maior que zero: ");
                float salario = float.Parse(Console.ReadLine());
                while(!(salario >0)){
                    Console.Write("error, tente novamente!: ");
                    break;
                }
                /* 4 Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)); */
                Console.Write("'s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)): ");
                string resposta = Console.ReadLine();
                while (!(resposta == "s" || resposta == "c" || resposta == "v" || resposta == "d"))
                {
                    Console.Write("error, tente novamente!: ");
                    break;
                }
        }
    }
}
