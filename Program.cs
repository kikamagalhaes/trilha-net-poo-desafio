using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("12345678", "Modelo 1", "11111111111",  64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "98765432", modelo: "Modelo 2",imei: "222222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");