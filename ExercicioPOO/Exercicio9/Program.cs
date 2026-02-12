using System.Runtime.InteropServices;
using Exercicio9;

Console.WriteLine($"Digite um numero");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite outro numero");
float n2 = float.Parse(Console.ReadLine());

Calculadora.Somar(n1, n2)
Calculadora.Multiplicar(n1, n2)