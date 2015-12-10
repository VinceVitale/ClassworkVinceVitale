using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _6ShapesDemo
{
    abstract class GeometricFigure
    {
        public int Height { get; set; }
        public int Width { get; set; }
        private readonly int area;
        public int Area
        {
            get
            {
                return ComputeArea(Height, Width);
            }
        }
        
        public GeometricFigure()
        {
            Height = 0;
            Width = 0;
        }
        
        public GeometricFigure(int height, int width)
        {
            Height = height;
            Width = width;
        }
        //gets area (abstract method)
        public abstract int ComputeArea(int height, int width);
    }
}
