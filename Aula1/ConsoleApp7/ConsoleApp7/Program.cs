﻿// See https://aka.ms/new-console-template for more information
List<int> notas = new List<int>();
int i =0;

while (i<5)
{
    Console.WriteLine("Digite um numero");
    var notaInt = int.Parse(Console.ReadLine());
    Console.WriteLine(notaInt.GetType());
    notas.Add(notaInt);
    i++;
}
for (int a = 0; a < notas.Count; a++)
{
    Console.WriteLine(notas[a]);
}
Console.WriteLine("Soma dos arrays: "+ notas.Sum());

