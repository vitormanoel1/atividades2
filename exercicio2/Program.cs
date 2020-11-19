using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário,
            mostrando uma mensagem de erro e voltando a pedir as informações.*/
            string usuario;
            string senha;
            do{

                Console.Write("digite seu nome de usuario: ");
                usuario = Console.ReadLine();

                Console.Write("digite sua senha: ");
                senha = Console.ReadLine();

                if(usuario == senha){
                     Console.WriteLine("por favor, digite uma senha diferente do usuario!");
                }

            }while (usuario == senha);
            
        }
    }
}
