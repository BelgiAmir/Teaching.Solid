using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching.Solid.OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageHandler handler = new MessageHandler(
                new Dictionary<MessageType, IMessageHandler>()
            {
                { MessageType.Text, new TextMessageHandler()},
                { MessageType.Image, new ImageMessageHandler()},
                { MessageType.Voice, new VoiceMessageHandler()}
            });

            handler.HandleMessage(new Message("Text", MessageType.Text));
        }
    }
}
