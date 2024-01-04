using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class Multiplication:Arithmetic, IDivide
    {
        public double Divide(double x, double y)
        {
            return x / y;
        }

        public int Mult(int x, int y)
        {  return x * y; }
    }
}
