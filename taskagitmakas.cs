
public Class taskagitmakas
{

}




public class TasKagitMakas
{
    public string[] secenekler = ["tas", "kagit", "makas"];

    private static Random rnd = new Random();
    public string RastgeleSecim()
    {
        return secenekler[rnd.Next(0, 3)];
    }
    public void kurallariYaz()
    {
        {
            System.Console.WriteLine("     TAŞ-KAĞIT-MAKAS OYUN KURALLARI");
            System.Console.WriteLine("1. Taş, makasi yener.");
            System.Console.WriteLine("2. Makas, kağidi yener.");
            System.Console.WriteLine("3. Kağıt, taşı yener.");
            System.Console.WriteLine("4. Aynı seçimlerde oyun berabere biter.");

            System.Console.WriteLine(" TAŞ-KAĞIT-MAKAS OYUNUNA HOŞ GELDİNİZ! ");
            System.Console.WriteLine("Kurallar: Taş makası kırar, Makas kağıdı keser, Kağıt taşı sarar.");
            System.Console.WriteLine("Oyundan çıkmak için 'çıkış' yazabilirsiniz.");
            System.Console.WriteLine("3 puana ulaşan oyunu kazanır!");
        }
    }
}



