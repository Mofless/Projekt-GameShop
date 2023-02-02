using Microsoft.Extensions.Hosting;
using Ihor_Projekt_Game.Models;
    
namespace Ihor_Projekt_Game.Services
{
    public interface IGameService
    {
        //change but on game!!!
        public int Save(Game but);

        public bool Delete(int? id);


        ///////////////////////////
        public int Update(Game game);

        ///////////////////////////



        public ICollection<Game> FindAll();






        ///////////////////////////

        public Game? FindBy(int? id);

        public void ChangeGameGenere(Genre genre, int? id);

        ///////////////////////////
        ///


        public int SaveC(CollectionGame collectionGame);


        public ICollection<CollectionGame> FindAllC();



    }

}




 

