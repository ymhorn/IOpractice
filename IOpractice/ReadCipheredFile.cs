using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOpractice
{
    internal static class ReadCipheredFile
    {
        public static void ReadFile(string path)
        {
            string contents = File.ReadAllText(path);
            char[] splitMessage = contents.ToCharArray();
            for (int i = 0; i < splitMessage.Length; i++)
            {
                if (splitMessage[i] >= 'a' && splitMessage[i] <= 'z')
                {
                    splitMessage[i] = (char)(219 - splitMessage[i]);
                }
                else if (splitMessage[i] >= 'A' && splitMessage[i] <= 'Z')
                {
                    splitMessage[i] = (char)(155 - splitMessage[i]);
                }
                else
                {
                    continue;
                }
            }
            string messageUnCiphered = new string(splitMessage);
            Console.WriteLine(messageUnCiphered);
        }
    }
}
