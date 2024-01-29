using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ari.lab1.aaaa
{

    internal class Complex : Pair
    {
        public override Pair Add(Pair p)
        {
            return new Complex() { A = this.A + p.A, B = this.B + p.B };
        }

        public override Pair Div(Pair p)
        {
            return new Complex() { A = (this.A * p.A + this.B * p.B)/(p.A*p.A+p.B*p.B),B=(this.B*p.A-this.A*p.B)/ (p.A * p.A + p.B * p.B) };
        }

        public override Pair Mul(Pair p)
        {
            return new Complex() { A = this.A * p.A - this.B * p.B, B = this.A * p.B + this.B * p.A };
        }

        public override Pair Sub(Pair p)
        {
            return new Complex() { A = this.A - p.A, B = this.B - p.B };
        }

        public bool Equ(Pair p)
        {
            return this.A==p.A&&this.B==p.B;
        }
        public Pair Conj(Pair p)
        {
            return new Complex() {A= this.A,B= -this.B };
        }
        public override string? ToString()
        {
            if (B > 0)
                return $"{A}+{B}i";
            else if (B < 0)
                return $"{A}-{B}i";
            else return $"{A}";
        }
    }
}
