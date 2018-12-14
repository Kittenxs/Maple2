using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleBOT2
{
    public class Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float  Z { get; set; }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return "X: " + X + ",Y: " + Y + ",Z: " + Z;
        }
    }
}
