using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LINQ.Model
{
    class TPDBContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<AssocAdresseClient> AssocAdresseClients { get; set; }
        public DbSet<LigneCommande> LignesCommandes { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WINDEV2106EVAL\SQLEXPRESS;Initial Catalog=TPBD;integrated security=true");
        }
    }
}
