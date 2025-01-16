using BillEase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BillEase.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Ajouter les DbSet pour chaque modèle
        public DbSet<Client> Clients { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Marchandise> Marchandises { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Inventaire> Inventaires { get; set; }
        public DbSet<AlerteStock> AlertesStock { get; set; }
    }
}
