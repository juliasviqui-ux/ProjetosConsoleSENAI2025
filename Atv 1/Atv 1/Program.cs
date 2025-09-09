Console.WriteLine("Escreva o valor para A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Escreva o valor de B");
int B = int.Parse(Console.ReadLine()!);
int C;
C = A;
A = B;
B = C;
Console.WriteLine($"Agora, o valor de A = {A}, o valor de B = {B}");