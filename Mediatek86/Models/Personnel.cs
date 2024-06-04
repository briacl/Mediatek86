using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediatek86.Models
{
    /// <summary>
    /// Classe représentant la table "personnel" dans la base de données.
    /// </summary>
    [Table("personnel")]
    public class Personnel
    {
        /// <summary>
        /// Clé primaire de la table Personnel.
        /// </summary>
        [Key]
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Nom du personnel.
        /// </summary>
        public string? Nom { get; set; }

        /// <summary>
        /// Prénom du personnel.
        /// </summary>
        public string? Prenom { get; set; }

        /// <summary>
        /// Numéro de téléphone du personnel.
        /// </summary>
        public string? Tel { get; set; }

        /// <summary>
        /// Adresse mail du personnel.
        /// </summary>
        public string? Mail { get; set; }

        /// <summary>
        /// Clé étrangère vers la table Service.
        /// </summary>
        [ForeignKey("Service")]
        public int IdService { get; set; }

        /// <summary>
        /// Propriété de navigation vers l'entité Service associée.
        /// </summary>
        public virtual Service? Service { get; set; }

        /// <summary>
        /// Collection des absences associées à ce personnel.
        /// </summary>
        public virtual ICollection<Absence>? Absences { get; set; }

        /// <summary>
        /// Calcule le nombre d'absences du personnel.
        /// </summary>
        [NotMapped]
        public int NombreAbsences
        {
            get { return Absences?.Count ?? 0; }
        }
    }
}
