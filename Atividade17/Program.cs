/*17. Ordem inversa
Leia 10 números e exiba-os na ordem inversa.*/

Console.WriteLine("------------- ORDEM INVERSA ------------- ");
int[] numeros = new int[10];
int i;

for (i=0; i<10; i++)
{
     Console.WriteLine($"Digite o {i+1}º número:");

    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
    {
        Console.WriteLine("Entrada inválida. Digite um número inteiro:");
    }
}
for (i=9; i>=0; i--)
{
    Console.WriteLine($"O {i+1}º número digitado foi: {numeros[i]}");
}