using TestProject;

public class Car : Vehicle
{
    public Car(string name) : base(name) {} // inherited from base

    public override string Honk()
    {
        return "beep";
    }
}