// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una nueva edad");
int edad = int.Parse(Console.ReadLine());
while (edad > 0)
{
    if (edad < 18)
    {
        Console.WriteLine($"La persona no puede votar, tiene: {edad} años ");
    }
    else if (edad >= 18 && edad < 70)
    {
        Console.WriteLine($"La persona puede votar, tiene: {edad} años ");
    }
    else if (edad >= 70)
    {
        Console.WriteLine($"La persona puede votar, pero es opcional. Tiene: {edad} años");
    }
    Console.WriteLine("Ingrese una nueva edad");
    edad = int.Parse(Console.ReadLine());
}