using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "303 505 7824", modelo: "Modelo XY", imei: "777777777", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "987654321", modelo: "Modelo 27", imei: "333333333", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");