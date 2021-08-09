using System.Collections.Generic;
using System.Threading.Tasks;
using The_Unsent_Project.Models;

namespace The_Unsent_Project.Repositories.Interfaces
{
    public interface IMessagesRepository
    {
        public Task<IList<Message>> Get();

        public Task<IList<Message>> Get(string to, bool exact);

        public Task<IList<Message>> Get(int limit);

        public Task<Message> Add(Message message);
    }
}