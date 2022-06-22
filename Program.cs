using System;
using PropostaInfraestrutura.Classes;

namespace PropostaInfraestrutura
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            Paciente paciente = new Paciente();
            paciente.PreencherDados();
            Console.Clear();
            paciente.Imprimir();

        }
    }
}