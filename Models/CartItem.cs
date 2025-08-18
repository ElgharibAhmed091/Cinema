using System.ComponentModel.DataAnnotations;

namespace Cinema.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int Quantity { get; set; } = 1;

        public double Price { get; set; } // السعر وقت الإضافة للكارت

        public string UserId { get; set; } // علشان تميّز كارت كل يوزر
        public string Name { get; internal set; }
    }

}
