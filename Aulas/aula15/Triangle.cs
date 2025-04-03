using System;
using System.Diagnostics.Contracts;

namespace aula15
{   
    class Triangle {
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

        
    }
}
