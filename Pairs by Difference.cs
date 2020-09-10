using System;
class Program
    {
    static void Main(string[] args)
    {

        int[] arr = { 1 ,5 ,3 ,4 ,2 };
        int count = 0;
        int Shukai;

        Shukai = Convert.ToInt32(Console.ReadLine());

        for(int i=0; i< arr.Length; i++)
        {
            for(int j=0; j < arr.Length; j++)
            {
                if (Shukai==arr[i] + arr[j]||Shukai==arr[i]-arr[j]||Shukai==arr[j]-arr[i])
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Number of combin : " + count/2);
        Console.ReadKey();

        }
    }

