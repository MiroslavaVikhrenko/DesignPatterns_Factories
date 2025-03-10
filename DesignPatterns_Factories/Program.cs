
namespace DesignPatterns_Factories
{
    // Why we need Factories design pattern?
    // Point Example

    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }
    public class Point
    {
        private double x, y;
        /// <summary>
        /// Initializes a point from EITHER cartesian or polar 
        /// </summary>
        /// <param name="a"> x if cartesian, rho if polar</param>
        /// <param name="b"> y if cartesian, theta if polar</param>
        /// <param name="system"></param>

        // Cartesian coordinate system:
        public Point(double a, double b, 
            CoordinateSystem system = CoordinateSystem.Cartesian)
        {
            switch (system)
            {
                case CoordinateSystem.Cartesian:
                    x = a;
                    y = b;
                    // also confusing whether a is x or y 
                    break;
                case CoordinateSystem.Polar:
                    x = a * Math.Cos(b);
                    y = a * Math.Sin(b);
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        // imagine you also need to use a Polar coordinate system
        // you cannot overload constructor with the same exact argument types
        // you cannot use this:

        // Polar coordinate system:

        //public Point(double rho, double theta)
        //{
        //    // the signature is exactly the same
        //}

        // you can introduce coordinate types so that you can pass it to constructor
        // but then there is a naming problem as x and y implies cartesian system

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
