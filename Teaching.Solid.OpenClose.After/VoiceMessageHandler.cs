using System;

namespace Teaching.Solid.OpenClose
{
    class VoiceMessageHandler : IMessageHandler
    {
        public void HandleMessage(Message message)
        {
            if (message.Type == MessageType.Voice)
            {
                Console.WriteLine($"Playing message: {message.Content}");
            }
        }
    }
}
