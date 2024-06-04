using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mediatek86.Models
{
    /// <summary>
    /// Classe représentant la table "motif" dans la base de données.
    /// </summary> 
    [Table("motif")]
    public class Motif
    {
        /// <summary>
        /// Clé primaire de la table Motif.
        /// </summary>
        [Key]
        public int IdMotif { get; set; }

        /// <summary>
        /// Libellé du motif.
        /// </summary>
        public string? Libelle { get; set; }

        /// <summary>
        /// Collection des absences associées à ce motif.
        /// </summary>
        public virtual ICollection<Absence>? Absences { get; set; }
    }
}
