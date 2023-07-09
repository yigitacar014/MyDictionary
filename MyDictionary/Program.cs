// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<string> kitaplar = new List <string>();
kitaplar.Add("Polisiye");
kitaplar.Add("Macera");
kitaplar.Add("Aksiyon");
kitaplar.Add("Psikoloji");

foreach (var item in kitaplar)
{
    Console.WriteLine(item);
}