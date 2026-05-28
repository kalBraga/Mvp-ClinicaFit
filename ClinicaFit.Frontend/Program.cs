using System;

/* Dados de login e acesso ao sistema*/
string UserCorreto = "adminfit";
string SenhaCorreta = "Clinicafit!420";

Console.WriteLine("======================================");
Console.WriteLine("   Bem Vindo ao Sistema ClinicaFit!   ");
Console.WriteLine("======================================");
Console.WriteLine();

/* Campo para digitação de credencial do usuario para iniciar a validação*/
Console.WriteLine("Por gentileza, informe o seu Usuario: ");
string? UserDigitado = Console.ReadLine();

Console.WriteLine("Por gentileza, informe a sua Senha: ");
string? SenhaDigitada = Console.ReadLine();

/*Validação das credenciais digitadas*/

if(UserDigitado == UserCorreto && SenhaDigitada == SenhaCorreta)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("=============");
    Console.WriteLine("   SUCESSO   ");
    Console.WriteLine("=============");

    Console.WriteLine("Acesso Autorizado! Usuario logado.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("=============");
    Console.WriteLine("   Negado!   ");
    Console.WriteLine("=============");

    Console.WriteLine("Acesso Negado! Credenciais invalidadas.");
}
