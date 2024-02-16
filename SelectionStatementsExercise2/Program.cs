namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("What is your favorite school subject?");

        string subject = Console.ReadLine();

        switch(subject.ToLower())
        {
            case "math":
                Console.WriteLine("You must be good with numbers!");
                break;
            case "science":
                Console.WriteLine("Experiements are fun!");
                break;
            case "reading":
                Console.WriteLine("I bet you've read a lot of books!");
                break;
            case "history":
                Console.WriteLine("You must know about a lot of famous people!");
                break;
            case "health":
                Console.WriteLine("You probably know a lot about nutrition!");
                break;
            default:
                Console.WriteLine("That subject is not an option.");
                break;


        }

        }
    }
}