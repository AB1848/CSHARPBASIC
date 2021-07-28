public class MethodTeacher

{
    static void main5()
    {
        MethodTeacher mt = new MethodTeacher();
        double sum = mt.sum(245.236, 23546.1);
        console.WriteLine($"sum is {sum}");//interpolation means importing value from placeholder sum 
        MethodTeacher mt2 = new MethodTeacher();
        int[] number = { 12, 13, 54, 78, 21, 54, 25, 36, 14 };
        (int min, int max) result = mt2.FindMinMax(number);
        console.WriteLine($"this is {result.min} and this is {result.max}");
    }
    //simple method:with 2 arguments and a return type
    double sum(double x, double y)//funtion is same here in 11 and 28 line this is called function overloading 
    {
        return x + y;
    }
    //when we have vaiable number of argument 
    public int SumEvens(params int[] numeral)
    {
        int sum = 0;
        foreach (int num in numeral)
        {
            if (num % 2 == 0)
            {
                sum = sum + num;
            }
            return sum;
        }
    }
    public double sum(params double[] nums)//function overloading is taking because of same function name in line 11 and line 28
    {
        sum = 0;
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
            if (num < min) ;
            min = num;
            if (num > max) ;
            max = num;
        }
        return (min, max);

    }
}
  