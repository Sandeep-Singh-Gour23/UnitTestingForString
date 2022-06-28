using System;

namespace UnitTestingForString
{
    public class LengthHelper
    {
        public static int findLength(string str)
        {
            int l = 0;
            foreach (char c in str)
            {
                l += 1;

            }
            return l;
        }
        static void Main(string[] args)
        {
            string str;
            int len = 0;
            Console.Write("Enter Your String:");
            str = Console.ReadLine();
            len = findLength(str);
            Console.Write("Length of the string is : {0}\n\n", len);

        }
    }
}
