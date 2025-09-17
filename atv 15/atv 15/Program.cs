Console.WriteLine("Números entre 1.000 e 2.000 que quando divididos por 11, deixam o resto 5: ");
for (int i = 1000; i <= 2000; i++)
{
    if (i % 11 == 5) 
    {
        Console.WriteLine(i);
    }
}
