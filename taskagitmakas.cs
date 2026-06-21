
<<<<<<< HEAD
public Class taskagıtmakas{
    
}

{
print("     TAŞ-KAĞIT-MAKAS OYUN KURALLARI")
print("1. Taş, makası yener.")
print("2. Makas, kağıdı yener.")
print("3. Kağıt, taşı yener.")
print("4. Aynı seçimlerde oyun berabere biter.")

print(" TAŞ-KAĞIT-MAKAS OYUNUNA HOŞ GELDİNİZ! ")
    print("Kurallar: Taş makası kırar, Makas kağıdı keser, Kağıt taşı sarar.")
    print("Oyundan çıkmak için 'çıkış' yazabilirsiniz.")
    print("3 puana ulaşan oyunu kazanır!")
}
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
}

