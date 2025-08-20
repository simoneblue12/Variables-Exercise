namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Simone";
            int age = 23;
            double avg = 92.4;
            decimal bankAccount = 10000.00m;
            char initial = 'S';
            bool isMarried = false;

            Console.WriteLine($"Name: {myName}\nAge: {age}\nAverage: {avg}\nMoney: {bankAccount}\nInitial: {initial}\nMarried: {isMarried}");
        }
    }
}
