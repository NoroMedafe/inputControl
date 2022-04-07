using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userWord;

            while (true)
            {
                Console.Write("Введите любое слово: ");
                userWord = Console.ReadLine();
                userWord = userWord.ToLower();
                if (userWord == stopWord)
                    break;
            }
            Console.Clear();
            Console.WriteLine("Вы ввели стоп слово");
            Console.ReadKey();
        }
    }
}
