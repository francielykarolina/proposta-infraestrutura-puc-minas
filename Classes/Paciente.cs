using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropostaInfraestrutura.Classes
{
    public class Paciente
    {
        public string Nome { get; set; }
        public string CNS { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nome:{Nome}");
            Console.WriteLine($"CNS:{CNS}");
            Console.WriteLine($"Data de Nascimento:{DataNascimento}");
            Console.WriteLine($"Endereço:{Endereco}");
            Console.WriteLine($"Telefone:{Telefone}");
        }

        public void PreencherDados()
        {
            Console.WriteLine("Nome do paciente:");
            Nome = Console.ReadLine();
            Console.WriteLine("CNS:");
            CNS = Console.ReadLine();
            Console.WriteLine("Data de Nascimento:");
            DataNascimento = Console.ReadLine();
            Console.WriteLine("Endereço:");
            Endereco = Console.ReadLine();
            Console.WriteLine("Telefone:");
            Telefone = Console.ReadLine();
            }
    }
}
