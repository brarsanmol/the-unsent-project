using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Unsent_Project.Models;
using The_Unsent_Project.Repositories.Interfaces;

namespace The_Unsent_Project.Controllers
{
    /// <summary>
    /// The messages controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        /// <summary>
        /// The repository that provides access to messages.
        /// </summary>
        private readonly IMessagesRepository _repository;
        
        public MessagesController(IMessagesRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Returns a JSON array of all the messages in the database.
        /// </summary>
        /// <returns>A JSON array of all messages.</returns>
        [HttpGet]
        public async Task<IList<Message>> Get()
        {
            return await _repository.Get();
        }

        /// <summary>
        /// Returns a JSON array of the most recent N messages in the database.
        /// </summary>
        /// <param name="limit">The maximum number of recent messages to return.</param>
        /// <returns>A JSON array of N messages.</returns>
        [HttpGet("Limit/{limit}")]
        public async Task<IList<Message>> Get(int limit)
        {
            return await _repository.Get(limit);
        }

        /// <summary>
        /// Returns a JSON array of messages that match the provided search criteria.
        /// </summary>
        /// <param name="to">The term to search the database for.</param>
        /// <param name="exact">Whether to match the search term exactly.</param>
        /// <returns>A JSON array of any matched messages.</returns>
        [HttpGet("{to}")]
        public async Task<IList<Message>> Get(string to, [FromQuery] bool exact)
        {
            return await _repository.Get(to, exact);
        }

        /// <summary>
        /// Takes in a message and requests its addition to the database.
        /// </summary>
        /// <param name="message">The message to add to the database.</param>
        /// <returns>If successful, the model that was added. Otherwise, the validation errors for the model.</returns>
        [HttpPost]
        public async Task<Message> Add([FromBody] Message message)
        {
            return await _repository.Add(message);
        }
    }
}