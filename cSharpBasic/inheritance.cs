using System;

public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetCircumference();

    public virtual void PrintResult()
    {
        Console.WriteLine("result is given as .....");

    }


}
interface IDiagonalComputable
{
    public double GetDiagonal();
}
public class Rectangle : Shape,IDiagonalComputable
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double length,
                   double breadth)
    {
        Length = length;
        Breadth = breadth;
    }


    public override double GetArea() => Length * Breadth;
    public override double GetCircumference() => 2 * (Length * Breadth);

    public override void PrintResult()
    {
        Console.WriteLine($"the area and the circumference of rectangle [{Length }x {Breadth}]");
        Console.WriteLine($"area:{this.GetArea()} Circumference:{this.GetCircumference()}");
    }
     
    public double GetDiagonal()=>Math.Sqrt(Length*Length+Breadth*Breadth);


}
public class Square : Rectangle
{
    public Square(double side): base (side,side)
    {
        
    }

}
public class circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetCircumference() => 2 * Math.PI * Radius;



}
