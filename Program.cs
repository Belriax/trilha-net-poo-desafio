using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia("949870214", "Nokia Windows Phone", "120154/547", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone("97457410", "Iphone 15s", "1245781321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");