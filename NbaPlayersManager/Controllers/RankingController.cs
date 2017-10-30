using Microsoft.AspNetCore.Mvc;
using NbaPlayersManager.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbaPlayersManager.Controllers
{
    public class RankingController : Controller
    {
        private readonly IRankingRepo _rankingRepo;
        public RankingController(IRankingRepo rankingRepo)
        {
            _rankingRepo = rankingRepo;
        }
        public IActionResult Index()
        {
            return View(_rankingRepo.GetAll());
        }
    }
}
