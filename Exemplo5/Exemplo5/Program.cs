using System;
using static System.Console;

namespace Exemplo5
{
    //Null Condicional Operator
    public class Dados
    {
        public int Telefone { get; set; } = 0000 - 0000;
        public string Email { get; set; } = "exemplo5@exemplo.com";
        public Nomes Nome { get; set; }
    }
    public class Nomes
    {
        public int NumeroDaSorte { get; set; } = 0000;
        public string Nome { get; set; } = "Seu nome";
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Dados()
            {
                Telefone = 1234 - 1234,
                Email = "rcurtidepaula@hotmail.com",
                Nome = new Nomes
                {
                    Nome = "Rafaela Curti",
                    NumeroDaSorte = 7,
                }
            };
            //WriteLine($"\nEmail:{gp.Email}\nTelefone:{gp.Telefone}");
            //if (gp.Nome != null)
            //{
            //    WriteLine($"Nome:{gp.Nome.Nome}");
            //    if (gp.Nome.NúmeroDaSorte != null)
            //        WriteLine($"Número da Sorte não encontrado");
            //}
            //else
            //    WriteLine("Não existe nome registrado");
            //OU TEM COMO FAZER ASSIM
            WriteLine($"Telefone:{gp.Telefone}\nEmail:{gp.Email}");
            WriteLine($"Nome:{gp?.Nome?.Nome ?? "Sem nome"}");
            WriteLine($"NúmeroDaSorte:{gp?.Nome?.NumeroDaSorte ?? 0}");
            ReadLine();
        }
    }
}

