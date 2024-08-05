using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("5 - Mod Alma");
            Console.WriteLine("0 - Çıkış");

            string secim = Console.ReadLine();

            switch (secim)
            {
                // ilk 4 case için 2 input ve bu inputların double olma koşulu
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("İlk sayıyı girin:");
                    double sayi1 = GetDoubleFromUser();

                    Console.WriteLine("İkinci sayıyı girin:");
                    double sayi2 = GetDoubleFromUser();

                    if (secim == "1")
                    {
                        double toplam = sayi1 + sayi2;
                        Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {toplam}");
                    }
                    else if (secim == "2")
                    {
                        double fark = sayi1 - sayi2;
                        Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {fark}");
                    }
                    else if (secim == "3")
                    {
                        double carpim = sayi1 * sayi2;
                        Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {carpim}");
                    }
                    else if (secim == "4")
                    {
                        if (sayi2 == 0)
                        {
                            // sıfır kontrolü
                            Console.WriteLine("Hata: Bölen 0 olamaz!");
                        }
                        else
                        {
                            double bolum = sayi1 / sayi2;
                            Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {bolum}");
                        }
                    }
                    break;

                case "5":
                    Console.WriteLine("İlk sayıyı girin:");
                    int sayiA = GetIntegerFromUser();

                    Console.WriteLine("İkinci sayıyı girin:");
                    int sayiB = GetIntegerFromUser();

                    int mod = sayiA % sayiB;
                    Console.WriteLine($"Sonuç: {sayiA} % {sayiB} = {mod}");
                    break;

                case "0":
                    Console.WriteLine("Programdan çıkılıyor...");
                    return;
//return komutu uygulamayı sonlandırıyor
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin."); //verilen 6 caseden farklı bir case seçme durumunda uygulamayı tekrar başa döndürüyor
                    break;
            }
        }
    }
//Sayının double olduğunun kontrolü
    static double GetDoubleFromUser()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin:");
            }
        }
    }

  // Sayının integer olduğunun kontrolü 
    static int GetIntegerFromUser()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir tamsayı girin:");
            }
        }
    }
}
