using System;
class Program
{
    public static int MostFreq(int[] arr, out int x)
    {
        
        int M_F, N_F, i, k;

        Array.Sort(arr);

        k = arr[0];

        M_F = 0; i = 0; x = 0;

        while (i < arr.Length)
        {
            N_F = 0;

            while (k == arr[i])
            {
                N_F++;
                i++;
                if (i == arr.Length)
                    break;
            }

            if (N_F > M_F)
            {
                M_F = N_F;
                x = k;
            }

            if (i < arr.Length)
                k = arr[i];

        }
        return (M_F);
    }
    static void Main()
    {
        int[] arr = { 4 ,1 ,1 ,4 ,2 ,3 ,4 ,4 ,1 ,2 ,4 ,9 ,3 };
        int x;
        int f = MostFreq(arr, out x);
        Console.WriteLine("Number = {0} Count = {1}", x, f);
        Console.ReadKey();
    }

}


