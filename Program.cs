using System;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new Runner();
            runner.RunTaskOne();
            runner.RunTaskTwo();
        }
    }

    class Runner 
    {
        public void RunTaskOne() 
        {
            Сompiler compiler = new Сompiler();
            Parser parser = new Parser(new TxtReader(), "откуда читать");
            var streamOut = new StreamOut("выводить");
            streamOut.Paste(compiler.Compile(parser.Parse()));
        }

        public void RunTaskTwo() 
        {
            while (true) //Диалоговый режим в виде цикла с чтением из консоли и дальнейшей обработкой
            {
                Console.ReadLine();
                //Какая-то обработка и диалоги с пользователем
                var parser = new ExtendedParser(new DocReader(), "откуда читать");
            }
        }
    }
}
