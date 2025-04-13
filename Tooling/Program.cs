public class Program
{
    /// <summary>
    /// Prints the input message to the console.
    /// </summary>
    /// <param name="message">
    /// String message to be printed to the console.
    /// </param>
    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    /// <summary>
    /// Starting function for the program.
    /// </summary>
    /// <param name="args">
    /// Command line input arguments for the program.
    /// </param>
    public static void Main(string[] args)
    {
        Print("Hello, World!");
    }
}
