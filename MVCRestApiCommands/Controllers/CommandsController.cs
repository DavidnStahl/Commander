using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCRestApiCommands.Data;
using MVCRestApiCommands.Models;

namespace MVCRestApiCommands.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepository _repository;

        public CommandsController(ICommanderRepository repository)
        {
            _repository = repository;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commmandItem = _repository.GetCommandById(id);

            return Ok(commmandItem);
        }
    }
}
