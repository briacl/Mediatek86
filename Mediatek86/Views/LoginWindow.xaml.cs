using Mediatek86.Data;
using System.Windows;
using System.Windows.Controls;

namespace Mediatek86.Views
{
    public partial class LoginWindow : Window
    {
        /// <summary>
        /// Constructeur de la fenêtre de connexion.
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler pour le bouton de connexion.
        /// Vérifie si le login et le mot de passe saisis par l'utilisateur sont corrects.
        /// Si c'est le cas, ferme la fenêtre de connexion et ouvre la fenêtre principale.
        /// Sinon, affiche un message d'erreur et reste sur la fenêtre de connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupérez le login et le mot de passe saisis par l'utilisateur
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            // Créez une nouvelle instance de votre contexte de base de données
            using (var db = new MyDbContext())
            {
                // Recherchez le responsable avec le login saisi par l'utilisateur
                var responsable = db.Responsable?.SingleOrDefault(r => r.Login == login);

                // Si le responsable n'existe pas, affichez un message d'erreur
                if (responsable == null)
                {
                    MessageBox.Show("Login incorrect.");
                    return;
                }

                // Si le responsable existe, vérifiez le mot de passe
                if (!responsable.VerifierMotDePasse(password))
                {
                    // Si le mot de passe est incorrect, affichez un message d'erreur
                    MessageBox.Show("Mot de passe incorrect.");
                    return;
                }

                // Si le login et le mot de passe sont corrects, fermez la fenêtre de connexion
                this.DialogResult = true;
                this.Close();
            }
        }

    }
}
