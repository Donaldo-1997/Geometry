using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

class Square : GeometryFigure {
    private double _a;

    public Square(string name, double a) : base(name) {
        A = a;
    }

    public double A { get => _a; set => _a = ValidateA(value); }

    private double ValidateA(double a) { 
        if(a < 0) {
            throw new Exception($"{a} is not valid area");
        }

        return a;
    }

    public override double GetArea() {
        return A * A;
    }

    public override double GetPerimeter() {
        return 4 * A;
    }
}
