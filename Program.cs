using DesafioPOO.Models;
Console.Clear();

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "G21", imei: "109876", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone(numero: "78910", modelo: "IPhone 13", imei: "65321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine();