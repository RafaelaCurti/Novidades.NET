using System;
using static System.Console;

namespace Exemplo4
{
    //Null Propagation Operator
    class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem Nome";
        public Curso Curso { get; set; }
        
        
        static void Main(string[] args)
        {
            //Jeito de se fazer mais complexo

            //    var gp = new Aluno() { Matricula = 123, Nome = "Rafaela" };
            //    WriteLine($"\nMatricula:{gp.Matricula}\nNome:{gp.Nome}");
            //    if (gp.Curso != null)
            //    { WriteLine($"Curso:{gp.Curso.NomeCurso}");
            //    //else
            //            //WriteLine("Aluno não possuí inscrição em um Curso");
            //        if (gp.Curso.Area != null)
            //            WriteLine($"Curso:{gp.Curso.Area.NomeArea}");
            //    }
            //    else
            //        WriteLine("Aluno não possuí inscrição em um Curso e nem Área desse Curso");
            //    ReadLine();

            //Jeito Melhor de se fazer
            var gp = new Aluno() {
                Matricula = 123,
                Nome = "Rafaela",
                    Curso = new Curso() { 
                        NomeCurso = "Engenharia de Software",
                        Area = new Area()
                        {
                            NomeArea = "Ciência Exatas e Suas Tecnologias"
                        }
                    }
                };
            WriteLine($"Matricula:{gp.Matricula}\nNome:{gp.Nome}");
            WriteLine($"Curso:{gp?.Curso?.NomeCurso ?? "Sem Curso"}");
            WriteLine($"Curso:{gp?.Curso?.Area?.NomeArea ?? "Sem Área"}");
            ReadLine();
        }
    }
    public class Area
    {
        public string NomeArea { get; set; } = "Sem Nome de Área";
    }
    class Curso
    {
        public int Codigo { get; set; } = 0;
        public string NomeCurso { get; set; } = "Sem Nome do Curso";
        public Area Area { get; set; }
    }
}
