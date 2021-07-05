using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBot.Models
{
    public class DataBotContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DataBotContext(DbContextOptions<DataBotContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
