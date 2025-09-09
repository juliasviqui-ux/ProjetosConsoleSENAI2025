Console.WriteLine("Escreva a quantidade maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());
if (quantidade < 12)
{
    Console.WriteLine("O valor unitário de cada maçã vai ser R$1,30)");
}
else
{
    Console.Write("O valor da maçã vai ser R$1,00");
}