using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP01
{
    internal struct PointStruct
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public PointStruct(int x, int y)
        {
            X = x; Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }


    }
}
