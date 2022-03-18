using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal struct Point   //STRUCT
    {
        public double X;

        public double Y;


        public override string ToString()          //tipo básico para representar um ponto no plano cartesiano 2D
        {
            return "(" + X + ", " + Y + ")";

        }


    }
}
