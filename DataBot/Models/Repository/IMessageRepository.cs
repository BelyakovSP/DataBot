using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBot.Models.Repository
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetMessages();
        Message GetMessageById(int messageId);
        void CreateMessage(Message message);
        void DeleteMessage(int messageId);
        void UpdateMessage(Message message);
    }
}
