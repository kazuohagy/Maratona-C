// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Worldd!");

string name = "Mario";
string sobrenome = "Bros";

Console.WriteLine("Hello " + name + " " + sobrenome);
Console.WriteLine($"{name} {sobrenome}");

int valor1 = 10;
int valor2 = 20;

Console.WriteLine("A soma dos valores e " +(valor1 + valor2));

decimal valor3 = 10.5m;
decimal valor4 = 20.5m;
decimal total = valor3 + valor4;
Console.WriteLine($"A soma dos decimais e: {valor3 + valor4}");

double valor5 = 10.5;
double valor6 = 20.5;

Console.WriteLine($"A subtracao dos decimais e: {valor5 - valor6}");

bool valor7 = false;


if(total > 20)
{
    valor7 = true;
}

if(valor7)
    Console.WriteLine("O valor e maior que 20");

byte valor8 = 10;
Console.WriteLine($"O valor e: {valor8}");

short quantidade = 9;
Console.WriteLine(quantidade);

long valor9 = 1000000000000000000;
Console.WriteLine(valor9);

//Constantes Aula04///////////////////////////////////////

const string nomeDoCelular ="Iphone";
Console.WriteLine(nomeDoCelular);

var casa = new Casa();
class Casa{

    }

