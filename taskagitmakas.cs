using System;

public class TasKagitMakas
{
    private string rastegelVeri;
    public string[] secenekler = ["tas", "makas", "kagit"];

    private static Random rnd = new Random();
    private void RastgeleSecim()
    {
        rastegelVeri = secenekler[rnd.Next(0, 3)];
    }

    public void secimYap(string secilenVeri)
    {
        RastgeleSecim();
        Console.WriteLine($"Sizin seciminiz: {secilenVeri}, bilgisayarin secimi: {rastegelVeri}");

        if (rastegelVeri == secilenVeri)
        {
            Console.WriteLine("Berabere kaldiniz");
        }
        else if (rastegelVeri == secenekler[0] && secilenVeri == secenekler[1])
        {
            Console.WriteLine("Ne yazik ki kaybettiniz...");
        }
        else if (rastegelVeri == secenekler[1] && secilenVeri == secenekler[0])
        {
            Console.WriteLine("Kazandiniz!");
        }
        else if (rastegelVeri == secenekler[0] && secilenVeri == secenekler[2])
        {
            Console.WriteLine("Kazandiniz!");
        }
        else if (rastegelVeri == secenekler[2] && secilenVeri == secenekler[0])
        {
            Console.WriteLine("Ne yazik ki kaybettiniz...");
        }
        else if (rastegelVeri == secenekler[1] && secilenVeri == secenekler[2])
        {
            Console.WriteLine("Ne yazik ki kaybettiniz...");
        }
        else if (rastegelVeri == secenekler[2] && secilenVeri == secenekler[1])
        {
            Console.WriteLine("Kazandiniz!");
        }
    }


    public void kurallariYaz()
    {
        Console.WriteLine("     TAŞ-KAĞIT-MAKAS OYUN KURALLARI");
        Console.WriteLine("1. Taş, makasi yener.");
        Console.WriteLine("2. Makas, kağidi yener.");
        Console.WriteLine("3. Kağıt, taşı yener.");
        Console.WriteLine("4. Aynı seçimlerde oyun berabere biter.");

        Console.WriteLine(" TAŞ-KAĞIT-MAKAS OYUNUNA HOŞ GELDİNİZ! ");
        Console.WriteLine("Kurallar: Taş makası kırar, Makas kağıdı keser, Kağıt taşı sarar.");
        Console.WriteLine("Oyundan çıkmak için 'çıkış' yazabilirsiniz.");
        Console.WriteLine("3 puana ulaşan oyunu kazanır!");
    }
<<<<<<< HEAD

=======
}

class Program()
{
    static void Main(string[] args)
    {
        TasKagitMakas tkm = new TasKagitMakas();
        tkm.kurallariYaz();

        Console.Write("Lutfen tas(0) makas(1) kagit(2) seciniz: ");
        string secim = tkm.secenekler[int.Parse(Console.ReadLine())];

        tkm.secimYap(secim);
    }
>>>>>>> 104bbf9497aedf07de20405a2ea4e86406098a27
}