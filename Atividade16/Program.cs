/*16. Contagem de pares
Leia 20 números e informe quantos são pares.*/

Console.WriteLine("------------- CONTAGEM DE PARES ------------- ");
int num;
int i;
int quantPares=0;

for (i=1; i<=20; i++)
{
     Console.WriteLine($"Digite o {i}º número:");

    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Entrada inválida. Digite um número valido:");
    }
    if (num%2==0)
    {
        quantPares=quantPares+1;
    }
}
Console.WriteLine($"A quantidade Pares informado é: {quantPares}");