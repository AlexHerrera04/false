using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hola desde C#! Este es un programa simple en una terminal de Windows.");
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola, {nombre}! Bienvenido a C#.");
    }
}
