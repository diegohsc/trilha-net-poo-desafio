using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("001","1100","0000000001",1024);
nokia.Numero = "987654321";
nokia.InstalarAplicativo("Facebook");

Iphone iphone = new Iphone("002","001","0000000002",2048);
iphone.Numero = "321123456";
iphone.InstalarAplicativo("WhatsApp");

//onsole.WriteLine(iphone.Numero);