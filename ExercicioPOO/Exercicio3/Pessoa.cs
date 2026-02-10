using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Pessoa
    {
     public string Nome = "";
     public int Idade = 0;   
     
     public void ExibirDados()
     {
        Console.WriteLine($"a pessoa tem {Idade} anos");
     }

     public void DefinirIdade()
     {
        Console.WriteLine($"Digite a idade da pessoa");
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