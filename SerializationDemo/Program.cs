using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinarySerialization serial = new BinarySerialization();
            //serial.Serialization();
            BinaryDeSerialization deserial = new BinaryDeSerialization();
            deserial.DeSerialization();

        }
    }
}
