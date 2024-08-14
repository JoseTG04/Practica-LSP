
namespace Practica_LSP
{
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
