using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03102023
{
    public class BadWordsChecker
    {
        /// <summary>
        /// Заменяет во входной строке все неприличные слова на звездочки ***.
        /// </summary>
        /// <param name="textString"> качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. В тексте может быть 0 или более слов "редиска", записанных в различном регистре.</param>
        /// <returns>Возвращается отфильтрованный текст, в котором все слова редиска заменены на звездочки **</returns>
            public static string Censore(string textString)
            {
                List<string> list = new List<string>();

                textString = textString.ToLower();

                list = textString.Split(' ').ToList();

                var secondList = list.Select(x => x.Replace("редиска", "***")).ToList();

                string stringWithoutBadWords = string.Join(" ", secondList.ToArray());

                return stringWithoutBadWords;
                
            }
    }
}
