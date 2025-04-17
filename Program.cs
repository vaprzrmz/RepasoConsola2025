// See https://aka.ms/new-console-template for more information
using RepasoConsola2025;

Lapiz nuevoObjeto = new Lapiz();

Console.WriteLine(nuevoObjeto.TipoDeGrafito);
Console.WriteLine(nuevoObjeto.TieneGoma);
Console.WriteLine(nuevoObjeto.Color);
Console.WriteLine("Lapiz nuevo");
Console.ReadLine();

var resultadoObjeto = Lapiz.LapizMordido(nuevoObjeto);
Console.WriteLine(nuevoObjeto.TipoDeGrafito);
Console.WriteLine(nuevoObjeto.TieneGoma);
Console.WriteLine(nuevoObjeto.Color);
Console.WriteLine("Lapiz Mordido");
Console.ReadLine();










