using TestProject;

public class Car : Vehicle
{
    public Car(string name) : base(name) {} // inherited from base

    public override void Honk()
    {
        Console.WriteLine("beep");
    }
}