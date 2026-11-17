using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamingStoreMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Numele produsului este obligatoriu")]
        [Display(Name = "Nume Produs")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Descriere")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Specificații")]
        public string Specifications { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preț (RON)")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Stoc")]
        public int Stock { get; set; }

        [Required]
        [Display(Name = "Furnizor")]
        public string Supplier { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Modalitate de livrare")]
        public string DeliveryMethod { get; set; } = string.Empty;

        [Display(Name = "Categorie")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}