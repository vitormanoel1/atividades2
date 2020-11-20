using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa que leia e valide as seguintes informações:

                    string nome;
                /*1 Nome: diferente de vazio;*/
                
                do
                {   
                    Console.Write("digite o nome: ");
                    nome = Console.ReadLine();
                }
                while (nome == "" || nome == " ");
                

                /*2 Idade: entre 0 e 150;*/
                    int idade;
                do
                {
                    Console.Write("digite a idade entre 0 e 150: ");
                    idade = int.Parse(Console.ReadLine());
                }
                while(!(idade >0 || idade <150));
            

                /*3 Salário: maior que zero;*/
                float salario;
                do
                {
                    Console.Write("digite um salário maior que zero: ");
                    salario = float.Parse(Console.ReadLine());
                }
                while(!(salario >0));

                /* 4 Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)); */
                string resposta;
                do{
                    Console.Write("'s'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a)): ");
                    resposta = Console.ReadLine();
                }
                while (!(resposta == "s" || resposta == "c" || resposta == "v" || resposta == "d"));

                Console.WriteLine("dados aceitos!");
        }
    }
}
