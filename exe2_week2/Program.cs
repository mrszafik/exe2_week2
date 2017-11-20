using System;

namespace exe2_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Diamond diamond = new Diamond();

            rectangle.SideA = 4;
            rectangle.SideB = 5;
            Console.WriteLine("Field: " + rectangle.countField() + "  Circuit: " + rectangle.countCircuit());

            circle.Radius = 5;
            Console.WriteLine("Field: " + circle.countField() + "  Circuit: " + circle.countCircuit());

            triangle.setSideA(6);
            triangle.setSideB(8);
            triangle.setSideC(10);
            triangle.setHeight(8);
            Console.WriteLine("Field: " + triangle.countField() + "  Circuit: " + triangle.countCircuit());

            diamond.DiagonalA = 3;
            diamond.DiagonalB = 4;
            Console.WriteLine("Field: " + diamond.countField() + "  Circuit: " + diamond.countCircuit());
        }
    }

    abstract class Shape
    {
        public abstract double countField();
        public abstract double countCircuit();
    }

    class Rectangle : Shape
    {
        private int _sideA;
        private int _sideB;
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
        public override double countField()
        {
            return _sideA * _sideB;
        }
        public override double countCircuit()
        {
            return 2 * _sideA + 2 * _sideB;
        }
    }

    class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value;  }
        }
        public override double countField()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        public override double countCircuit()
        {
            return 2 * Math.PI * _radius;
        }
    }
    
    class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _height;
        public void setSideA(double sideA)
        {
            _sideA = sideA;
        }
        public double getSideA()
        {
            return _sideA;
        }
        public void setSideB(double sideB)
        {
            _sideB = sideB;
        }
        public double getSideB()
        {
            return _sideB;
        }
        public void setSideC(double sideC)
        {
            _sideC = sideC;
        }
        public double getSideC()
        {
            return _sideC;
        }

        public void setHeight(double height)
        {
            _height = height;
        }
        public double getHeight()
        {
            return _height;
        }
        public override double countField()
        {
            return _sideA * _height / 2;
        }
        public override double countCircuit()
        {
            return _sideA + _sideB + _sideC;
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
        public override double countCircuit()
        {
            return 4* Math.Sqrt(Math.Pow(_diagonalA, 2) + Math.Pow(_diagonalB, 2));
        }
        public override double countField()
        {
            return _diagonalA * _diagonalB / 2;
        }
    }
}
