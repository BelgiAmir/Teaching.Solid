using System;

namespace Teaching.Solid.OpenClose
{
    class ImageMessageHandler : IMessageHandler
    {
        public void HandleMessage(Message message)
        {
            if (message.Type == MessageType.Image)
            {
                Console.WriteLine($"Displaying image on screen: {message.Content}");
            }
        }
    }
}
