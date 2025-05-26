using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOpractice
{
    internal static class CipherData
    {
        //private string InputMessage;

        //public CipherData(string inputMessage)
        //{
        //    InputMessage = inputMessage;
        //}

        public static string CipherdedMessage(string inputMessage)
        {
            char[] splitMessage = inputMessage.ToCharArray();
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

            string messageCiphered = new string(splitMessage);
            return messageCiphered;
        }
        public static void FileWrite(string toWrite)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "IOpractice.txt");
            File.WriteAllText(filePath, toWrite);
        }




    }
}
