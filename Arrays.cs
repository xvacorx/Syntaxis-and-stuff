int[] Numeros = new int[5];
Console.WriteLine("Ingrese 5 números");
for (int i = 0; i < 5; i++)
{
    Numeros[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Los números son:");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(Numeros[i]);
}
