namespace Geometry
{
    public delegate void WritingHandle(GeometryFigure figure);

    public class ComplexWriter
    {
        public event WritingHandle ComplexWritingEvent;

        public void Write(GeometryFigure obj)
        {
            if (ComplexWritingEvent != null)
                ComplexWritingEvent.Invoke(obj);
        }
    }
}