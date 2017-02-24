using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MathLang
{
    class FileWorker
    {
        public FileWorker()
        {

        }
        public static void WriteToFile(string s)
        {
            using (StreamWriter writer = new StreamWriter(File.Create(@"..\..\result.il")))
            {
                writer.WriteLine(s);
            }
        }
    }
}
