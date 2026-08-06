/*15. Média de um vetor
Leia 8 notas e calcule a média.*/

Console.WriteLine("------------ Média DE UM VETOR ------------");

double [] notas = new double[8];
int i;
double media;
double somaNotas=0;

for (i = 0; i < 8; i++)
{
    Console.WriteLine($"Digite a {i + 1}º nota:");

    while (!double.TryParse(Console.ReadLine(), out notas[i]))
    {
        Console.WriteLine("Entrada inválida. Digite uma nota válida:");
    }
    somaNotas=somaNotas+notas[i];
}
media=somaNotas/8;
Console.WriteLine($"A média das 8 notas é: {media}");