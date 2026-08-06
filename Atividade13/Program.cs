/*13. Verificador de senha
Solicite uma senha.
Informe se ela possui pelo menos 8 caracteres.*/

Console.WriteLine("---------- VERIFICADOR DE SENHA ----------");

string? senha;
int quantidadeCaracter;

Console.WriteLine("Digite a senha:");
senha=Console.ReadLine();
if ((senha!="") && (senha!=null))
{
 quantidadeCaracter=senha.Length;
if (quantidadeCaracter>=8)
{
   Console.WriteLine("Senha Válida pois ela possui pelo menos 8 caracteres.");
} 
else
{
    Console.WriteLine("Senha inVálida pois ela não possui pelo menos 8 caracteres.");
}  
}
