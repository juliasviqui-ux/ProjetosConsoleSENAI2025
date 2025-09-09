Console.WriteLine("Digite o primeiro valor: ");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
double valor2  = Convert.ToDouble(Console.ReadLine());
if (valor1 > valor2)
{
    Console.WriteLine($"\nO maior valor é: {valor1}");
}
else
{
    Console.WriteLine($"\nO maior valor é: {valor2}");
}