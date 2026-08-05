/*3. Área de um retângulo
Solicite:
● Base
● Altura
Calcule:
● Área
● Perímetro*/

Console.WriteLine("-------Área de um retângulo-------");

double baseRetangulo;
double altura;
double area;
double perimetro;

Console.WriteLine("Informe o valor da base:");
while(!double.TryParse(Console.ReadLine(), out baseRetangulo))
{
    Console.WriteLine("Digite um número válido:"); 
}

Console.WriteLine("Informe o valor da altura:");
while(!double.TryParse(Console.ReadLine(), out altura ))
{
    Console.WriteLine("Digite um número válido:"); 
}
area = baseRetangulo * altura;
perimetro=((baseRetangulo*2)+(altura*2));

Console.WriteLine($"A área do Retângulo é {area} e o seu Perímetro é {perimetro}.");