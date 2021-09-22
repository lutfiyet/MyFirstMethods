using System;

namespace SomeMethods
{
    public class Car
    {
        public Car()
        {
            Colour = "Blue";
            MaxSpeed = 125;
        }
        public Car(string colour,int maxSpeed)
        {
            Colour = colour;
            MaxSpeed = maxSpeed;
        }
        public string Colour { get; set; }
        public int MaxSpeed { get; set; }

        public void SpeedAndColour()
        {
            Console.WriteLine($"{Colour} car goes with {MaxSpeed} kmh");
        }
    }




    class Program
    {
        static void MyFirstMethod()
        {
            Console.WriteLine("Hello from My first Method");
        }
        static void MyFirstMethod(string Name)
        {
            Console.WriteLine("Hello from My first Method from "+ Name+" ,this is a overload Method");
        }
        static int Operations(int a,int b)
        {
            return a + b;
        }
        static int Operations(int a, int b,string operation)
        {
            switch (operation)
            {
                case "*":
                    return a * b;
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                default:
                    return a / b;
            }
            
        }

        static void Main(string[] args)
        {
            MyFirstMethod();
            Console.Write("Please tell me your name= " );
            string name = Console.ReadLine();
            MyFirstMethod(name);
            Console.Write("\n"+"Tell me what to do with two numbers \"*\" or \"+\" or \"-\" ");
            string operationname = Console.ReadLine();
            int resultAdd = Operations(16,4);
            int oprResult = Operations(16, 4,operationname);
            Console.WriteLine("your result for "+operationname+ " is= "+oprResult);
            Console.Write("\n"+"Your Result for Addition is= " + resultAdd +"\n");
            Car car = new Car("Black",150);
           // car.Colour = "Red";
            car.SpeedAndColour();
           
        }
    }
}
