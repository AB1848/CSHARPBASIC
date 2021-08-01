using System;


public class Program
{
    static public void main()
    {
        var square1 = new Square(23.45);
        var square2 = new Square(4);
        var square3 = new Square(12);
        var rectangle = new Rectangle(12.24, 456.12);
        rectangle.PrintResult();
    }
}




public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetCircumference();

    public virtual void PrintResult()
    {
        console.writeline("result is given as .....");

    }


}
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public RecData(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }


    public override double GetArea() => Length * Breadth;
    public override double GetCircumgference() => 2 * (Length * Breadth);

    public override void PrintResult()
    {
        Console.WriteLine($"the area and the circumference of rectangle [{Length }x {Breadth}]");
        Console.writeline($"area:{this.GetArea()} Circumference:{this.GetCircumference()}");
    }

}
public class Square : Rectangle
{
    public GetValue(double side): base(side,side)
    {}

}
public class circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;



}
