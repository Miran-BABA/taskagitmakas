


=======
// rastgele degisken
// 1 tanesi atansin

public class TasKagitMakas
{
    public string[] secenekler = ["tas", "kagit", "makas"];

    private static Random rnd = new Random();
    public string RastgeleSecim()
    {
        return secenekler[rnd.Next(0, 3)];
    }
     public void exitProgram()
    {
        string button = Console.ReadLine();
        if (button == "k")
        {
            Console.WriteLine("Taş kağıt makas programı sonlandırıldı.");
            Environment.Exit(0);
        }
    }
}
>>>>>>> aa33d33a94c9d1910c4d2f7796e55423133ff751
