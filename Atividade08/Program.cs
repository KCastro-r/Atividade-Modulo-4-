/*8. Tabuada
Solicite um número e exiba sua tabuada de 1 a 10.*/

Console.WriteLine("------------ TABUADA------------");

int num;
int i;
int resultado;
Console.WriteLine("Informe o número para o calculo da Tabuada:");
while(!int.TryParse(Console.ReadLine(), out num))
{
    Console.WriteLine("Valor informado inválido. Favor informar um número inteiro:");
}
Console.WriteLine($"A tabuada é:");
for (i=1; i<=10; i++)
{
    resultado=num*i;
    Console.WriteLine($"{num} x {i} = {resultado}");
}