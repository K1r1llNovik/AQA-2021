using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(GetMaxCountOfUniqueSequenceOfLetters(args[0]));
            }
            catch(Exception exception)
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
    }
}
