using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Ihor_Projekt_Game.Models;
using Ihor_Projekt_Game.Services;

namespace Ihor_Projekt_Game.Controllers
{
    public class GameController : Controller
    {
                         
        private readonly IGameService _gameService;
        public GameController(AppDbContext context, IGameService postService)
        {
            _gameService = postService;
        }

        public IActionResult Index()
        {
            return View(_gameService.FindAll());
        }

        //Dodawanie 

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromForm] Game game)
        {
            if (ModelState.IsValid)
            {
                _gameService.Save(game);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}
