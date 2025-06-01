using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        decimal[] N = new decimal[100];
        decimal X = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        N[0] = X;

        for (int i = 1; i < 100; i++) {
            N[i] = N[i - 1] / 2;
        }

        for (int i = 0; i < 100; i++) {
            decimal truncated = Math.Round(N[i] * 10000) / 10000;
            Console.WriteLine($"N[{i}] = {truncated.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
