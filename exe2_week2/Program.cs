using System;

namespace exe2_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle(6,9);
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(7);
            Triangle triangle = new Triangle();
            Diamond diamond = new Diamond();

            rectangle1.SideA = 4;
            rectangle1.SideB = 5;
            rectangle1.Describe();
            rectangle2.Describe();

            circle1.Radius = 5;
            circle1.Describe();
            circle2.Describe();

            triangle.SetSideA(6);
            triangle.SetSideB(8);
            triangle.SetSideC(10);
            triangle.SetHeight(8);
            triangle.Describe();

            diamond.DiagonalA = 3;
            diamond.DiagonalB = 4;
            diamond.Describe();
        }
    }

    abstract class Shape
    {
        public abstract double CountField();
        public abstract double CountCircuit();
        public abstract void Describe();
    }

    class Rectangle : Shape
    {
        private int _sideA;
        private int _sideB;
        public Rectangle()
        {

        }
        public Rectangle(int sideA, int sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }
        public int SideA
        {
            get{ return _sideA; }
            set{ _sideA = value; }
        }
        public int SideB
        {
            get{ return _sideB;}
            set{ _sideB = value;}
        }
        public override double CountField()
        {
            return _sideA * _sideB;
        }
        public override double CountCircuit()
        {
            return 2 * _sideA + 2 * _sideB;
        }
        public override void Describe()
        {
            Console.WriteLine("Field: " + this.CountField() + "  Circuit: " + this.CountCircuit());
        }
    }

    class Circle : Shape
    {
        private double _radius;
        public Circle()
        {
            
        }
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Radius
        {
            get { return _radius; }
            set { _radius = value;  }
        }
        public override double CountField()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        public override double CountCircuit()
        {
            return 2 * Math.PI * _radius;
        }
        public override void Describe()
        {
            Console.WriteLine("Field: " + this.CountField() + "  Circuit: " + this.CountCircuit());
        }
    }
    
    class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _height;
        public void SetSideA(double sideA)
        {
            _sideA = sideA;
        }
        public double GetSideA()
        {
            return _sideA;
        }
        public void SetSideB(double sideB)
        {
            _sideB = sideB;
        }
        public double GetSideB()
        {
            return _sideB;
        }
        public void SetSideC(double sideC)
        {
            _sideC = sideC;
        }
        public double GetSideC()
        {
            return _sideC;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }
        public double GetHeight()
        {
            return _height;
        }
        public override double CountField()
        {
            return _sideA * _height / 2;
        }
        public override double CountCircuit()
        {
            return _sideA + _sideB + _sideC;
        }
        public override void Describe()
        {
            Console.WriteLine("Field: " + this.CountField() + "  Circuit: " + this.CountCircuit());
        }
    }
    class Diamond : Shape
    {
        private double _diagonalA, _diagonalB;
        public double DiagonalA
        {
            get { return _diagonalA; }
            set { _diagonalA = value;  }
        }
        public double DiagonalB
        {
            get { return _diagonalB; }
            set { _diagonalB = value; }
        }
        public override double CountCircuit()
        {
            return 4* Math.Sqrt(Math.Pow(_diagonalA, 2) + Math.Pow(_diagonalB, 2));
        }
        public override double CountField()
        {
            return _diagonalA * _diagonalB / 2;
        }
        public override void Describe()
        {
            Console.WriteLine("Field: " + this.CountField() + "  Circuit: " + this.CountCircuit());
        }
    }
}
