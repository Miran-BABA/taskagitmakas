
public class taskagıtmakas{
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
