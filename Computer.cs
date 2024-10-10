public class Computer
{
    private readonly string[] options = { "r", "p", "s" };
    private readonly Random random = new();

    public string MakeChoice()
    {
        int choiceIndex = random.Next(options.Length);
        return options[choiceIndex];
    }
}