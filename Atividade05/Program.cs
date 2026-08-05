/*5. Calculadora simples
Solicite dois números e mostre:
● Soma
● Subtração
● Multiplicação
● Divisão*/

Console.WriteLine("------ CALCULADORA SIMPLES ------");
int num1;
int num2;
int soma;
int subtracao;
int multiplicacao;
double divisao;

Console.WriteLine("Informe o primeiro número:");
while(!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Informe um número válido:");
}
Console.WriteLine("Informe o segundo número:");
while(!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Informe um número válido:");
}
soma= num1+num2;
subtracao=num1-num2;
multiplicacao=num1*num2;
Console.WriteLine($"A soma entre {num1} e {num2} é: {soma}");
Console.WriteLine($"A subtração entre {num1} e {num2} é: {subtracao}");
Console.WriteLine($"A multiplicação entre {num1} e {num2} é: {multiplicacao}");
if (num2==0)
{
    Console.WriteLine($" A divisão entre {num1} e {num2}: Não é possível fazer divisão por zero");
}
else
{
    divisao=(double)num1/num2;
    Console.WriteLine($"A divisão entre {num1} e {num2} é: {divisao}");
}
 