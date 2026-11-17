using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamingStoreMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Categorie")]
        public string Name { get; set; }

        [Display(Name = "Imagine Categorie")]
        public string? ImageUrl { get; set; } // Calea relativă salvată în baza de date (ex: /images/categories/nume.jpg)

        [NotMapped]
        [Display(Name = "Încarcă Imagine")]
        public IFormFile? ImageFile { get; set; } // Fișierul selectat din calculator
    }
}