using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP01
{
    internal class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x; Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
