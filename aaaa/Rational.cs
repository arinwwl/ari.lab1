using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ari.lab1.aaaa
{
    internal class Rational : Pair
    {
        public override Pair Add(Pair p)
        {
            return new Rational() { A = this.A * p.B + this.B*p.A, B = this.B * p.B };
        }

        public override Pair Div(Pair p)
        {
            return new Rational() { A = this.A * p.B, B=this.B*p.A} ;
        }

        public override Pair Mul(Pair p)
        {
            return new Rational() { A = this.A * p.A, B=this.B*p.B};
        }

        public override Pair Sub(Pair p)
        {
            return new Rational() { A = this.A * p.B - this.B * p.A, B = this.B * p.B };
        }

        public bool Equ(Pair p)
        {
            return this.A == p.A && this.B == p.B;
        }
        
        public bool Greate(Pair p)
        {
            return Math.Sqrt(this.A * this.A + this.B * this.B)>Math.Sqrt(p.A*p.A+p.B*p.B);
        }
        public bool Less(Pair p)
        {
            return Math.Sqrt(this.A * this.A + this.B * this.B) < Math.Sqrt(p.A * p.A + p.B * p.B);
        }

        public override string? ToString()
        {
             return $"{A},{B}";
        }
    }
}
