using System;

namespace Teaching.Solid.OpenClose.Before
{
    public class MessageHandler
    {
        public void HandaleMessage(Message message)
        {
            if(message.Type == MessageType.Text)
            {
                Console.WriteLine("Displaying text message");
            }

            else if(message.Type == MessageType.Image)
            {
                Console.WriteLine("Displaying image on screen");
            }

            else if (message.Type == MessageType.Voice)
            {
                Console.WriteLine("Playing message");
            }
        }
    }
}
