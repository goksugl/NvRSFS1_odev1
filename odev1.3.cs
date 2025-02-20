// See https://aka.ms/new-console-template for more information

// 3. Basit Hesap Makinesi

    Console.Write("Birinci sayıyı girin: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("İkinci sayıyı girin: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("İşlem seçin (+, -, *, /): ");
    char operation = Convert.ToChar(Console.ReadLine());

    switch (operation)
    {
        case '+': Console.WriteLine($"Sonuç: {num1 + num2}"); break;
        case '-': Console.WriteLine($"Sonuç: {num1 - num2}"); break;
        case '*': Console.WriteLine($"Sonuç: {num1 * num2}"); break;
        case '/':
            if (num2 != 0) Console.WriteLine($"Sonuç: {num1 / num2}");
            else Console.WriteLine("Sıfıra bölme hatası!");
            break;
        default: Console.WriteLine("Geçersiz işlem!"); break;
    }


