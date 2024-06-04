using Mediatek86.Models;
using MySql.Data.EntityFramework;
using System.Data.Entity;
namespace Mediatek86.Data
{
    /// <summary>
    /// Classe Entity Framework pour la base de données Mediatek86.
    /// </summary>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyDbContext : DbContext
    {
        /// <summary>
        /// Constructeur de la classe MyDbContext.
        /// </summary>
        public MyDbContext() : base("name=MyMediatek86DbContext")
        {
        }

        /// <summary>
        /// Définit un DbSet pour la table Personnel. Cela permet d'accéder aux données de la table Personnel et de les manipuler.
        /// </summary>
        public DbSet<Personnel>? Personnel { get; set; }

        /// <summary>
        /// Définit un DbSet pour la table Responsable. Cela permet d'accéder aux données de la table Responsable et de les manipuler.
        /// </summary>
        public DbSet<Absence>? Absence { get; set; }

        /// <summary>
        /// Définit un DbSet pour la table Service. Cela permet d'accéder aux données de la table Service et de les manipuler.
        /// </summary>
        public DbSet<Service>? Service { get; set; }

        /// <summary>
        /// Définit un DbSet pour la table Motif. Cela permet d'accéder aux données de la table Motif et de les manipuler.
        /// </summary>
        public DbSet<Motif>? Motif { get; set; }
        /// <summary>
        /// Définit un DbSet pour la table Responsable. Cela permet d'accéder aux données de la table Responsable et de les manipuler.
        /// </summary>
        public DbSet<Responsable>? Responsable { get; set; }
    }
}
