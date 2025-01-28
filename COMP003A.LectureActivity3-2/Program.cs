namespace COMP003A.LectureActivity3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the iterative Statements Demo!\n");

            // Prompt for a positive integer
            int num;
            Console.Write("Enter a positive integer to generate its multiplaction table: ");
            num = int.Parse(Console.ReadLine());

            // Generate multiplication table using a for loop
            Console.WriteLine($"Multiplaction Table for {num}:");
            // Loop to genrate the multiplication table
            // the first statement initializes the loop variable i to 1
            // the second statement specifies the condition for the loop to continue
            // the third statement increments the loop variable  by 1
            for (int i = 1; i <= 10; i++)
            {
                // display the multiplication table
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }
    }
}
