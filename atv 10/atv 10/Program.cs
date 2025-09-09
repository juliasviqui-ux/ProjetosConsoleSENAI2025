Console.WriteLine("Digite a nota da primeria avaliação: ");
double nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a nota da segunda valiação: ");
double nota2 = Convert.ToDouble(Console.ReadLine());
double media = (nota1 + nota2) / 2;
Console.WriteLine("\nMédia do aluno: " + media.ToString("F2"));
if (media >= 6)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno Reprovado!");
}