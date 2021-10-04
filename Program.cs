using System;

namespace From_A_to_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string ab = Console.ReadLine();
            string[] abArray = ab.Split(' ');
            int a = Convert.ToInt32(abArray[0]);
            int b = Convert.ToInt32(abArray[1]);
            int count = 0;   

            while (a > b)
            {
                if (a % 2 != 0)
                {
                    a += 1;
                    count += 1;
                }

                a /= 2;
                count += 1;
            }
            if(a < b)
            {
                count += b - a;
            }

            Console.WriteLine(count);
        }


    }
}
