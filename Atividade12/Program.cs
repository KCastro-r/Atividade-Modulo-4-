/*12. Contador de caracteres
Leia um nome e informe quantos caracteres ele possui.*/

Console.WriteLine("-------------- CONTADOR DE CARACTERES -------------- ");

string? nome;
int quantidadeCaracteres;
Console.WriteLine("Informe o seu nome completo:");
nome=Console.ReadLine();
if (nome!="")
{
    nome = nome.Trim().Replace(" ", "");
    quantidadeCaracteres = nome.Length;
    Console.WriteLine($"A quantidade de caracteres do nome informado: {quantidadeCaracteres}");
}
else
{
    Console.WriteLine("Nenhum nome foi informado. Digite um valor válido.");
}


