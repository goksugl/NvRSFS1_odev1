// See https://aka.ms/new-console-template for more information


// 2.Gün İsmi Belirleme (switch-case)

Console.Write("1-7 arasında bir sayı girin: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("Pazartesi"); break;
    case 2: Console.WriteLine("Salı"); break;
    case 3: Console.WriteLine("Çarşamba"); break;
    case 4: Console.WriteLine("Perşembe"); break;
    case 5: Console.WriteLine("Cuma"); break;
    case 6: Console.WriteLine("Cumartesi"); break;
    case 7: Console.WriteLine("Pazar"); break;
    default: Console.WriteLine("Geçersiz gün!"); break;
}

