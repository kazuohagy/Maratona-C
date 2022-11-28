// See https://aka.ms/new-console-template for more information
using ConsoleApp8;
using System.Security.AccessControl;

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

var casa3 = new Casa();
casa3.numberTelhas1= 1;

var addres = new Endereco();

addres.Rua = "Sao Joao";
addres.Bairro = "Bairro Velho";
addres.Numero = "231";
addres.Cep = "123123-000";
addres.TipoRua = TipoRuaEnum.EstradaDeBarro;
Console.WriteLine(addres.TipoRua.ToString());

//Arrays aula
Console.WriteLine("/////////////////ARRAY////////////////");
string[] frutas = new string[5] {"Maca" ,
    "banana" ,
    "melancia" ,
    "pera" ,
    "banana"
    };

foreach (var fruta in frutas){
    Console.WriteLine("Esse e a fruta: " + fruta);

}

int[] numerosSorteados = new int[5] {1,2,28,21,10};
int numeroMaior = 0;
foreach (var numero in numerosSorteados)
{
    int numAnterior = numero;

    if (numero > numAnterior) { Console.WriteLine(numero); }
    Console.WriteLine(numero);
    
}
for (int i = 0; i< numerosSorteados.Length; i++)
{
    if (numerosSorteados[i] > numeroMaior)
    {
        numeroMaior = numerosSorteados[i];
    }
}
Console.WriteLine("O maior numero e: " + numeroMaior);
Console.WriteLine("ACABOU :D ");