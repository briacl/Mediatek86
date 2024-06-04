using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediatek86.Models
{
    /// <summary>
    /// Classe Service pour la gestion des services des personnels.
    /// Cette classée est mapée sur la table Service de la base de données.
    /// </summary>
    [Table("service")]
    public class Service
    {
        /// <summary>
        /// Identifiant du service.
        /// </summary> 
        [Key]
        public int IdService { get; set; }

        /// <summary>
        /// Getters et Setters pour le nom du service.
        /// </summary>
        public string? Nom { get; set; }

        /// <summary>
        /// Liaison avec la table Personnel.
        /// </summary>
        public virtual ICollection<Personnel>? Personnels { get; set; }
    }
}
