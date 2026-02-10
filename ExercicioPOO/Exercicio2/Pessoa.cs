using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Pessoa
    {
     string Nome = "";
     int Idade = 0;   

     public void ExibirDados()
     {
        Console.WriteLine($"{Nome} e {Idade} anos");
     }
    }
}