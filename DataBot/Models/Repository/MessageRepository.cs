using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBot.Models.Repository
{
    public class MessageRepository : IMessageRepository
    {
        public void CreateMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void DeleteMessage(int messageId)
        {
            throw new NotImplementedException();
        }

        public Message GetMessageById(int messageId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> GetMessages()
        {
            throw new NotImplementedException();
        }

        public void UpdateMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
