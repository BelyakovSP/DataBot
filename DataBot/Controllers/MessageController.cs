using DataBot.Models;
using DataBot.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBot.Controllers
{
    [ApiController]
    [Route("Message")]
    public class MessageController : Controller
    {
        readonly IMessageRepository _messageRepository;
        readonly ILogger _logger;
        public MessageController(IMessageRepository messageRepository, ILogger<MessageController> logger)
        {
            _messageRepository = messageRepository;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Message> Get()
        {
            _logger.LogInformation($"Всем привет! {_messageRepository.GetMessageById(12)}");
            return _messageRepository.GetMessages();
        }

        /// <summary>
        /// Get Message
        /// </summary>
        /// <param name="id"></param>

        [HttpGet("{id}")]
        public Message Get(int id)
        {
            return _messageRepository.GetMessageById(id);
        }
    }
}
