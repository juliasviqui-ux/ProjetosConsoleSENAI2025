Console.WriteLine("digite um valor n: ");
int n = int.Parse(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("Fatorial de número negativo não existe.");
}
else if (n == 0)
{
    Console.WriteLine("0! = 1");
}
else
{
    long fatorial = 1; // uso long para suportar números maiores
    for (int i = 1; i <= n; i++)
    {
        fatorial *= i; // multiplica o valor atual pelo contador
    }
    Console.WriteLine($"{n}! = {fatorial}");
}