namespace CSharp_DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Learning Dependency Injection!");

            Messenger whatsappMessenger = new Messenger(new WhatsAppSender());

            whatsappMessenger.SendMessage("This is a whatsapp message", "john doe");
        }

    }
}
