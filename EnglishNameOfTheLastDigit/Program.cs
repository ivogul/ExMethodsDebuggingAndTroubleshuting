using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            string englishNameOfTheLastDigit = GetEnglishNameOfTheLastDigit(n);
            Console.WriteLine(englishNameOfTheLastDigit);
        }

        private static string GetEnglishNameOfTheLastDigit(long n)
        {
            long lastDigit = Math.Abs(n) % 10;
            string englishName = "";
            switch (lastDigit)
            {
                case 1: englishName = "one"; break;
                case 2: englishName = "two"; break;
                case 3: englishName = "three"; break;
                case 4: englishName = "four"; break;
                case 5: englishName = "five"; break;
                case 6: englishName = "six"; break;
                case 7: englishName = "seven"; break;
                case 8: englishName = "eight"; break;
                case 9: englishName = "nine"; break;
                case 0: englishName = "zero"; break;
                default:
                    break;
            }
            return englishName;
        }
    }
}
