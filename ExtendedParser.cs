using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    /*
     * Мы зависим от реализации другого класса, но это нам необходимо для наличиия одинакового метода Parse
     */
    class ExtendedParser : Parser
    {
        string[] LexTable;
        string[] PoleTable;
        string[] TriTables;
        public ExtendedParser(IReader _reader, string path) : base(_reader, path)
        {
            Parse(); //преобразуем текст для дальнейших операций и получения значений поля Text
        }

        public string[] GetLexTable() 
        {
            //какая-то логика для получения таблицы лексем
            return LexTable;
        }

        public string[] GetPoleTable()
        {
            //какая-то логика для получения таблицы идентификаторов
            return PoleTable;
        }
        public string[] GetTriTables()
        {
            //какая-то логика для получения триад
            return TriTables;
        }
    }
}
