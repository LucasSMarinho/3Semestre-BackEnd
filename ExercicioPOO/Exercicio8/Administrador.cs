using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Administrador : IAutenticavel
    {

        string Senha = 2234;

        public void Autenticar(string senha)
        {
        if(Senha = senha)
        {
            Console.WriteLine($"Autenticado!");
        }
        }
    }
}