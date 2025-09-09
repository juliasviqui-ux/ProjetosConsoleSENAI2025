Console.WriteLine("Digite sua idade em anos: ");
int anos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite os meses: ");
int meses = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite os dias: ");
int dias = Convert.ToInt32(Console.ReadLine());
int idadeEmDias= (anos * 365) + (meses * 30) + dias;
Console.WriteLine("Sua idade em dias é: " + idadeEmDias);