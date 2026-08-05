/*4. Conversor de moedas
Leia um valor em reais e a cotação do dólar.
Mostre quanto esse valor representa em dólares.*/

Console.WriteLine("------- CONVERSOR DE MOEDAS ------- ");
double valorReais;
double conversao;
double cotacaoDollar;

Console.WriteLine("Digite o valor em reais que deseja converter:");
while(!double.TryParse(Console.ReadLine(), out valorReais))
{
     Console.WriteLine("Digite um valor em reais válido:"); 
}

Console.WriteLine("Digite o valor da cotação do dólar DIA:");
while(!double.TryParse(Console.ReadLine(), out cotacaoDollar))
{
   Console.WriteLine("Digite o valor da cotação dolar válido:");  
}

conversao=cotacaoDollar*valorReais;

Console.WriteLine($"A conversão de R$ {valorReais} em dólares é: US$ {conversao}.");