using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        float i, j;

        for (i = 0f; i <= 2.1f; i += 0.2f)
        {
            for (j = 1.0f; j <= 3.0f; j++)
            {
                if (i > 0 && i < 1 || i > 1 && i < 2)
                {
                    Console.WriteLine("I={0} J={1}", i.ToString("0.0", CultureInfo.InvariantCulture), (j + i).ToString("0.0", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("I={0} J={1}", i.ToString("0", CultureInfo.InvariantCulture), (j + i).ToString("0", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
