// See https://aka.ms/new-console-template for more information

// 4. Üç Sayının En Büyüğünü Bulma

    Console.Write("Birinci sayıyı girin: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("İkinci sayıyı girin: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Üçüncü sayıyı girin: ");
    double num3 = Convert.ToDouble(Console.ReadLine());

    double max = num1;
    if (num2 > max) max = num2;
    if (num3 > max) max = num3;

    Console.WriteLine($"En büyük sayı: {max}");

