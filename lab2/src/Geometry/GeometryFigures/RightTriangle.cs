namespace Geometry
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b, double c) : base(a, b, c) 
        {
            // System.Console.WriteLine("Right Triangle");
            if (a * a + b * b != c * c)
                throw new InvalidTriangleException (
                    new InvalidTriangleExceptionArgs {
                        message ="The sum of squares of legs must be equal to the square of the hypotenuse.",
                        value = (a, b, c)
                    }
                );
        }
    }    
}