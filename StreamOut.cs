using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class StreamOut : IOut
    {
        string Path;

        public StreamOut(string path) 
        {
            Path = path;
        }
        public void Paste(string Text)
        {
            using (var stream = new BufferedStream(File.OpenRead(Path))) 
            {
                //какая-то логика записи  Text
            }
        }
    }
}
