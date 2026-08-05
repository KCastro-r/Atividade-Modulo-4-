/*10. Login simples
Solicite usuário e senha.
Enquanto a senha estiver incorreta, peça novamente.*/

Console.WriteLine("------------ LOGIN ------------");
string? senha;
string? usuario;
string usuarioCorreto = "kenia";
string senhaCorreta = "1234";

do
{
    Console.Write("Digite o usuário: ");
    usuario = Console.ReadLine();

    Console.Write("Digite a senha: ");
    senha = Console.ReadLine();

    if (usuario != usuarioCorreto && senha != senhaCorreta)
    {
        Console.WriteLine("Usuário e senha incorretos!");
    }
    else if (usuario == usuarioCorreto && senha != senhaCorreta)
    {
        Console.WriteLine("Senha está incorreta!");
    }
    else if (usuario != usuarioCorreto && senha == senhaCorreta)
    {
        Console.WriteLine("Usuário está incorreto!");
    }

} while (usuario != usuarioCorreto || senha != senhaCorreta);

Console.WriteLine("Login realizado com sucesso!");