using System;

namespace Teaching.Solid.OpenClose.Before
{
    class MessageHandler
    {
        public void HandleMessage(Message message)
        {
            if(message.Type == MessageType.Text)
            {
                Console.WriteLine($"Displaying text message: {message.Content}");
            }

            else if(message.Type == MessageType.Image)
            {
                Console.WriteLine($"Displaying image on screen: {message.Content}");
            }

            else if (message.Type == MessageType.Voice)
            {
                Console.WriteLine($"Playing message: {message.Content}");
            }
        }
    }
}
