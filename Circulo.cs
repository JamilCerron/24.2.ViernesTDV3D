using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2.TDV3DViernes
{
    internal class Circulo
    {
        private float r;

        public Circulo(float r)
        {
            this.r = r;
        }

        public float RetornaArea() => r* r;
 
    }
}
