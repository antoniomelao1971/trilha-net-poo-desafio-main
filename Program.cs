using DesafioPOO.Models;
class Desafio_POO
{
    public static void Main()
    {

        // TODO: Realizar os testes com as classes Nokia e Iphone
        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia("21999183033", "N32", "147258369", 2);
        nokia.Ligar();
        nokia.InstalarAplicativo("Nibbles");

        Console.WriteLine("/n");

        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone("21972873597", "iPhone 12", "357951456", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}