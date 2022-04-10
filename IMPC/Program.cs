using IMPC.Clases;

ClsIMC im = new ClsIMC();
String _nombre;
int _edad, _altura, _peso;
char _sexo;
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

Console.Write("Ingrese su nombre: ");
_nombre = Console.ReadLine();
Console.Write("Ingrese su edad: ");
_edad = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese su sexo: ");
_sexo = Convert.ToChar(Console.ReadLine());
Console.Write("Ingrese su altura en cm: ");
_altura = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese su peso en libras: ");
_peso = Convert.ToInt32(Console.ReadLine());
Console.Clear();

im.prueba(_nombre, _edad, _sexo, _altura, _peso);

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

