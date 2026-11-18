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

        // Opțional
        [Display(Name = "Descriere")]
        public string? Description { get; set; }

        // Opțional (fără [Required])
        [Display(Name = "Specificații")]
        public string? Specifications { get; set; }

        // Opțional
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preț (RON)")]
        public decimal? Price { get; set; }

        [Required]
        [Display(Name = "Stoc")]
        public int Stock { get; set; }

        // Opțional
        [Display(Name = "Furnizor")]
        public string? Supplier { get; set; }

        // Opțional
        [Display(Name = "Modalitate de livrare")]
        public string? DeliveryMethod { get; set; }

        [Display(Name = "Categorie")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}