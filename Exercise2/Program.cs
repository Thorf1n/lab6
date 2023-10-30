namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperations = new MathOperation();
            Random random = new Random();

     
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);

            Console.WriteLine($"Random Numbers: {number1}, {number2}");
            Console.WriteLine($"Addition: {mathOperations.Add(number1, number2)}");
            Console.WriteLine($"Subtraction: {mathOperations.Subtract(number1, number2)}");
            Console.WriteLine($"Multiplication: {mathOperations.Multiply(number1, number2)}");

            int[] array1 = { random.Next(1, 100), random.Next(1, 100), random.Next(1, 100) };
            int[] array2 = { random.Next(1, 100), random.Next(1, 100), random.Next(1, 100) };

            Console.WriteLine($"Random Arrays: [{array1[0]}, {array1[1]}, {array1[2]}], [{array2[0]}, {array2[1]}, {array2[2]}]");
            int[] resultArray = mathOperations.Add(array1, array2);
            Console.WriteLine($"Array Addition: [{resultArray[0]}, {resultArray[1]}, {resultArray[2]}]");
            Console.ReadLine();
        }
    }
}