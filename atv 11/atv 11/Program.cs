using System.ComponentModel.Design;

Console.WriteLine("Digite o ano atual: ");
int AnoAtual = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o ano de nascimento: ");
int AnoNascimento = Convert.ToInt32(Console.ReadLine());
int idade = AnoAtual - AnoNascimento;
Console.WriteLine("\nIdade calculada: " + "anos");
if (idade < 16)
{
    Console.WriteLine($"\nVocê tem {idade} anos. Não pode votar.");
}
else if (idade < 18 & idade >= 70)
{
    Console.WriteLine($"\nVocê tem {idade} anos. Seu voto é facultativo.");
}
else 
{
    Console.WriteLine($"\nVocê tem {idade} anos. O seu voto é obrigatório");
}
