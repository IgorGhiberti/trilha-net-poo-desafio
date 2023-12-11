using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "(61) 3586-7878", modelo: "iPhone 13 Pro Max", imei: "354813764621957", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "(13) 3486-7908", modelo: "Nokia 9 PureView", imei: "414513064691937", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("YouTube");

