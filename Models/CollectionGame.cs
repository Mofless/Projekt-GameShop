using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ihor_Projekt_Game.Models
{
    public class CollectionGame
    {


        [Key]
        public int CollectionGameId { get; set; }



        [Column("Name Collection game")]
        [Required(ErrorMessage = "Proszę podać nazwe gry kolekcji!")]
        [MaxLength(80, ErrorMessage = "Wartość nazwy gry kolekcji musze być max 80 symbolów.")]
        [MinLength(0, ErrorMessage = "Wartość nazwy gry kolekcji musze być min 0 symbolów.")]
        public string NGameCollection { get; set; }






        [Column("Name Company Collection")]
        [Required(ErrorMessage = "Proszę podać nazwe firmy kolekcji!")]
        [MaxLength(80, ErrorMessage = "Wartość nazwy firmy kolekcji musze być max 80 symbolów.")]
        [MinLength(0, ErrorMessage = "Wartość nazwy firmy kolekcji musze być min 0 symbolów.")]
        public string NCompanyCollection { get; set; }



        [Column(" Developer year at the game collection")]
        [Required(ErrorMessage = "Proszę podać  rok zrobienia  gry kolekcji !")]
        [Range(0, 100000, ErrorMessage = "Proszę podać rok zrobienia  gry kolekcji w zakresię ( od 0 do 100 000).")]
        public double YearGCollection { get; set; }



        [Column("Prise game collection")]
        [Required(ErrorMessage = "Proszę podać cene gry kolekcji!")]
        [Range(0, 100000, ErrorMessage = "Proszę podać cene gry kolekcji w zakresię ( od 0 do 100 000).")]
        public double PriseGCollection { get; set; }

    }
}
