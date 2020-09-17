using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo3
//Jeito 1
//{
//class Aluno
//{
//    private int _Matricula;
//    private string _Nome;

//    public int Matricula
//    {
//    get { return this._Matricula; }
//    set { this._Matricula = value; }
//    }
//    public string Nome
//    {
//       get { return this._Nome; }
//       set { this._Nome = value; }
//}
//public Aluno (int matricula, string nome)
//{
//this._Nome = nome;
// this.Matricula = matricula; 
//}
//}
//}
//Jeito2
{
    public class Aluno
    {
        public static int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "sem nome";
        //SE
        public string Status { get; set; } = Matricula == 0? "Não Matriculado" : "Matriculado";
    }
}