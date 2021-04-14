using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Models;

namespace TicketSystem.Data
{
    public class MvcTicketContext : DbContext
    {
        public MvcTicketContext(DbContextOptions<MvcTicketContext> options)
            : base(options)
        {

        }

        public DbSet<Ticket> Ticket { get; set; }
    }
}
