using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ShapesDemo
{
    class Triangle : GeometricFigure
    {
        public Triangle() { }
        public Triangle(int height, int width)
        {
            Height = height;
            Width = width;
        }
        //gets area (overrides the abstract method in GeometricFigure)
        public override int ComputeArea(int height, int width)
        {
            int area = (width * (height / 2));
            return area;
        }
    }
}
