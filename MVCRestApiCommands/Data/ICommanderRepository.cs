using MVCRestApiCommands.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCRestApiCommands.Data
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
