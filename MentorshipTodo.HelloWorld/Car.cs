namespace MentorshipTodo.HelloWorld;

public class Car
{
    public required string Model { get; set; }
    public required DateOnly ReleseadAt { get; set; }
    public required Color Color { get; set; }
    
    // public string Model { get; set; }
    // public DateOnly ReleseadAt { get; set; }
    // public Color Color { get; set; }

    // Constructor
    // public Car(string model, DateOnly releseadAt, Color color)
    // {
    // }

    public void WriteModelName() => Console.WriteLine(Model);
    public void WriteCar() => Console.WriteLine($"Model: {Model},\nRelesead At: {ReleseadAt},\nColor: {Color}.");
}

    
