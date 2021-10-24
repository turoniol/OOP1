using System;
using System.IO;

namespace Geometry
{
    public class FileWriter : IAreaWriter, ITypeWriter
    {
        private string _path;
        public FileWriter(string path)
        {
            _path = path;
        }

        void IAreaWriter.Write(GeometryFigure fig) => Write(fig.GetArea().ToString());

        void ITypeWriter.Write(GeometryFigure obj) => Write(Plane.GetType(obj));

        private void Write(string m)
        {
            File.AppendAllText(_path, m + Environment.NewLine);
        }
    }
}