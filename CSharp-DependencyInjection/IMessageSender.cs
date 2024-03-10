namespace CSharp_DependencyInjection
{
public interface IMessageSender
{
    // This is the contract that any message sender must follow
    void SendMessage(string message, string recipient);
}
}
