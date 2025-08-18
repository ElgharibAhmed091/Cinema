using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cinema.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Range(1, 1000)]
        public double Price { get; set; }


        [Required]
        [Column("ImageURL")]   // هنا ربطنا الخاصية بالعمود اللي في الداتابيز
        public string ImageURL { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public string MovieCategory { get; set; }

        // Relations
        public List<Actor_Movie> Actors_Movies { get; set; }

        public int CinemaId { get; set; }
        public Cinemas Cinema { get; set; }

        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}
