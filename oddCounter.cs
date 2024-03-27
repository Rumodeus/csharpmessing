using System;


public class Program
{


    int SumOdds(int[] digits)
    {
        

        int sum = 0;

        for(int i = 0; i < digits.Length; i++)
        {
            if (digits[i] % 2 != 0)
            {
                
            }sum += digits[i];
        }


        return sum;
    }


    static void Main(string[] args)
    {
        Console.WriteLine(new Program().SumOdds(new int[4] { 1, 5, 2, 8 }));

    }
}