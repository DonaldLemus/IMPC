using IMPC.Clases;

ClsIMC im = new ClsIMC("Donald", 20, 177, 'M', 130);



 void tabla()
{
    Console.WriteLine("Según su edad su IMC recomendado cambiará, consulte la siguiente tabla");
    Console.WriteLine("Edad     ||    IMC");
    Console.WriteLine("19-24    ||  19-24");
    Console.WriteLine("25-34    ||  20-25");
    Console.WriteLine("35-44    ||  21-26");
    Console.WriteLine("45-54    ||  22-27");
    Console.WriteLine("55-64    ||  23-28");
    Console.WriteLine("65 o más ||  24-29");
}
im.prueba();
Console.WriteLine(im.ToString());
Console.WriteLine(im.resultados());
Console.WriteLine("          Recomendaciones de Alimentación");
Console.WriteLine(im.recomendacionesAlimentacion());
Console.WriteLine("          Recomendaciones Fisicas");
Console.WriteLine(im.recomendacionesFisicas());
if(im.edad >= 19)
{
   tabla();
}

