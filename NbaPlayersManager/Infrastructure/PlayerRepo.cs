using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NbaPlayersManager.Models;

namespace NbaPlayersManager.Infrastructure
{
    public class PlayerRepo : IPlayerRepo
    {
        public async Task<IEnumerable<Player>> GetAll()
        {
            return  null;
        }
    }
}
