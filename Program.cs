using DesafioPOO.Models;

//IMPLEMENTADO!!!!!!!!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "(87) 9 4375-4382", modelo: "Modelo G10", imei: "543656347", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "(81) 9 9804-3748", modelo: "Modelo IOS 15", imei: "43242355", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");




