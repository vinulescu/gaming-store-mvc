using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamingStoreMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele categoriei este obligatoriu")]
        [Display(Name = "Categorie")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product>? Products { get; set; }
    }
}