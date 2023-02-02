using Ihor_Projekt_Game.Models;
using Microsoft.EntityFrameworkCore;

namespace Ihor_Projekt_Game.Services
{
    public class GameServiceEF : IGameService
    {
        private readonly AppDbContext _context;

        public GameServiceEF(AppDbContext context)
        {
            _context = context;
        }



        public bool Delete(int? id)
        {
            if (id is null)
            {
                return false;
            }

            var g = _context.Game.Find(id);
            if (g is not null)
            {
                _context.Game.Remove(g);
                _context.SaveChanges();
                return true;
            }
            return false;
        }



        //////////////////////////////////////////////////////////
        public ICollection<Game> FindAll()
        {
            return _context.Game.Include(e => e.Genre).ToList();
        }


        public Game? FindBy(int? id)
        {
            return id is null ? null : _context.Game.Find(id);
        }
        //////////////////////////////////////////////////////////




        public int Save(Game game)
        {
            try
            {
                var entityEntry = _context.Game.Add(game);
                _context.SaveChanges();
                return entityEntry.Entity.GameId;
            }
            catch
            {
                return -1;
            }
        }







        //////////////////////////////////////////////

        public int Update(Game game)
        {
            try
            {
                var g = _context.Game.Find(game.GameId);
                if (g is not null)
                {
                    g.GameId = game.GameId;
                    g.NCompany = game.NCompany;
                    g.PriseG = game.PriseG;
                    g.NGame = game.NGame;
                    g.Genre = game.Genre;


                    _context.SaveChanges();
                    return game.GameId;
                }
                return -1;
            }
            catch (DbUpdateConcurrencyException)
            {
                return -1;
            }
        }


        //change but => game!!!
        public void ChangeGameGenere(Genre genre, int? id)
        {
            Game? but = id is null ? null : _context.Game.Find(id);
            but.Genre = genre;
            genre.Game = but;

            _context.Game.Update(but);
            _context.Genre.Update(genre);

            _context.SaveChanges();
        }



        //////////////////////////////////////////////
        ///


        public int SaveC(CollectionGame collectionGame)
        {
            try
            {
                var entityEntry = _context.CollectionGame.Add(collectionGame);
                _context.SaveChanges();
                return entityEntry.Entity.CollectionGameId;
            }
            catch
            {
                return -1;
            }
        }


        ////
        public ICollection<CollectionGame> FindAllC()
        {
            return _context.CollectionGame.ToList();
        }
    }



}








