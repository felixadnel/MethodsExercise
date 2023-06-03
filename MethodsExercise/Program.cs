namespace MethodsExercise
{
    public class Program
    {


        static void Main(string[] args)
        {



            // ---------------------------------------------

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is a great color! Whats your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("Awesome! And what is your favorite band?");
            var band = Console.ReadLine();


            Console.WriteLine($"Thanks, {userName} here is your profile! ");

            Console.WriteLine("------------------------------------------");

            Console.WriteLine($"Name: {userName} ");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            Console.WriteLine("------------------------------------------");


            Console.WriteLine("Give me a number to add");
            int numb1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to add to the first one");
            int numb2 = int.Parse(Console.ReadLine());

            int sum = Sum(numb1, numb2);
            Console.WriteLine($"The sum is: {sum}");

        }

        public static int Sum(int num1, int num2)
        {

            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int x, int y)
        {
            return (x * y);
        }








    }
}