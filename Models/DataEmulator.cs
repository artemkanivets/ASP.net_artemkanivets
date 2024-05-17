namespace lab_1_asp_net.Models
{
    public class DataEmulator
    {
        public static List<User> Users { get; set; } = new List<User>
        {
            new User { Id = 1, FullName = "Nico Collins", Email = "nicocollins@gmail.com", PhoneNumber = "3084806423", Address = "83666 Moen Stream" },
            new User { Id = 2, FullName = "Peter Bryan", Email = "peterbryan@gmail.com", PhoneNumber = "6684732053", Address = "36665 Swaniawski Coves Suite 990" }
        };
        public static List<Movie> Movies { get; set; } = new List<Movie>
        {
            new Movie { Id = 1, Name = "Shrek", Description = "Movie description", Price = 5.50m },
            new Movie { Id = 2, Name = "Dump and Dumber", Description = "Movie description", Price = 6.75m }
        };
        public static List<Order> Orders { get; set; } = new List<Order>
        {
            new Order { Id = 1, UserId = 1, MovieName = "Shrek", TotalPrice = 5.50m },
            new Order { Id = 2, UserId = 2, MovieName = "Dump and Dumber", TotalPrice = 6.75m }
        };


    }
}
