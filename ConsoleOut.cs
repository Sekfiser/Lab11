using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class ConsoleOut : IOut
    {
        public void Paste(string Text)
        {
            //какие-то методы обработки строки для вывода в консоль
            Console.WriteLine(Text);
        }
    }
}
