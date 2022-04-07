using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; } 
        public double Area()
        {
            return Width * Height;
        }
        public double perimeter()
        {
            return 2 * Width + 2 * Height;
        }
    }
}
