// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una edad");
int edad = int.Parse(Console.ReadLine());
while (edad > 0)
{
    if (edad < 18)
    {
        Console.WriteLine($"No puedes votar. La edad de la persona es: {edad}");
    }
    else if (edad >= 18 && edad < 70)
    {
        Console.WriteLine($"Puedes votar. La edad de la persona es: {edad}");   //Puedes votar   
    }
    else if (edad >= 70)
    {
        Console.WriteLine($"Puedes votar, pero es opcional. La edad de la persona es: {edad}");
    }
    Console.WriteLine("Ingrese una nueva edad");
    edad = int.Parse(Console.ReadLine());
}