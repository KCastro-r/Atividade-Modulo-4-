/*9. Soma dos números pares
Calcule a soma de todos os números pares entre 1 e 100.*/

Console.WriteLine ("------------ SOMA DOS PARES------------");
int somaPares=0;
int i;
for (i=1; i<=100; i++)
{
    if (i%2==0)
    {
        somaPares=somaPares+i;
    }
}
 Console.WriteLine($"a soma de todos os números pares entre 1 e 100 é: {somaPares}");