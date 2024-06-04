using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediatek86.Models
{
    /// <summary>
    /// Classe Absence pour la gestion des absences des personnels.
    /// Cette classée est mapée sur la table Absence de la base de données.
    /// </summary>
    [Table("absence")]
    public class Absence
    {
        /// <summary>
        /// Clé étrangère vers la table Personnel. 
        /// </summary>
        [Key, Column(Order = 0), ForeignKey("Personnel")]
        public int IdPersonnel { get; set; }

        /// <summary>
        /// Propriété de navigation vers l'entité Personnel associée.
        /// </summary>
        public virtual Personnel? Personnel { get; set; }

        /// <summary>
        /// Date de début de l'absence.
        /// </summary>
        [Key, Column(Order = 1)]
        public DateTime DateDebut { get; set; }

        /// <summary>
        /// Date de fin de l'absence.
        /// </summary>
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Clé étrangère vers la table Motif.
        /// </summary>
        [ForeignKey("Motif")]
        public int IdMotif { get; set; }

        /// <summary>
        /// Propriété de navigation vers l'entité Motif associée.
        /// </summary>
        public virtual Motif? Motif { get; set; }
    }

}
