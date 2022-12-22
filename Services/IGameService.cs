using Microsoft.Extensions.Hosting;
using Ihor_Projekt_Game.Models;
    
namespace Ihor_Projekt_Game.Services
{
    public interface IGameService
    {
        public int Save(Game but);

        public bool Delete(int? id);

        public ICollection<Game> FindAll();
    }
    
}






