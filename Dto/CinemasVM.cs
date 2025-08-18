using System.ComponentModel.DataAnnotations;

namespace Cinema.Dto
{
    public class CinemasVM
    {
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500)]
        public string Description { get; set; }

    }
}
