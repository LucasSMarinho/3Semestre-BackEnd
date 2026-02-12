using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Usuario : IAutenticavel
    {

        string Senha = 1234;

        public void Autenticar(string senha)
        {
        if(Senha = senha)
        {
            Console.WriteLine($"Autenticado!");
        }
        }
    }
}