using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Funcionário : Pessoa
    {
        int Salario = 0;
        

    public Funcionário()
    {
    Nome = "";
    Salario = 0;
    }
    public void DefinirNome()
     {
        Console.WriteLine($"Digite o nome do funcionário");
        Nome = Console.ReadLine();
     }

     public void DefinirSalario()
     {
        Console.WriteLine($"Digite o salario de {Nome}");
        int i = int.Parse(Console.ReadLine());
        if(i > 0)
        {
            Salario = i;
        }
        else
        {
            Console.WriteLine($"O salario tem que ser maior que 0");
        }
     }


          public void DefinirIdade()
     {
        Console.WriteLine($"Digite a idade de {Nome}");
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


     public void ExibirDados()
     {
        Console.WriteLine($"{Nome} tem {Idade} anos e ganha R${Salario}");
     }
}
}