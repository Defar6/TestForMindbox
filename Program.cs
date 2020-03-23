using System;
using AreaForm;
using AreaForm.Figures;

namespace TestForMindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle(6);
            Triangle triangle = new Triangle(3,4,5);

            Console.WriteLine("Круг площадь " + circ.GetAreaFigure + " радиус "+circ.Radius);
            Console.WriteLine("Треугольник площадь " + triangle.GetAreaFigure + " правильный " + triangle.RightTriangle);
            Console.ReadLine();
        }
    }
}
