using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    public class Arithmetic
    {
        public int width = 0;
        public int area = 0;
        protected string name = "";
        public int Height { get; set; }
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y) 
        {  
            return x - y; 
        }
    }
}
