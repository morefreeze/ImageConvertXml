using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace convertXml
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] base64CharArray;
            FileStream inFile;
            string base64String;
            StringBuilder SB = new StringBuilder();
            inFile = new System.IO.FileStream("ditu3.png",
                               System.IO.FileMode.Open,
                               System.IO.FileAccess.Read);

            base64CharArray = new byte[inFile.Length];
            inFile.Read(base64CharArray, 0, (int)inFile.Length);

            // convert from binary data to BASE64 decoding

            base64String = System.Convert.ToBase64String(base64CharArray, 0, base64CharArray.Length);

            // convert from BASE64 decoding to binary data

            byte[] binaryData;

            binaryData = System.Convert.FromBase64String(base64String);

            StreamWriter sw = new StreamWriter(@"ditu3.txt");

            sw.Write(base64String);
            sw.Flush();
            sw.Close();
        }
    }
}
