Console.WriteLine("Digite o primeiro valor: ");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
double valor2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor: ");
double valor3 = Convert.ToDouble(Console.ReadLine());
double menor, meio, maior;
if (valor1 < valor2 && valor1 < valor3)
    menor = valor1;
else if (valor2 < valor1 && valor2 < valor3)
    menor = valor2;
else
    menor = valor3;
if (valor1 > valor2 && valor1 > valor3)
    maior = valor1;
else if (valor2 > valor1 && valor2 > valor3)
    maior = valor2;
else
    maior = valor3;
meio = valor1 + valor2 + valor3 - menor - maior;
Console.WriteLine($"\nValores em ordem crescente: {menor}, {meio}, {maior}");