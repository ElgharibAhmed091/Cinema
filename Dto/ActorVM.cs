using System.ComponentModel.DataAnnotations;

namespace Cinema.Dto
{
    public class ActorVM
    {
        [Required]
        public string ProfilePictureURL { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required]
        public string Bio { get; set; }
    }
}
