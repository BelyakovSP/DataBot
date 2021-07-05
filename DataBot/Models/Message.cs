using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBot.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}
