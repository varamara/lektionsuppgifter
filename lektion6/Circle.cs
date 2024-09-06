using System.Formats.Asn1;

public class Circle
{

    public double Radius { get; set; }

    public double getArea()
    {
        //Vill man returnera en varibel eller kan man bara returnera uträkningen direkt? return 2 * Math.PI * Radius;
        double area = Math.PI * Math.Pow(Radius, 2);
        return area;
    }

    public double getPerimeter()
    {

        double perimeter = 2 * Math.PI * Radius;
        return perimeter;
    }

    public void displayCircleDetails()
    {
        Console.WriteLine($"Radius: {Radius}, Area: {getArea()}, Perimeter: {getPerimeter()}");
    }
}