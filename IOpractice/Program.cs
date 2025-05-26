using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CipherData.FileWrite(CipherData.CipherdedMessage("What the hell just happened."));
            ReadCipheredFile.ReadFile("C:/Users/Yisroel Meir/Desktop/IOpractice.txt");
        }
    }
}
