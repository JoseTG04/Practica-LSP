using Practica_LSP;

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 4 };
        Cuadrado cuadrado = new Cuadrado { Lado = 5 };

        Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");

        // Demostración con LSP
        FiguraGeometrica figuraComoRectangulo = new Rectangulo { Base = 5, Altura = 4 };
        FiguraGeometrica figuraComoCuadrado = new Cuadrado { Lado = 5 };

        Console.WriteLine($"Área de la figura como rectángulo: {figuraComoRectangulo.CalcularArea()}");
        Console.WriteLine($"Área de la figura como cuadrado: {figuraComoCuadrado.CalcularArea()}");
    }
}