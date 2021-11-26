
namespace Lab11
{
    public class Parser : IParser
    {
        /*
         * В данном случае происходит инверсия зависимости, так как мы зависим от интефейса, а не от класса
         * и нам всё равно какой из reader'ов принимать
         */
        private IReader reader;
        private string Path;
        public string text { get; private set; }
        public Parser(IReader _reader, string path) 
        {
            reader = _reader;
            Path = path;
        }

        public string Parse() 
        {
            text = reader.Read(Path);
            //Делаем то за что отвечает парсер и формируем результат
            return text;
        }
    }
}
