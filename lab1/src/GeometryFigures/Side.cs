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
                    throw new InvalidSideLengthException();
                _length = value;
            }
        }

        public Side(double length) => Length = length;
    }
}