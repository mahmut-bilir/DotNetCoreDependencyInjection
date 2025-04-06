public class ConsoleMessageService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }
}