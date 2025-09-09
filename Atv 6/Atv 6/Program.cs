Console.WriteLine("Digite o salário atual do funcionário : R$ ");
double SalarioAtual = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o percentual de reajuste (%): ");
double percentualReajuste  = Convert.ToDouble(Console.ReadLine());
double NovoSalario = SalarioAtual + (SalarioAtual * percentualReajuste / 100);
Console.WriteLine("\nO novo salário é: R$ " +  NovoSalario.ToString("F2"));
