namespace factoryTest;

public class CarFactory
{
    public static Car GetCar(string choice) {
        switch(choice.ToLower()) {
            case "Volvo s60":
                return new Volvo(1995);
            case "Volvo v70":
                return new Volvo(2017);
            case "saab":
                return new Saab();
            default:
                throw new ArgumentException("Invalid car type");
        }
    }
}