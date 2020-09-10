using System;
 class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("intput size of arr : ");

        int a;
        a = Convert.ToInt32(Console.ReadLine());
        
        int[]b = new int[a];
        int[]c = new int[a];
        int[]sum = new int[a];

        Random rnd = new Random();

        for(int i=0; i<a; i++)
        {
            b[i] = rnd.Next(11);
        }

        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i]+" ");// Вивід 1 масиву
        }

        Console.WriteLine(" ");
        int raz = Convert.ToInt32(Console.ReadLine());

        for (int r = 0; r < raz; r++)
        {
                for (int i = 0, j = 1; i < b.Length - 1; i++, j++)
                {
                    if (i == 0)
                    {
                        c[i] = b[b.Length - 1];
                        c[j] = b[i];
                    }
                    else
                    {
                        c[j] = b[i];
                    }
                }
                for (int i = 0; i < sum.Length; i++)
                {
                    if (raz != 1)
                    {
                        if (r == 1)
                        {
                            sum[i] = b[i] + c[i];
                            Console.Write(sum[i] + " ");
                        }
                        else
                        {
                            sum[i] = sum[i] + c[i];
                            Console.Write(sum[i] + " ");
                        }
                    }
                else
                {
                    for (int t = 0; t < c.Length; t++)
                    {
                        Console.Write(c[t] + " ");
                    }
                    break;
                }
                }
                Console.WriteLine(" ");
            
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = c[i];
                }
                for (int i =0; i< c.Length; i++)
                {
                    c[i] = 0;
                }
        }


        Console.WriteLine();



        

        Console.ReadKey();
    }

    }

