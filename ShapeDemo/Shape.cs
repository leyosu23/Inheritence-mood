using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    abstract class Shape
    {
        public string Name { get; private set; }
        public abstract double Area { get; }
        public Shape(string name) { Name = name; }
        public override string ToString(){ return $"{Name} {Area:N2}"; }
    }
    class Square : Shape
    {
        protected double Length { get; set; }
        public override double Area { get { return Length * Length; } }
        public Square(double length) : base("square")
        { Length = length; }
        public Square(string name, double length) : base(name)
        { Length = length; }
    }
    class Circle : Square
    {
        public override double Area { get { return Math.PI * Length * Length; } }
        public Circle(double length) : base("square", length) { }
    }
}
