using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

class Kite : Rhombus {
    private double _b;

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public double B { get => _b; set => _b = ValidateB(value); }

    private double ValidateB(double b) { 
        if(b < 0) {
            throw new Exception($"{b} is not valid area");
        }
        return b;
    }

    public override double GetArea() {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter() {
        return 2 * (A + B);
    }
}
