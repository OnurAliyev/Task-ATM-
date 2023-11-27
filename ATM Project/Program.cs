Console.WriteLine("Xos gelmisiniz :)");
Console.WriteLine("Zehmet olmasa istifadeci adi ve sifrenizi daxil edin..");
Console.Write("Istifadeci adi : ");
string username = Console.ReadLine();
Console.Write("Parol : ");
string password = Console.ReadLine();
string name = "Onur Aliyev";
decimal balans = 10000;

if (username == "Onur" && password == "Onur0101")
    while (true)
    {
        {
            Console.WriteLine("**********************************************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(name + " Xos gelmisiniz :)");
            Console.ResetColor();
            Console.WriteLine("1)Balansi gostermek");
            Console.WriteLine("2)Balansdan mexaric etmek");
            Console.WriteLine("3)Balansa medaxil etmek");
            Console.WriteLine("0)Hesabdan cixis etmek");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Etmek istediyiniz emeliyyat nomresini secin : ");
            Console.ResetColor();
            string secim1 = Console.ReadLine();

            switch (secim1)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Balansiniz " + balans + " teskil edir.");
                    Console.ResetColor();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Mexaric etmek istediyiniz meblegi yazin : ");
                    Console.ResetColor();
                    decimal mexaric = Convert.ToDecimal(Console.ReadLine());
                    if (mexaric > balans)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Daxil etdiyiniz mebleg balansinizda yoxdur...");
                        Console.WriteLine("Zehmet olmasa balansiniza uygun meblegi daxil edin...");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sizin balansiniz " + balans + " teskil edir...");
                        Console.ResetColor();
                    }
                    else if (mexaric <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Mexaric edilen mebleg 0 ve ya - ola bilmez...");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Hesabinizdan " + mexaric + " mexaric olundu...");
                        Console.ResetColor();
                        balans = balans - mexaric;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sizin yeni balansiniz " + balans + " teskil edir");
                        Console.ResetColor();
                    }
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Medaxil etmek istediyiniz meblegi daxil edin : ");
                    Console.ResetColor();
                    decimal medaxil = Convert.ToDecimal(Console.ReadLine());
                    if (medaxil <= 0)
                    {
                        Console.ForegroundColor= ConsoleColor.DarkRed;
                        Console.WriteLine("Medaxil edilen mebleg 0 ve ya - ola bilmez...");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("Hesabiniza " + medaxil + " medaxil olundu...");
                        Console.ResetColor();
                        balans = balans + medaxil;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sizin yeni balansiniz " + balans + " teskil edir...");
                        Console.ResetColor();
                    }
                    break;
            }
            
        }
        
    }
else
{
    Console.ForegroundColor = ConsoleColor.Red ;
    Console.WriteLine("Istifadeci adi ve ya sifre duzgun daxil edilmeyib...");
    Console.WriteLine("Zehmet olmasa yeniden giris edin...");
    Console.ResetColor();
}

