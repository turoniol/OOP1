using System;
using System.IO;

namespace Geometry
{
    public class GeometryWriter : IDisposable
    {
        private StreamWriter _writer;
        private static bool _disposed;

        public GeometryWriter(string path)
        {
            _writer = new StreamWriter(path);
        }

        public void AppendArea(GeometryFigure fig)
        {
            _writer.WriteLine(fig.Area);
        }

        public void Dispose()
        {
            System.Console.WriteLine("Dispose");
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            System.Console.WriteLine("Dispose(bool)");
            if (!_disposed)
            {
                if (_writer != null && disposing)
                    _writer.Close();
                _writer = null;
            }
            _disposed = true;
        }

        ~GeometryWriter()
        {
            System.Console.WriteLine("GF's writer destructor");
            Dispose(false);
        }
    }
}