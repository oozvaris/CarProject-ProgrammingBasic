namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Red");

            myCar.Accelerate(50);

            Console.ReadLine();

            myCar.Accelerate(10);

            Console.ReadLine();

            myCar.Brake(10);

            Console.ReadLine();

            myCar.Stop();

            Console.ReadLine();
        }
    }
}
