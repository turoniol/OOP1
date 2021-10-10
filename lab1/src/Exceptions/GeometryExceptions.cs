namespace Geometry
{
    class InvalidAreaException : System.Exception
    {
        public InvalidAreaException() : base("The area must be non-negative") {}
    }

    class InvalidSideLengthException : System.Exception
    {
        public InvalidSideLengthException() : base("The length of a side must be non-negative") {}
    }

    class InvalidRightTriangleException : System.Exception
    {
        public InvalidRightTriangleException() : base("It's not a right triangle") {}
    }
}