/*18. Jogo da senha
Gere um número aleatório entre 1 e 100.
Informe ao usuário se o número digitado é maior ou menor que o número sorteado até que ele acerte.*/

Console.WriteLine(" ------------- JOGO DA SENHA -------------");

Random sorteio = new Random();

int numero = sorteio.Next(1, 101);
int numChute;

do
{
Console.Write("Digite um número de 1 a 100: ");
while (!int.TryParse(Console.ReadLine(), out numChute))
    {
        Console.WriteLine("Entrada inválida. Digite um número inteiro:");
    }
if (numChute == numero)
{
    Console.WriteLine("Parabéns! Você acertou!");
}
else if (numChute>numero)
{
  Console.WriteLine("O número digitado é maior do que o número sorteado. Tente Novamente!"); 
}
else 
{
  Console.WriteLine("O número digitado é menor do que o número sorteado.Tente Novamente!");
}
}
while (numChute!=numero);