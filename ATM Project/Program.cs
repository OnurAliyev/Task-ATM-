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
            Console.WriteLine(name + " Xos gelmisiniz :)");
            Console.WriteLine("1)Balansi gostermek");
            Console.WriteLine("2)Balansdan mexaric etmek");
            Console.WriteLine("3)Balansa medaxil etmek");
            Console.WriteLine("0)Hesabdan cixis etmek");
            Console.Write("Etmek istediyiniz emeliyyat nomresini secin : ");
            string secim1 = Console.ReadLine();

            switch (secim1)
            {
                case "1":
                    Console.WriteLine("Balansiniz " + balans + " teskil edir.");
                    break;
                case "2":
                    Console.Write("Mexaric etmek istediyiniz meblegi yazin : ");
                    decimal mexaric = Convert.ToDecimal(Console.ReadLine());
                    if (mexaric > balans)
                    {
                        Console.WriteLine("Daxil etdiyiniz mebleg balansinizda yoxdur...");
                        Console.WriteLine("Zehmet olmasa balansiniza uygun meblegi daxil edin...");
                        Console.WriteLine("Sizin balansiniz " + balans + " teskil edir...");
                    }
                    else if (mexaric <= 0)
                    {
                        Console.WriteLine("Mexaric edilen mebleg 0 ve ya - ola bilmez...");
                    }
                    else
                    {
                        Console.WriteLine("Hesabinizdan " + mexaric + " mexaric olundu...");
                        balans = balans - mexaric;
                        Console.WriteLine("Sizin yeni balansiniz " + balans + " teskil edir");
                    }
                    break;
                case "3":
                    Console.Write("Medaxil etmek istediyiniz meblegi daxil edin : ");
                    decimal medaxil = Convert.ToDecimal(Console.ReadLine());
                    if (medaxil <= 0)
                    {
                        Console.WriteLine("Medaxil edilen mebleg 0 ve ya - ola bilmez...");
                    }
                    else
                    {
                        Console.WriteLine("Hesabiniza " + medaxil + " medaxil olundu...");
                        balans = balans + medaxil;
                        Console.WriteLine("Sizin yeni balansiniz " + balans + " teskil edir...");
                    }
                    break;
            }
            
        }
        
    }
else
{
    Console.WriteLine("Istifadeci adi ve ya sifre duzgun daxil edilmeyib...");
    Console.WriteLine("Zehmet olmasa yeniden giris edin...");
}

