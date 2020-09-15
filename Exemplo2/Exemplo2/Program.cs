using System;
using static System.Console;

namespace Exemplo2
{
    public class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
    }
    public class Programa
    {
        static void Main(string[] args)
        {
            var p = new Pessoa()
            {
                Matricula = 123,
                Nome = "Guinther",
                SobreNome = "Pauli",
            };
            //WriteLine(string.Format("Bem-vindo {0} {1} ({2}), este é o C# 6", 
            // p.Nome, p.SobreNome, p.Matricula));
            WriteLine("Bem-vindo " + p.Nome + " " + p.SobreNome + " ( " + p.Matricula + "), este é o C# 6");
            ReadLine();
        }
    }
}
