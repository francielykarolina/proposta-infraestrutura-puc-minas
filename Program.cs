using System;
using PropostaInfraestrutura.Classes;

namespace PropostaInfraestrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bem Vindo (a)! Escolha uma das opções abaixo");
                Console.WriteLine("1 - Cadastrar novo paciente");
                Console.WriteLine("2 - Pesquisar paciente");
                Console.WriteLine("0 - Sair");
                int op = int.Parse(Console.ReadLine());

                if (op == 0) 
                {
                    break;
                }
                else if (op == 1) 
                {
                    Paciente paciente = new Paciente();
                    paciente.PreencherDados();
                    Console.Clear();
                }
                else if(op == 2)
                {
                    
                }

            }



            
            
        }
    }
}