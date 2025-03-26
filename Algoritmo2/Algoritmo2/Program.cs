int idade = 24;
string nomeCliente = "Gabriel";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Gabriel Augusto Kappenberg";
var altura = 165;
Console.Write("Digite seu nome:");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo " + nomeCompleto);
Console.WriteLine();
Console.Write("Digite sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);    //Parse converte linhas em numenos
Console.WriteLine("Idade informada: " + idade);
if (idade < 18) 
    Console.WriteLine("Usuário menor de idade, acesso negado.");
Console.ReadKey();