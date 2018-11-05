using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
  public  class Element
    {
        public Char Data { get; set; }
        public Element Right { get; set; }
        public Element Down { get; set; }
    }
}
