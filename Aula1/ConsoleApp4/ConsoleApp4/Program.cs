// See https://aka.ms/new-console-template for more information
using ConsoleApp4.Calculadora;

Console.WriteLine("Hello, World!");
var calculadora = new CalculadoraDefault();
Console.WriteLine($"A soma dos valores e {calculadora.Somar(1, 2)}");
Console.WriteLine($"A soma dos valores e {calculadora.Subtrair(1, 2)}");
Console.WriteLine($"A soma dos valores e {calculadora.Multiplicar(1, 2)}");
Console.WriteLine($"A soma dos valores e {calculadora.Dividir(1, 2)}");