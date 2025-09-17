Console.WriteLine("Digite um valor N: ");
int N = int.Parse(Console.ReadLine());
if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("O valor de N deve ser meior que zero.");
}

