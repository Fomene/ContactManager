using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models; // Assurez-vous d'avoir cette ligne pour reconnaître Contact et Category

namespace ContactManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Ajoutez les deux lignes ici :
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        // C'est aussi ici que nous ajouterons les données de test (Seeding) dans l'étape suivante
    }
}