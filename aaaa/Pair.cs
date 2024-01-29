using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ari.lab1.aaaa
{
    internal abstract class Pair
    {
       public double A { get; set; }
       public double B { get; set; }
       public abstract Pair Add(Pair p);
       public abstract Pair Sub(Pair p);
       public abstract Pair Mul(Pair p);
       public abstract Pair Div(Pair p);

    
    }
}
