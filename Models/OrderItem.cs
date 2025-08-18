namespace Cinema.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        //  public int movieId { get; set; }
        public int CinemaId { get; set; }   // لازم يكون موجود في جدول Cinemas
        public Cinemas Cinema { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
         
        public int MovieId { get; set; }

        // 👇 لازم تضيف دي عشان EF Core يعرف يربط MovieId بـ Movie
        public Movie Movie { get; set; }
    }
}
