using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using The_Unsent_Project.Data;
using The_Unsent_Project.Models;
using The_Unsent_Project.Repositories.Interfaces;

namespace The_Unsent_Project.Repositories
{
    public class MessagesRepository : IMessagesRepository
    {
        private readonly ApplicationDbContext _context;

        public MessagesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Message>> Get()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task<IList<Message>> Get(int limit)
        {
            return await _context.Messages
                .OrderByDescending(message => message.Identifier)
                .Take(limit)
                .ToListAsync();
        }

        public async Task<IList<Message>> Get(string to, bool exact)
        {
            return await _context.Messages.Where(message => exact ? message.To.Equals(to) : message.To.Contains(to))
                .ToListAsync();
        }

        public async Task<Message> Add(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            return message;
        }
    }
}