namespace TestProject
{
    public class Vehicle 
    {
        protected string name;

        public Vehicle(string name)
        {
            this.name = name;
        }

        public void Drive()
        {
            Console.WriteLine($"{name} is now driving.");
        }

        public virtual string Honk()
        { 
           return "HONK";
        }
    }
}