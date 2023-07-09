namespace Shape
{
    public class Triangle : IShape
    {
        private double _a;
        public double a
        {
            get
            {
                return _a;
            }
            set
            {
                if (_a <= 0)
                {
                    throw new Exception("Сторона не может быть равна 0");
                }
                _a = value;
            }
        }
        
        private double _b;
        public double b
        {
            get
            {
                return _b;
            }
            set
            {
                if (_b <= 0)
                {
                    throw new Exception("Сторона не может быть равна 0");
                }
                _b = value;
            }
        }

        private double _c;
        public double c
        {
            get
            {
                return _c;
            }
            set
            {
                if (_c <= 0)
                {
                    throw new Exception("Сторона не может быть равна 0");
                }
                _c = value;
            }
        }

        private double _h;
        public double h
        {
            get
            {
                return _h;
            }
            set
            {
                if (_h <= 0)
                {
                    throw new Exception("Сторона не может быть равна 0");
                }
                _h = value;
            }
        }

        public Triangle(int a, int b, int c, int h)
        {
            _a = a;
            _b = b;
            _c = c;
            _h = h;
        }
        public double CalculateArea()
        {
            return 1 / 2 * a * h;
        }
        public double CalculatePerimeter()
        {
            return a + b + c;
        }
    }
}