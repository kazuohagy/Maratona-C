// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int valor1 = 10;
int valor2 = 20;

if(valor1 > valor2)
{
    Console.WriteLine("Valor 1 é maior que valor 2");
}
else if (valor1 < valor2)
{
    Console.WriteLine("Valor 1 é menor que valor 2");
}
else
{
    Console.WriteLine("Valor 1 é igual a valor 2");
}
//condicao ternaria
string nome = "Gustavo";
nome = nome == "Gustavo" ? "Gustavo Kazuo" : "Outro nome";
Console.WriteLine(nome);