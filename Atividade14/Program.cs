/*14. Maior elemento
Leia 10 números e informe:
● Maior valor
● Posição em que ele aparece*/

Console.WriteLine("----------- MAIOR ELEMENTO ----------- ");

int num;
int i;
int maiorNum=0;
int maiorPos=0;

for(i=1; i<=10; i++)
{
    Console.WriteLine($"Digite o {i}º número inteiro:");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
      Console.WriteLine($"Entrada Inválida. Digite um número inteiro:");  
    }
    if (i == 1 || maiorNum < num)
    {
        maiorNum = num;
        maiorPos = i;
    }
}
Console.WriteLine($" O maior valor digitado é: {maiorNum} e se encontra na posição: {maiorPos}");