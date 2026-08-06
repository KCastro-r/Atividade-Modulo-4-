/*19. Caixa eletrônico
Solicite um valor para saque.
Informe quantas notas serão entregues considerando:
● R$100
● R$50
● R$20
● R$10
● R$5
● R$2*/

Console.WriteLine("---------------- CAIXA ELETRÔNICO ----------------");

int notas100 = 100;
int notas50 = 50;
int notas20 = 20;
int notas10 = 10;
int notas5 = 5;
int notas2 =2;

int valor;
int quantNotas;

Console.WriteLine("Informe em Reais o valor para Saque:");
while(!int.TryParse(Console.ReadLine(), out valor))
{
    Console.WriteLine("Valor Inválido. Digite um número válido:");
}

quantNotas = valor / notas100;
if (quantNotas>0)
{
  Console.WriteLine($"Você receberá {quantNotas} notas de R$100,00");  
}

valor = valor % notas100;
quantNotas = valor / notas50;

if (quantNotas>0)
{
Console.WriteLine($"Você receberá {quantNotas} notas de R$50,00");
}

valor = valor % notas50;
quantNotas = valor / notas20;

if (quantNotas>0)
{
Console.WriteLine($"Você receberá {quantNotas} notas de R$20,00");
}

valor = valor % notas20;
quantNotas = valor / notas10;

if (quantNotas>0)
{
Console.WriteLine($"Você receberá {quantNotas} notas de R$10,00");
}

valor = valor % notas10;
quantNotas = valor / notas5;

if (quantNotas>0)
{
Console.WriteLine($"Você receberá {quantNotas} notas de R$5,00");
}

valor = valor % notas5;
quantNotas = valor / notas2;

if (quantNotas>0)
{
Console.WriteLine($"Você receberá {quantNotas} notas de R$2,00");
valor = valor % notas2;
}