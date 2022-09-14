using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        int numberA = new Random().Next(1, 10); //1.2.3.4...9
        Console.WriteLine(numberA);
        int numberb = new Random().Next(1, 10);
        Console.WriteLine(numberb);
        int result = (numberA + numberb);
Console.WriteLine(result);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}       