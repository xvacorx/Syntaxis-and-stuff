//Escribe un programa en C# que le pida al usuario que ingrese una cadena de texto y cuente cuántas veces aparece una letra específica en ella.

int Cantidad = 0;

Console.WriteLine("Ingrese una cadena de texto:");
string Texto = Console.ReadLine();

Console.WriteLine("Ingrese la letra que desea contar:");
char Letra = char.Parse(Console.ReadLine());

foreach (char Caracter in Texto)
{
    if (Caracter == Letra) { Cantidad++; }
}

Console.WriteLine("La letra " + Letra + " aparece " +  Cantidad + " de veces en el texto");
