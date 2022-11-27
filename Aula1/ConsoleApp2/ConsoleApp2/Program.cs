// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

float valorFloat= 3.4F;

Console.WriteLine("Float " +valorFloat);

double valorDouble= 3.4;
Console.WriteLine("Double " + valorDouble);

decimal valorDecimal= 3.4M;
Console.WriteLine("Float " + valorDecimal);

decimal valorDecimal5 = (decimal)valorFloat;
Console.WriteLine("Float para decimal " + valorDecimal5);

string ValorString = "3.4";
decimal valorDecimal2 = decimal.Parse(ValorString);
Console.WriteLine("String para decimal " + valorDecimal2);

string ValorString2 = "4";
float valorFloat2 = int.Parse(ValorString2);
Console.WriteLine("String para int " + valorFloat2);

decimal cotacaoBitCoin = 25000.770123123M;
decimal valorBitCoin = 0.00000001M;
Console.WriteLine(cotacaoBitCoin);
Console.WriteLine(Math.Round(cotacaoBitCoin, 2));
//Isso aqui faz o arrendondamento do numero
Console.WriteLine(Math.Round(cotacaoBitCoin, MidpointRounding.AwayFromZero));
Console.WriteLine(Math.Round(cotacaoBitCoin, MidpointRounding.ToZero));
Console.WriteLine(Math.Round(cotacaoBitCoin, MidpointRounding.ToEven));
Console.WriteLine(cotacaoBitCoin.ToString("C2"));
decimal valorReal = cotacaoBitCoin * valorBitCoin;
Console.WriteLine("Valor em real " + valorReal);
