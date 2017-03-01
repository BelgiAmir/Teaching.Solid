using System;

namespace Teaching.Solid.OpenClose
{
    class TextMessageHandler : IMessageHandler
    {
        public void HandleMessage(Message message)
        {
            if (message.Type == MessageType.Text)
            {
                Console.WriteLine($"Displaying text message: {message.Content}");
            }
        }
    }
}
