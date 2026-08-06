/*11. Soma até digitar zero
Leia números inteiros.
Quando o usuário digitar zero, encerre o programa mostrando a soma dos valores digitados.*/

Console.WriteLine("------------- SOMA ATÉ DIGITAR ZERO -------------");

int num;
int soma=0;

do
{
Console.WriteLine("Digite o número que deseja incluir na soma:");  
while(!int.TryParse(Console.ReadLine(), out num))
    {
       Console.WriteLine("Entrada inválida. Digite um número inteiro:");
    }
soma=soma+num;

}
while(num!= 0);

Console.WriteLine($"A soma dos valores é {soma}");