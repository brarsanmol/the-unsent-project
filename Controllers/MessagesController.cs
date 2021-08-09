using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using The_Unsent_Project.Models;
using The_Unsent_Project.Repositories.Interfaces;

namespace The_Unsent_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessagesRepository _repository;

        public MessagesController(IMessagesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IList<Message>> Get()
        {
            return await _repository.Get();
        }

        [HttpGet("Limit/{limit}")]
        public async Task<IList<Message>> Get(int limit)
        {
            return await _repository.Get(limit);
        }

        [HttpGet("{to}")]
        public async Task<IList<Message>> Get(string to, [FromQuery] bool exact)
        {
            return await _repository.Get(to, exact);
        }

        [HttpPost]
        public async Task<Message> Add([FromBody] Message message)
        {
            return await _repository.Add(message);
        }
    }
}