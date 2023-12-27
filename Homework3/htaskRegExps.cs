using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, в которой необходимо найти российские автомобильные номера: ");
            var stringAuto = Console.ReadLine();
            Console.WriteLine($"Результат: {SearchAutoNum(stringAuto)}");
            Console.WriteLine("Введите строку, в которой необходимо найти IPv4 адреса: ");
            var stringIP = Console.ReadLine();
            Console.WriteLine($"Результат: {SearchIPv4(stringIP)}");
            Console.WriteLine("Введите текст, где одинарные звёздочки надо заменить на теги: ");
            var stringTeg = Console.ReadLine();
            Console.WriteLine($"Результат: {SwapToTeg(stringTeg)}");
            Console.WriteLine("Введите строку, которую надо проверить на принадлежность к доменным протолокам https или http: ");
            var stringProtoc = Console.ReadLine();
            Console.WriteLine($"Результат: {stringProtoc} - {ItIsHttp(stringProtoc)}");
            say("Hfhdhfdcxc");

        }

        //Выяснить, какими могут быть российские автомобильные номера (с кодом региона), составить соответствующее регулярное выражение и
        //написать программу, которая находит в строке все автомобильные номера и выводит их на консоль.
        public static string SearchAutoNum (string s)
        {
            var count = 1;
            var s1 = "";
            foreach (Match m in Regex.Matches(s, @"\b[АВЕКМНОРСТУХ]\d{3}[АВЕКМНОРСТУХ]{2}1?\d{2}\b"))
            {
                s1 += $"{count}: {m.Value} ";
                count++;
            }
            return s1;
        }

        //Дана строка. Вывести все содержащиеся в ней IPv4-адреса в десятичной записи с точками через разделитель.
        public static string SearchIPv4 (string s)
        {
            var count = 1;
            var s1 = "";
            foreach (Match m in Regex.Matches(s, @"(\b\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})\b"))
            {
                if (int.Parse(m.Groups[1].ToString()) <= 255)
                {
                    if(int.Parse(m.Groups[2].ToString()) <= 255)
                    {
                        if (int.Parse(m.Groups[3].ToString()) <= 255)
                        {
                            if (int.Parse(m.Groups[1].ToString()) <= 255)
                            {
                                s1 += $"{count}: {m.Value} ";
                                count++;
                            }
                        }    
                    }
                } 
            }
            return s1;
        }

        //Преобразовать текст, обрамленный в звездочки, в текст обрамленный тегом <em></em>, т.е. курсив.
        ////Не трогать текст в двойных звездочках (жирный). 
        public static string SwapToTeg (string s)
        {
            s = Regex.Replace(s, @"\b\*(?!\*)", @"</em>");
            s = Regex.Replace(s, @"(?<!\*)\*\b", @"<em>");
            return s;
        }

        //Определить является ли строка доменным именем с протоколами http и https,
        //с необязательным слешем в конце. Специальные символы не используются.
        public static string ItIsHttp (string s)
        {
            var s1 = "Нет";
            var m = Regex.Match(s, @"http[s]?://w+\.\w+");
            if (m.Success == true)
                s1 = "Да";
            return s1;
        }
    }
}
