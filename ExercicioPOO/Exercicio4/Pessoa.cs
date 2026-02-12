using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Pessoa
    {
     public string Nome = "";
     public int Idade = 0;   
     
     public Pessoa(string n)
     {
            Nome = n;
     }

     public void ExibirDados()
     {
        Console.WriteLine($"{Nome} tem {Idade} anos");
     }

     public void DefinirIdade()
     {
        Console.WriteLine($"Digite a idade de maria");
        int i = int.Parse(Console.ReadLine());
        if(i > 0)
        {
            Idade = i;
        }
        else
        {
            Console.WriteLine($"Idade tem que ser maior que 0");
        }
     }

    }
}