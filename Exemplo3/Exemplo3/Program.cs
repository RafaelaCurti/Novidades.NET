using System;
using static System.Console;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno(); //{ Nome = "Rafaela", Matricula = 11921264 };
            WriteLine($"{Aluno.Matricula} - {gp.Nome} - {gp.Status}");
            ReadLine();
        }
    }
}
