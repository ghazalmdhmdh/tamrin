using System;
namespace program
{
    class EnvironmentArea
    {
        private double RADIUS;//  شعاع دایره
        private double SIDESQUARE;//ضلع مربع
        private double HEIGHT;//ارتفاع مثلث
        private double SIDE1;//ضلع اول مثلث
        private double SIDE2;//ضلع دوم مثلث
        private double SIDE3;//ضلع سوم مثلث
        private double HEIGHT2;//ارتفاع ذوزنقه
        private double BIGSIDE;//قاعده بزرگ ذوزنقه
        private double SMALLSIDE;//قاعده کوچک ذوزنقه
        private double LEFTINSIDE;//ضلع چپ ذوزنقه
        private double RIGHTSIDE;//ضلع راست ذوزنقه




        public double Radius
        {
            get { return RADIUS; }
            set { RADIUS = value; }
        }//دایره
        public double sidesquare
        {
            get { return SIDESQUARE; }
            set { SIDESQUARE = value; }
        }//مربع

        public double side1
        {
            get { return SIDE1; }
            set { SIDE1 = value; }
        }//1مثلث

        public double side2
        {
            get { return SIDE2; }
            set { SIDE2 = value; }
        }//مثلث2

        public double side3
        {
            get { return SIDE3; }
            set { SIDE3 = value; }
        }//مثلث3

        public double height
        {
            get { return HEIGHT; }
            set { HEIGHT= value; }
        }//ارتفاع مثلث
        public double bigside
        {
            get { return BIGSIDE; }
            set { BIGSIDE = value; }
        }//قاعده بزرگ
        public double smallside
        {
            get { return SMALLSIDE; }
            set { SMALLSIDE = value; }
        }//قاعده کوچک
        public double rightside
        {
            get { return RIGHTSIDE; }
            set { RIGHTSIDE = value; }
        }//ضلع راست ذوزنقه
        public double leftside
        {
            get { return LEFTINSIDE; }
            set { LEFTINSIDE= value; }
        }//ضلع چپ ذوزنقه

        public double height2
        {
            get { return HEIGHT2; }
            set { HEIGHT2 = value; }
        }//ارتفاع ذوزنقه







        public double EnvironmentCircle()
        {
            return 2 * 3.14 * Radius;
        }
        public double AreaCircle()
        {
            return Radius * Radius * 3.14;
        }
        public double EnvironmentSquare()
        {
            return 4 * sidesquare;
        }
        public double AreaSquare()
        {
            return Math.Pow(sidesquare, 2);
        }
        public double Environmenttriangle()
        {
            return side1 + side2 + side3;
        }
        public double Areatriangle()
        {
            return (side1 * height) / 2;
        }
        public double Environmenttrapezius()
        {
            return smallside + bigside + rightside + leftside;
        }
        public double Areatrapezius()
        {
            return (smallside + bigside) * height2;
        }




    }
    class result
    {
        public static void Main()
        {
            Console.WriteLine("plese enter your path:circle,triangle,Square,Trapezius");
            string UserChoose = Console.ReadLine();

            if (UserChoose == "circle")
            {
                EnvironmentArea circle = new EnvironmentArea();
                Console.WriteLine("please enter radius");
                circle.Radius = Convert.ToDouble(Console.ReadLine());
                double ResEnvironment = circle.EnvironmentCircle();
                double ResArea = circle.AreaCircle();

                Console.WriteLine("Environment:" + ResEnvironment);
                Console.WriteLine("Area:" + ResArea);

            }

            else if (UserChoose == "square")
            {
                EnvironmentArea square = new EnvironmentArea();
                square.sidesquare = Convert.ToDouble(Console.ReadLine());
                double ResEnvironment = square.EnvironmentSquare();
                double ResArea = square.AreaSquare();

                Console.WriteLine("Environment:" + ResEnvironment);
                Console.WriteLine("Area:" + ResArea);


            }
            else if (UserChoose == "triangle")
            {
                EnvironmentArea triangle = new EnvironmentArea();
                Console.WriteLine("please enter side1");
                triangle.side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter side2");

                triangle.side2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter side3");

                triangle.side3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter height");

                triangle.height = Convert.ToDouble(Console.ReadLine());

                double ResEnvironment = triangle.Environmenttriangle();
                double ResArea = triangle.Areatriangle();

                Console.WriteLine("Environment:" + ResEnvironment);
                Console.WriteLine("Area:" + ResArea);


            }
            else if (UserChoose == "Trapezius")
            {
                EnvironmentArea Trapezius = new EnvironmentArea();
                Console.WriteLine("please enter smallside");
                Trapezius.smallside = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter bigside:");

                Trapezius.bigside = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter rightside:");

                Trapezius.rightside = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter leftside:");

                Trapezius.leftside = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("please enter height:");

                Trapezius.height2 = Convert.ToDouble(Console.ReadLine());

                double ResEnvironment = Trapezius.Environmenttrapezius();
                double ResArea = Trapezius.Areatrapezius();

                Console.WriteLine("Environment:" + ResEnvironment);
                Console.WriteLine("Area:" + ResArea);
            }
            else
            {
                Console.WriteLine("please enter option");
            }

        }
    }
}