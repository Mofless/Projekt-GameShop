using System.ComponentModel.DataAnnotations;

namespace Ihor_Projekt_Game.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; } 
        public string NGenre { get; set; }
        public Game? Game { get; set; } 
        public int GameId { get; set; } 
    }
}
