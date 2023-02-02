using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Ihor_Projekt_Game.Models;
using Ihor_Projekt_Game.Services;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.EntityFrameworkCore;

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



        [HttpGet]
        //[Authorize(Roles = "admin")]
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








        ////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        //[Authorize(Roles = "admin")]
        public IActionResult ChangeGenere([FromRoute] int id)
        {
            ViewBag.gameId = id;
            return View();
        }

        [HttpPost]
        public IActionResult ChangeGenere([FromForm] Genre genre)
        {
            if (ModelState.IsValid)
            {
                _gameService.ChangeGameGenere(genre, genre.GameId);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();




            }
                         
        }







        [HttpGet]
        //[Authorize(Roles = "admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            _gameService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        ////////////////////////////////////////////////////////////////////////////////
        ///






        [HttpGet]
        //[Authorize(Roles = "admin")]
        public IActionResult AddCollectionGame()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCollectionGame([FromForm] CollectionGame collectionGame)
        {
            if (ModelState.IsValid)
            {
                _gameService.SaveC(collectionGame);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(collectionGame);
            }
        }


        public IActionResult ListaCollectionGame()
        {
            return View(_gameService.FindAllC());
        }













    }
}
