using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola desde C#!");
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}! Bienvenido a C#.");
    }
}
