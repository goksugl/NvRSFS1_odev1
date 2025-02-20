// See https://aka.ms/new-console-template for more information

// 5. Şifre Güçlülüğünü Kontrol Etme

using System.Text.RegularExpressions;

    Console.Write("Şifre girin: ");
    string password = Console.ReadLine();

    if (password.Length < 8)
    {
        Console.WriteLine("Şifre en az 8 karakter olmalı!");
        return;
    }

    if (!Regex.IsMatch(password, @"[A-Z]"))
    {
        Console.WriteLine("Şifre en az bir büyük harf içermeli!");
        return;
    }

    if (!Regex.IsMatch(password, @"[@#$%]"))
    {
        Console.WriteLine("Şifre en az bir özel karakter (@, #, $, %) içermeli!");
        return;
    }

    Console.WriteLine("Güçlü şifre!");
