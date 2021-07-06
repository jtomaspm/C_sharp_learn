using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLearn
{
    class Test
    {
        public static int timeWasted = 0;
        public const int PI100PE = 69;

        public static void Main (String[] args)
        {

            double t = 0;
            int loops = 1000;
            double percentage;
            double last =  0;
            for (int i = 0; i < loops; i++)
            {
                t += getKSweat();
                percentage = (int)((i*100) / loops);
                    if (!(last == percentage))
                    {
                        Console.WriteLine(percentage + "%");
                    }
                    last = percentage;
            }
            t /= loops;
            Console.WriteLine(Math.Truncate(1.2));

            Console.ReadKey();

        }

        private static int getKSweat ()
        {
            Random random = new Random();
            int time = 0;
            int sweat = 0;
            while (sweat < 1000)
            {
                if (!Stop())
                {
                    time += 3;
                    if (HitSweat())
                    {
                        sweat += GetSweat();
                    }
                }
                else
                {
                    time += random.Next(1, 4);
                }
            }
            
            return time;
        }

        private static Boolean HitSweat()
        {
            Random random = new Random();
            int prob = random.Next(1, 100);
            return prob <= 70;
        }

        private static int GetSweat()
        {
            Random random = new Random();
            return random.Next(1, 4);
        } 

        private static Boolean Stop()
        {
            var random = new Random();
            int prob = random.Next(1, 100);
            return prob <= 20;
        } 
        


    }
}
