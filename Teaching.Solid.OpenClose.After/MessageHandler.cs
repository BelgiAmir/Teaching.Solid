using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching.Solid.OpenClose
{
    class MessageHandler
    {
        Dictionary<MessageType, IMessageHandler> _handlers;

        public MessageHandler(Dictionary<MessageType, IMessageHandler> handlers)
        {
            _handlers = handlers;
        }

        public void HandleMessage(Message message)
        {
            IMessageHandler handler;
            if(_handlers.TryGetValue(message.Type, out handler))
            {
                handler.HandleMessage(message);
            }
        }
    }
}
