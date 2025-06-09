// Nombre: Robert Reyes
// Fecha: 09/06/2025
// Número de hoja: 1

using System;

namespace FigurasGeometricas
{
    // Clase que representa un Círculo
    public class Circulo
    {
        // Campo privado para el radio del círculo
        private double radio;

        // Constructor que inicializa el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método que calcula el área del círculo
        // CalcularArea devuelve un valor double
        // Usa la fórmula: Área = π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método que calcula el perímetro (circunferencia) del círculo
        // Usa la fórmula: Perímetro = 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un Rectángulo
    public class Rectangulo
    {
        // Campos privados para base y altura
        private double baseRectangulo;
        private double altura;

        // Constructor que inicializa base y altura
        public Rectangulo(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        // Método que calcula el área del rectángulo
        // Usa la fórmula: Área = base * altura
        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        // Método que calcula el perímetro del rectángulo
        // Usa la fórmula: Perímetro = 2 * (base + altura)
        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }

    // Clase principal para pruebas
    class Programa
    {
        static void Main(string[] args)
        {
            // Crear un círculo con radio 5
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Área del Círculo: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro del Círculo: " + miCirculo.CalcularPerimetro());

            // Crear un rectángulo con base 10 y altura 4
            Rectangulo miRectangulo = new Rectangulo(10, 4);
            Console.WriteLine("Área del Rectángulo: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro del Rectángulo: " + miRectangulo.CalcularPerimetro());

            Console.ReadLine(); // Pausar consola
        }
    }
}
