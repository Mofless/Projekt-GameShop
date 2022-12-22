using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ihor_Projekt_Game.Models
{


        [Table("Game")]
        public class Game
        {
            [Key]
            public int Id { get; set; }



            [Column("Name game")]
            [Required(ErrorMessage = "Proszę podać nazwe gry!")]
            [MaxLength(80, ErrorMessage = "Wartość nazwy gry musze być max 80 symbolów.")]
            [MinLength(0, ErrorMessage = "Wartość nazwy gry musze być min 0 symbolów.")]
            public string NGame { get; set; }






            [Column("Name Company")]
            [Required(ErrorMessage = "Proszę podać nazwe firmy!")]
            //[StringLength(50)]
            [MaxLength(80, ErrorMessage = "Wartość nazwy firmy musze być max 80 symbolów.")]
            [MinLength(0, ErrorMessage = "Wartość nazwy firmy musze być min 0 symbolów.")]
            public string NCompany { get; set; }



            [Column("Prise game")]
            [Required(ErrorMessage = "Proszę podać cene gry!")]
            [Range(0, 100000, ErrorMessage = "Proszę podać cene gry w zakresię ( od 0 do 100 000).")]
            public double PriseG { get; set; }


        }
    

}
