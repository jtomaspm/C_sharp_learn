using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Class1
    {
        public static void Main (String[] args)
        {
            String s = Console.ReadLine();
            String[] arg = s.Split(' ');
            Console.WriteLine(swap(s));
            Console.ReadKey();
        }

        private static int countN (String[] arg)
        {
            int count = 0;
            foreach (String s in arg)
            {
                foreach (char c in s)
                {
                    if (Char.IsDigit(c))
                    {
                        count++;
                    }

                }
            }
            return count; 
        }

        private static Boolean min(String[] arg)
        {
            foreach (String s in arg)
            {
                foreach (char c in s)
                {
                    if (Char.IsUpper(c))
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        private static Boolean cap(String[] arg)
        {
            foreach (String s in arg)
            {
                foreach (char c in s)
                {
                    if (Char.IsLower(c))
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        private static int numWords(String[] arg)
        {
            foreach (String s in arg)
            {
                Console.WriteLine(s);
            }
            return arg.Length;
        }

        private static String swap(String arg)
        {
            char[] c = arg.ToCharArray();
            char t;
            for (int i = 0; i < arg.Length - 1; i+=2)
            {
                t = c[i];
                c[i] = c[i + 1];
                c[i + 1] = t;
            }
            String s = "";
            foreach (char a in c)
            {
                s += a;
            }
            return s;
        }
    }
}
