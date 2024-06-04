using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mediatek86.Models
{
    /// <summary>
    /// Classe représentant la table "responsable" dans la base de données.
    /// </summary>
    [Table("responsable")]
    public class Responsable
    {
        /// <summary>
        /// Clé primaire de la table Responsable. Correspond au login du responsable.
        /// </summary>
        [Key]
        public string? Login { get; set; }

        /// <summary>
        /// Mot de passe du responsable, stocké sous forme de hash SHA256.
        /// Attention MySql stocke les hashs sous forme d'une hexstring en minuscule
        /// </summary>
        public string? Pwd { get; set; }

        /// <summary>
        /// Vérifie si le mot de passe fourni correspond au mot de passe du responsable.
        /// </summary>
        /// <param name="password">Le mot de passe à vérifier.</param>
        /// <returns>Retourne true si le mot de passe est correct, false sinon.</returns>
        public bool VerifierMotDePasse(string password)
        {
            // Convertir le mot de passe en hash SHA256
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedPassword = Convert.ToHexString(sha256.ComputeHash(Encoding.UTF8.GetBytes(password))).ToLower();
                // Compare le mot de passe hashé localement et celui de la base
                return Pwd?.ToLower() == hashedPassword;
            }
        }
    }
}
