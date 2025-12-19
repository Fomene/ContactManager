
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Veuillez entrer un nom de catégorie.")]
        public string Name { get; set; } = string.Empty;
    }
}