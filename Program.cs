using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        
        
            Nokia nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");
            Console.WriteLine("\n");
            Iphone iPhone = new Iphone("4987", "Modelo 2", "222222222", 128);
            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Telegram");


        
    }
}