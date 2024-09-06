public class Student {
    public string? Name { get; set; }
    public int Grade { get; set; }

    public void isPassing(){

        if ( Grade >= 50) {
            Console.WriteLine("Student is passing");
        } else {
            Console.WriteLine("Student is failing");
        }
    }

    public void displayStudentDetails(){
        Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        isPassing();
    }
}