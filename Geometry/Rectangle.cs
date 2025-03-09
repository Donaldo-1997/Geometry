using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

class Rectangle : Square {
    private double _b;

    public Rectangle(string name, double a, double b) : base(name, a) {
        B = b;
    }

    public double B { get => _b; set => _b = ValidateB(value); }

    private double ValidateB(double b) {
        if (b < 0) {
            throw new Exception($"{b} is not valid area");
        }

        return b;
    }

    public override double GetArea() {
        return A * B;
    }

    public override double GetPerimeter() {
        return 2 * (A + B);
    }
}
