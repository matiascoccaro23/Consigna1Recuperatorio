using System;

class Consigna1Recuperatorio
{
    static void Main()
    {
        Console.WriteLine("Ingrese el valor del radio del cilindro:");
        if (!double.TryParse(Console.ReadLine(), out double radio) || radio <= 0)
        {
            Console.WriteLine("Error: El valor del radio debe ser un número positivo.");
            return;
        }

        Console.WriteLine("Ingrese el valor de la altura del cilindro:");
        if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0)
        {
            Console.WriteLine("Error: El valor de la altura debe ser un número positivo.");
            return;
        }

        double volumen = Math.PI * Math.Pow(radio, 2) * altura;
        double superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;
        Console.WriteLine($"Resultados:");
        Console.WriteLine($"Volumen del cilindro: {volumen:F2}");
        Console.WriteLine($"Superficie del cilindro: {superficie:F2}");
    }
}

