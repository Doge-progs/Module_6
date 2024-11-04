using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
Знаки препинания не используются. Найти самое длинное слово в строке.
*/
namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();

            string[] s_new = s.Split(' ');

            string s_word = s_new[0];
            int s_max = s_new[0].Length;

            foreach (string i in s_new)
            {
                if (i.Length > s_max)
                {
                    s_word = i;
                    s_max = i.Length;
                }
            }

            Console.WriteLine("Самое длинное слово '{0}'", s_word);
            Console.WriteLine("Длина слова {0} символов", s_max);
            Console.ReadKey();
        }
    }
}
