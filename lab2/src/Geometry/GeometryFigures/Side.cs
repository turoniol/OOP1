namespace Geometry
{
    public class Side
    {
        private double _length;

        public double Length 
        {
            get => _length;
            set
            {
                if (value < 0.0)
                    throw new InvalidSideLengthException (
                        new InvalidSideLengthExceptionExceptionArgs {
                            message = "The side must be non-negative.",
                            value = value,
                        }
                    );
                _length = value;
            }
        }

        public Side(double length) => Length = length;
    }
}