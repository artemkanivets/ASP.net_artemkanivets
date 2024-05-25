using Microsoft.AspNetCore.StaticFiles.Infrastructure;
using System.ComponentModel.DataAnnotations;
using lab_1_asp_net.Models;
using lab_1_asp_net.Resources;

namespace lab_1_asp_net.Models
{
    public class Order
    {



        public int Id { get; set; }
        [Display(Name = "UserId", ResourceType = typeof(CreateOrder))]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "MovieName", ResourceType = typeof(CreateOrder))]
        public string MovieName { get; set; }
        [Required]
        [Display(Name = "TotalPrice", ResourceType = typeof(CreateOrder))]
        public decimal TotalPrice { get; set; }


    }
}
