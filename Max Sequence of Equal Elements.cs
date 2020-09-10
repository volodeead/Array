using System;
class Program
{
    static void Main(string[] args)
    {

        int[] arr = { 3, 2, 3, 4, 2, 2, 4 };

        int len = 1;
        int bestlen = len;
        int value = 0, bestvalue = 0;
        for (int i = 1; i < arr.Length; i++)
        {

            if (arr[i] == arr[i - 1])
            {
                len++;
                value = arr[i];
                if (len > bestlen)
                    bestvalue = value;
            }
            else
            {


                if (len > bestlen)
                {
                    bestvalue = value;
                    bestlen = len;
                    len = 1;
                    value = 0;
                }
                else
                {
                    len = 1;
                }
            }

        }

        Console.WriteLine("Best len : " + bestlen + " " + "Best value : " + bestvalue);
        Console.WriteLine("");
        if (bestlen == 1)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write(bestvalue + " ");
            }
        }
        else
        {
            for (int i = 0; i < bestlen; i++)
            {
                Console.Write(bestvalue + " ");
            }
        }
        Console.ReadKey();

    }
}