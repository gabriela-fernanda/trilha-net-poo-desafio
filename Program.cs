using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "987456", modelo: "Modelo 1", imei: "1111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone: ");
Smartphone iphone = new Iphone(numero: "657895", modelo: "Modelo 2", imei: "2222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");