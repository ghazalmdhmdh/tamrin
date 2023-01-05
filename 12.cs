using System;
namespace program
{
    class kasr
    {
        private double a;
        private double b;
        private double c;
        private double d;
        
        public double a
        {
            get {return a;}
            set {a=value;}
        }
         public double b
        {
            get {return b;}
            set {b=value;}
        }
         public double c
        {
            get {return c;}
            set {c=value;}
        }
         public double d
        {
            get {return d;}
            set {d=value;}
        }

        public static void kasr(){}
        
        public static bool calc(double A, double B, double C, double D)
        {
            if (D>0 && B>0)
            {
                a=A;
                b=B;
                c=C;
                d=D;

                return true;
            }
            else 
            {Console.WriteLine("input wrong!";)
              retuen false;
            }
        }
        public static double sum()
        { double result= (a/b)+(c/d);
          return result;
        }
         public static double mines()
        { double result= (a/b)-(c/d);
          return result;
        }
         public static double multiply()
        { double result= (a/b)*(c/d);
          return result;
        }
         public static double taghsim()
        { double result= (a/b)/(c/d);
          return result;
        }
         public static double taghsimm()
        { double result= (a/b)%(c/d);
          return result;
        }
    }
    class kasr2
    {
        public static void main()
        {
            double num1=convert.Todouble(Console.ReadLine());
            double num2=convert.Todouble(Console.ReadLine());
            double num3=convert.Todouble(Console.ReadLine());
            double num4=convert.Todouble(Console.ReadLine());

            kasr k=new kasr()
            bool flag=k.calc(num1,num2,num3,num4);
            if (flag)
            {double sum=k.sum();
             Console.WriteLine(sum.Tostring());
             double mines=k.mines();
             Console.WriteLine(mines.Tostring());
             double multiply=k.multiply();
             Console.WriteLine(multiply.Tostring());
             double taghsim=k.taghsim();
             Console.WriteLine(taghsim.Tostring());
             double taghsimm=k.taghsimm();
             Console.WriteLine(taghsimm.Tostring());
            }
            else
            {
                Console.WriteLine("input not correct");
            }
        }
        
    }
    
}