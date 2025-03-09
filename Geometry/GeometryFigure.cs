using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

public abstract class GeometryFigure {
    private string _name;
    public GeometryFigure(string name) => Name = name;

    public string Name { get => _name; set => _name = value; }

    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString() {
        return $"{Name, -15}{"",5}=> Area.....:{GetArea().ToString("N5", CultureInfo.InvariantCulture), 15}\tPerimeter.....:{GetPerimeter().ToString("N5", CultureInfo.InvariantCulture), 15}";
    }
}