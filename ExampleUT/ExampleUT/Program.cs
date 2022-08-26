namespace ExampleUT
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Calculation
    {
        public float Addition(float a, float b)
        {
            return a + b;
        }
        public float Subtraction(float a, float b)
        {
            return a - b;
        }
        public float Multiplication(float a, float b)
        {
            return a * b;
        }
        public double Division(float a, float b)
        {
            return a / b;
        }
    }
}