using System.Collections.Generic;
using System.Threading.Tasks;
using The_Unsent_Project.Models;

namespace The_Unsent_Project.Repositories.Interfaces
{
    /// <summary>
    ///     This repository provides an abstraction between the database and the MessagesController.
    ///     It allows Create and Read operations.
    ///     This abstraction allows multiple implementations to created for multiple databases (an unlikely use case).
    /// </summary>
    public interface IMessagesRepository
    {
        /// <summary>
        ///     Asynchronously gets a list of all messages in the database.
        /// </summary>
        /// <returns>A list of all messages.</returns>
        public Task<IList<Message>> Get();

        /// <summary>
        ///     Asynchronously gets a list of all messages that fit a search criteria in the database.
        /// </summary>
        /// <param name="to">The value to search our database for.</param>
        /// <param name="exact">A parameter to have our search results match our exact to parameter.</param>
        /// <returns>A list of all messages matching the search parameters.</returns>
        public Task<IList<Message>> Get(string to, bool exact);

        /// <summary>
        ///     Asynchronously gets a list of the most recent N messages.
        /// </summary>
        /// <param name="limit">The number of messages to return.</param>
        /// <returns>A list of the N most recent messages.</returns>
        public Task<IList<Message>> Get(int limit);

        /// <summary>
        ///     Asynchronously adds a message to the database.
        /// </summary>
        /// <param name="message">The message to add.</param>
        /// <returns>The message.</returns>
        public Task<Message> Add(Message message);
    }
}