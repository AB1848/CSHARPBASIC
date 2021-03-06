using System;
public class MethodTeacher

{
    static void main5()
    {
        MethodTeacher mt = new MethodTeacher();
        double sum = mt.Sum(245.236, 23546.1);
        Console.WriteLine($"sum is {sum}");//interpolation means importing value from placeholder sum 
        MethodTeacher mt2 = new MethodTeacher();
        int[] number = { 12, 13, 54, 78, 21, 54, 25, 36, 14 };
        (int min, int max) result = mt2.FindMinMax(number);
        Console.WriteLine($"this is {result.min} and this is {result.max}");

        MethodTeacher mt3 = new MethodTeacher();
        int sum1 = mt3.SumEvens(2, 3, 4);
        Console.WriteLine($"sum is {sum1}");
    }
    //simple method:with 2 arguments and a return type
    public double Sum(double x, double y)//funtion is same here in 11 and 28 line this is called function overloading 
    {
        return x + y;
    }
    //when we have vaiable number of argument 
    public int SumEvens(params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                sum = sum + num;
            }
        }
        return sum;

    }
    public double Sum(params double[] nums)//function overloading is taking because of same function name in line 11 and line 28
    {
        double sum = 0;
        foreach (double num in nums)
        {
            sum = sum + num;

        }
        return sum;
    }
    //Returning multiple value -using tuples
    //Method to find Min and Max in given sets of numbers

    (int, int) FindMinMax(int[] number)
    {
        int min = number[0];
        int max = number[0];

        foreach (int num in number)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return (min, max);

    }
}
