using System;

namespace FastClock
{
    class FastClock
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;

            while (z != 24)
            {
                x = ++x;
                if (x == 60)
                {
                    x = 0;
                    y = ++y;
                    if (y == 24)
                    {
                        y = 0;
                        z = ++z;
                    }
                }

                Console.WriteLine(z + ":" + y + ":" + x);
            }
        }
    }
}
