using Mediatek86.Models;
using MySql.Data.EntityFramework;
using System.Data.Entity;
namespace Mediatek86.data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MyMediatek86DbContext")
        {
        }

        // Définit un DbSet pour la table Personnel. Cela permet d'accéder aux données de la table Personnel et de les manipuler.
        public DbSet<Personnel>? Personnel { get; set; }
        // Définit un DbSet pour la table Responsable. Cela permet d'accéder aux données de la table Responsable et de les manipuler.
        public DbSet<Absence>? Absence { get; set; }
        // Définit un DbSet pour la table Service. Cela permet d'accéder aux données de la table Service et de les manipuler.
        public DbSet<Service>? Service { get; set; }
        // Définit un DbSet pour la table Motif. Cela permet d'accéder aux données de la table Motif et de les manipuler.
        public DbSet<Motif>? Motif { get; set; }
        // Définit un DbSet pour la table Responsable. Cela permet d'accéder aux données de la table Responsable et de les manipuler.
        public DbSet<Responsable>? Responsable { get; set; }
    }
}
