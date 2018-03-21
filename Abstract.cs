using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    class Abstract
    {

        static void Main(string[] args)
        {
            rectangle r = new rectangle(23.4,12.87);
            circle c = new circle(12.9);
          
            Console.WriteLine("area of rectangle:" + r.Area());
            Console.WriteLine("area of circle:" + c.Area());
            Console.ReadKey();
        }
    }
  public  abstract class figure
    {
        public double radius, width;
        public const double Pi = 3.14;
        public  abstract double Area();
    }
   public  class rectangle : figure
    {
        public rectangle(double radius, double width)
        {
            this.radius = radius;
            this.width = width;
        }
        public override double Area()
        {
            return radius * width;
        }
    }
    public class circle : figure
    {
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Pi * radius * radius;
        }
    }
}
