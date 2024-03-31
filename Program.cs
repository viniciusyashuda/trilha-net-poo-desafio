using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia("12345", "Tijolao", "111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone("5697", "IPhone 13", "222222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");