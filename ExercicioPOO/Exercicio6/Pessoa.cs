using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class Pessoa
    {
     public string Nome = "";
     public string Sobrenome = "";
     public int Idade = 0;   
     
     public Pessoa(string n)
     {
            Nome = n;
     }

     public void ExibirDados()
     {
        Console.WriteLine($"{Nome} tem {Idade} anos");
     }

     public void Apresentar()
     {
        Console.WriteLine($"Digite o sobrenome de {Nome}");
        string s = Console.ReadLine();
        Console.WriteLine($"{Nome} {Sobrenome} tem {Idade} anos");
     }

     public void DefinirIdade()
     {
        Console.WriteLine($"Digite a idade de Maria");
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