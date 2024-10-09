using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("91234-5678", "modelo 1", "123456789", 8);
Iphone iphone = new Iphone("97891-5678", "modelo 1", "123456789", 6);

iphone.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Whatsapp");