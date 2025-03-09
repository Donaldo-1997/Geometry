using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

class Trapeze : Triangle {
    private double _d;

    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h) {
        D = d;
    }

    public double D { get => _d; set => _d = ValidateD(value); }

    private double ValidateD(double d) {
        if (d < 0) {
            throw new Exception($"{d} is not valid");
        }

        return d;
    }

    public override double GetArea() {
        return (B + D) * (H / 2);
    }

    public override double GetPerimeter() {
        return (A + B) + (C + D);
    }
}
