namespace CSharp_DependencyInjection
{
    public class EmailSender
    {
        // This is the implementation of the interface
        public void SendMessage(string message, string recipient)
        {
            // Code to send an email
            Console.WriteLine($"Hi {recipient}, {message}");
        }
    }
}