using System;

namespace Patterns.Proxy
{
    public class RealImage : Image
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        public void display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}
