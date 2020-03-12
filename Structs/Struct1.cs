using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public  struct Struct1
    {
        public int x { get; set; }
        public int y { get; set; }
        public Struct1(Class1 cl)
        {
            this.x = cl.X;
            this.y = cl.Y;
        }
      
    }
}
