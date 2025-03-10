
namespace DesignPatterns_Factories
{
    // Why we need Factories design pattern?
    // Point Example

    public class Point
    {
        private double x, y;

        // Cartesian coordinate system:
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // imagine you also need to use a Polar coordinate system
        // you cannot overload constructor with the same exact argument types
        // you cannot use this:

        // Polar coordinate system:

        //public Point(double rho, double theta)
        //{
        //    // the signature is exactly the same
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
