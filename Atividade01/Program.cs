/*1. Soma de dois números
Solicite dois números inteiros e exiba a soma.
Exemplo
Entrada:
10
15
Saída:
A soma é 25.
*/

Console.WriteLine("-------- A SOMA DE DOIS NÚMEROS --------");
int num1;
int num2;
int soma;
Console.WriteLine("Informe o primeiro número inteiro:");
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Digite um número inteiro válido:");
}
Console.WriteLine("Informe o segundo número inteiro:");
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Digite um número inteiro válido:");
}

soma=num1+num2;
Console.WriteLine($" A soma entre {num1} e {num2} é: {soma}");