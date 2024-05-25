
using lab_1_asp_net.Resources;
using System.ComponentModel.DataAnnotations;

namespace lab_1_asp_net.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name", ResourceType = typeof(SharedResources))]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Description", ResourceType = typeof(SharedResources))]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Price", ResourceType = typeof(SharedResources))]
        public decimal Price { get; set; }

    }
}
