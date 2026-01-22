// Clase base abstracta
public abstract class Figura
{
    // Método abstracto para calcular el área
    public abstract double CalcularArea();

    // Método abstracto para calcular el perímetro
    public abstract double CalcularPerimetro();
}

// Clase Rectangulo
public class Rectangulo : Figura
{
    public double BaseRectangulo { get; set; }
    public double Altura { get; set; }

    public Rectangulo(double baseRectangulo, double altura)
    {
        BaseRectangulo = baseRectangulo;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return BaseRectangulo * Altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (BaseRectangulo + Altura);
    }
}

// Clase Circulo
public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo(5, 3);
        Circulo circulo = new Circulo(4);

        Console.WriteLine("RECTÁNGULO");
        Console.WriteLine("Área: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());

        Console.WriteLine("\nCÍRCULO");
        Console.WriteLine("Área: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

        Console.ReadKey();
    }
}
