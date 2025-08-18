using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class Cinemas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500)]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
