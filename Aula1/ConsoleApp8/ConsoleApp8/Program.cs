// See https://aka.ms/new-console-template for more information
using ConsoleApp8;

Console.WriteLine("CASA INSTANCIADA OBJETO!");
var casa = new Casa();
casa.Cor = "Laranja";
casa.QuantidadeDePortas = 1;
casa.QuantidadeDeJanelas= 2;
casa.Tamanho = 500;

Console.WriteLine("A cor da casa e " + casa.Cor);
Console.WriteLine("A quantidade de portas e " + casa.QuantidadeDePortas);

var casa2 = new Casa();
casa2.Cor = "Vermelho";
casa2.QuantidadeDePortas = 2;

Console.WriteLine("A cor da casa e " + casa2.Cor);
Console.WriteLine("A quantidade de portas e " + casa2.QuantidadeDePortas);

casa2.VenderCasa();

var casaOld = new Casa(123,"Amarelo");
Console.WriteLine("COR: " +
    casaOld.Cor +" TAMANHO:" + casaOld.Tamanho);

var casaNew = new Casa(123, "Amarelo", 1, 3);
Console.WriteLine(casaNew.QuantidadeDePortas);

MoradorCasa.idade = 20;
MoradorCasa.nome = "Jhow";

Console.WriteLine("O nome e " +
    MoradorCasa.nome + " Idade: " + MoradorCasa.nome);

var casaOld1 = new Casa(123);
Console.WriteLine(casaOld1.Cor);
