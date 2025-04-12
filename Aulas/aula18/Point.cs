using System.Runtime.CompilerServices;

namespace aula18 {
        struct Point {

        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" 
            + X 
            + ", " 
            + Y
            + ")";
        }
    }
}
