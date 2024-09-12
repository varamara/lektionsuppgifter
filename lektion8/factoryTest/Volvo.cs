namespace factoryTest;

public class Volvo : Car {

    public int Year { get; set; }
    public Volvo(int year) {
        Year = year;
    }

    public override void Drive() {
        Console.WriteLine("Driving the volvo");
    }
}