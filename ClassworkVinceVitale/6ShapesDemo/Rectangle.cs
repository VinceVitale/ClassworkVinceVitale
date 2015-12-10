using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ShapesDemo
{
    class Rectangle : GeometricFigure
    {
        public Rectangle() { }
        
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        //gets area (overrides the abstract method in GeometricFigure)
        public override int ComputeArea(int height, int width)
        {
            int area = (height * width);
            return area;
        }
    }
}
