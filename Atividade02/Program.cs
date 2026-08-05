/*2. Antecessor e sucessor
Leia um número inteiro e mostre:
● Antecessor
● Número informado
● Sucessor*/



Console.WriteLine("------ Antecessor e sucessor ------");

int num;
int antecessor;
int sucessor;
Console.WriteLine("Informe um número inteiro:");
while(!int.TryParse(Console.ReadLine(), out num))
{
  Console.WriteLine("Digite um número inteiro válido:");  
}
antecessor=num-1;
sucessor=num+1;
Console.WriteLine($"Para o número:{num}, o Antecessor é {antecessor} e o sucessor é {sucessor}");