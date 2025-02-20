// See https://aka.ms/new-console-template for more information

// 1. Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme

    Console.Write("Bir sayı girin: ");
    double number = Convert.ToDouble(Console.ReadLine());

    if (number > 0) Console.WriteLine("Pozitif sayı.");
    else if (number < 0) Console.WriteLine("Negatif sayı.");
    else Console.WriteLine("Sıfır.");
