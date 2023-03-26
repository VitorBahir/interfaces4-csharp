using System;

namespace Course.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing: " + document);
        }

        public String Scan()
        {
            return "ComboDevice scan result";
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print: " + document);
        }
    }
}
