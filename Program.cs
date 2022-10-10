using DesafioPOO.Models;
Console.Clear();

// TODO: Realizar os testes com as classes Nokia e Iphone


Smartphone nokia = new Nokia("98856-5689", "MK 358", "5565989898989", 50 );
Smartphone iphone = new Iphone("99138-3002", "Iphone 10", "5565989898981", 50 );

nokia.Ligar();
nokia.InstalarAplicativo("Watsapp");
Console.WriteLine();    
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Sinuca");
Console.WriteLine();

