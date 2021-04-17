using System;
using System.Text;
using System.Linq;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("First method: ");
                Console.WriteLine(GetMaxCountOfUniqueSequenceOfLetters(args[0]));
                Console.Write("Second Method: ");
                Console.WriteLine(GetMaxCountOfUniqueSequenceOfLettersSecondTask(args[1]));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }


        static int GetMaxCountOfUniqueSequenceOfLetters(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int result = 1;
            int count = 1;
            for(int i = 0; i < str.Length-1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    count++;             
                }

                if (str[i] == str[i + 1])
                {
                    if(count > result)
                    {
                        result = count;
                    }
                    count = 1;
                }
            }

            if (count > result)
            {
                result = count;
            }

            return result;
        }

        static int GetMaxCountOfUniqueSequenceOfLettersSecondTask(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            if (str.ToCharArray().Distinct().Count() == 1)
            {
                return 1;
            }

            StringBuilder str1 = new StringBuilder(string.Empty);
            StringBuilder str2 = new StringBuilder(string.Empty);

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i-1] != str[i])
                {
                    str1.Append(str[i]);
                    str1.Append(str[i - 1]);
                }

                if (str[i-1] == str[i])
                {
                    if (str1.Length > str2.Length)
                    {
                        str2 = str1;
                    }
                    str1 = new StringBuilder(string.Empty);
                    
                }
            }

            if (str1.Length > str2.Length)
            {
                str2 = str1;
            }

            int result = str2.ToString().ToCharArray().Distinct().Count();
            return result;
        }
    }
}
