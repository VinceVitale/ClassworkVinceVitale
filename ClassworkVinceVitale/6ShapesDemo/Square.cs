using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ShapesDemo
{
    class Square : Rectangle
    {
        public Square() { }
        public Square(int height, int width) : base(height, height) { }
        public Square(int heightWidth) : base(heightWidth, heightWidth) { }
    }
}
