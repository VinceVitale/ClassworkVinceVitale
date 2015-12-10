using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _6ShapesDemo
{
    class ShapesClient
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Square square1 = new Square(5, 5);
            Square square2 = new Square(5, 0);
            Square square3 = new Square(5);
            Triangle triangle = new Triangle(10, 5);
            
            DisplayGeometricFigure(rectangle);
            DisplayGeometricFigure(square1);
            DisplayGeometricFigure(square2);
            DisplayGeometricFigure(square3);
            DisplayGeometricFigure(triangle);

            WriteLine("\n\n");

            rectangle = new Rectangle(15, 10);
            square1 = new Square(15, 15);
            square2 = new Square(15, 10);
            square3 = new Square(15);
            triangle = new Triangle(110, 15);
            
            DisplayGeometricFigure(rectangle);
            DisplayGeometricFigure(square1);
            DisplayGeometricFigure(square2);
            DisplayGeometricFigure(square3);
            DisplayGeometricFigure(triangle);
        }
        
        public static void DisplayGeometricFigure(GeometricFigure one)
        {
            WriteLine("Height: {0}\nWidth: {1}\nArea: {2}\n",
                one.Height, one.Width, one.Area);
        }
    }
}
