using Microsoft.AspNetCore.Mvc;
using NbaPlayersManager.Infrastructure;
using NbaPlayersManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaPlayersManager.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerRepo _playerRepo;
        public PlayerController(IPlayerRepo playerRepo)
        {
            _playerRepo = playerRepo;
        }
        public IActionResult Index()
        {
            return View(_playerRepo.GetAll());
        }
        [HttpGet]
        public IEnumerable<Player> LoadData()
        {
            return _playerRepo.GetAll();
        }
    }
}
