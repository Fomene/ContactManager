using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; } // PK

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire.")]
        [Phone(ErrorMessage = "Format de téléphone invalide.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "L'adresse courriel est obligatoire.")]
        [EmailAddress(ErrorMessage = "Format de courriel invalide.")]
        public string Email { get; set; } = string.Empty;

        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }

        // Clé étrangère vers Category
        [Range(1, int.MaxValue, ErrorMessage = "Veuillez sélectionner une catégorie.")]
        public int CategoryId { get; set; }

        // Propriété de navigation
        public Category? Category { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}