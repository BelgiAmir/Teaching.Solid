namespace Teaching.Solid.OpenClose.Before
{
    public class Program
    {
        static void Main(string[] args)
        {
            MessageHandler handler = new MessageHandler();
            handler.HandleMessage(new Message("Text", MessageType.Text));
        }
    }
}
