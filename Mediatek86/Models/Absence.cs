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

        /// <summary>
        /// Vérifie si une absence pour un personnel donné chevauche une autre absence de ce même personnel.
        /// </summary>
        /// <param name="personnel">Le personnel concerné</param>
        /// <returns>Retourne true si l'absence chevauche une autre absence, false sinon.</returns>
        public bool Chevauche(Personnel personnel)
        {
            bool bChevauche = false;

            // On recherche dans les absences de ce personnel si il existe une absence qui chevauche l'absence passée en paramètre
            if (personnel == null)
            {
                return true;
            }
            else
            {
                List<Absence>? absences = personnel.Absences?.ToList();
                if (absences == null)
                {
                    return false;
                }

                absences.ForEach(_absence =>
                {
                    if (_absence.DateDebut >= DateDebut && _absence.DateDebut <= DateFin)
                    {
                        bChevauche = true;
                    }
                    if (_absence.DateFin >= DateDebut && _absence.DateFin <= DateFin)
                    {
                        bChevauche = true;
                    }
                    if (_absence.DateDebut <= DateDebut && _absence.DateFin >= DateFin)
                    {
                        bChevauche = true;
                    }
                });
            }
            return bChevauche;
        }
    }
}
