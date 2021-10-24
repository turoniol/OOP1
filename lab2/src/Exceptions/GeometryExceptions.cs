namespace Geometry
{
    class InvalidSideLengthException : System.Exception
    {
        private InvalidSideLengthExceptionExceptionArgs _args;

        public override string Message => _args.message;

        public double Value => _args.value;

        public InvalidSideLengthException(InvalidSideLengthExceptionExceptionArgs args)
        {
            _args = args;
        }
    }

    struct InvalidSideLengthExceptionExceptionArgs
    {
        public string message;
        
        public double value;
    }

    class InvalidTriangleException : System.Exception
    {        
        private InvalidTriangleExceptionArgs _args;

        public override string Message => _args.message;

        public (double, double, double) Value => _args.value;

        public InvalidTriangleException(InvalidTriangleExceptionArgs args)
        {
            _args = args;
        }
    }

    struct InvalidTriangleExceptionArgs
    {
        public string message;

        public (double, double, double) value;
    }
}