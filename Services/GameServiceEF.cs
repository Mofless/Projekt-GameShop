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

            var find = _context.Game.Find(id);
            if (find is not null)
            {
                _context.Game.Remove(find);
                _context.SaveChanges();
                return true;
            }
            return false;
        }



        public ICollection<Game> FindAll()
        {
            return _context.Game.ToList();
        }



        public int Save(Game game)
        {
            try
            {
                var entityEntry = _context.Game.Add(game);
                _context.SaveChanges();
                return entityEntry.Entity.Id;
            }
            catch
            {
                return -1;
            }
        }



    }
}







