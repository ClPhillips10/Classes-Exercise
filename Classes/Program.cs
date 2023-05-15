namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mycar = new Car();
            mycar.Year = 2020;
            mycar.Make = "Toyota";
            mycar.Model = "Corolla";

            var Worktruck = new Car()
            {
                Year = 2023,
                Model = "Tundra",
                Make = "Toyota",
            };
            

            Console.WriteLine($" I drive a {mycar.Year} {mycar.Make} {mycar.Model}. When I am working I drive a {Worktruck.Year} {Worktruck.Make} {Worktruck.Model}.");


        }

        }
}

