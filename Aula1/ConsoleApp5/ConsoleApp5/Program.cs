//Calcular a media dos alunos baseado em 4 nbotas informadas e mostrar se aprovado ou reprovado
//Ao final classificar a media 6
//Excelente 8.5 ou mais aprovado
//Otimo 7.5 e 8.5 ou mais aprovado
//Boa 6 e 7.5 ou mais aprovado
//Regular 4 e 6 
//Ruim 4 ou menos reprovado
using System.Reflection;

double soma = 0;
bool aprovado=false;
string classificacao="";
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite a nota do aluno");
    double nota = double.Parse(Console.ReadLine());
    soma += nota;
}
double media = soma / 4;
if(media >= 6)
{
    aprovado= true;
}
else
{
    aprovado= false;
}
if(media>= 8.5)
{
    classificacao = "Excelente";
}
if(media< 8.5 && media >= 7.5)
{
    classificacao = "Otimo";
}if(media< 7.5 && media >= 6)
{
    classificacao = "Boa";
}if(media< 6 && media >= 4)
{
    classificacao = "Regular";
}
if(media< 4)
{
    classificacao = "Ruim";
}

string resultado = aprovado? $"Aluno e {classificacao} e foi aprovado" : $"Aluno e {classificacao} e foi reprovado";
Console.WriteLine("Media do Aluno: " + media);
Console.WriteLine(resultado);