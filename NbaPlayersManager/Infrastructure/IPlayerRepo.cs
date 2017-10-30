using NbaPlayersManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaPlayersManager.Infrastructure
{
    public interface IPlayerRepo
    {
        Task<IEnumerable<Player>> GetAll();
            
    }
}
