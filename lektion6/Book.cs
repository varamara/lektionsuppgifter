namespace lektion6;

public class Book
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public double Price { get; set; }


    public void getDiscountedPrice(double discountPercentage)
    {
        Price -= Price * (discountPercentage / 100);
    }

    public void displayBookDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
    }
}

