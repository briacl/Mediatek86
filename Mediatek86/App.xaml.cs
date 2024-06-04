using Mediatek86.Data;
using Mediatek86.Views;
using System.Windows;

namespace Mediatek86
{
    /// <summary>
    /// Classe principale de l'application.<br/>
    /// Pour plus d'informations sur les classes de l'application, veuillez consulter les espace de noms suivants :<br/>
    /// <see cref="Mediatek86"/><br/>
    /// <see cref="Mediatek86.Data"/><br/>
    /// <see cref="Mediatek86.Models"/><br/>
    /// <see cref="Mediatek86.Views"/><br/>
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Méthode appelée au démarrage de l'application
        /// Avant d'afficher la fenêtre principale
        /// on vérifie que l'application peut se connecter à la base de données
        /// Si la connexion échoue, on affiche un message d'erreur et on ferme l'application
        /// Ensuite on affiche la fenêtre de connexion
        /// Si l'utilisateur se connecte avec succès, on affiche la fenêtre principale
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using (var db = new MyDbContext())
            {
                try
                {
                    // Tentez de se connecter à la base de données
                    db.Database.Connection.Open();

                    // Si la connexion est réussie, fermez-la immédiatement
                    db.Database.Connection.Close();
                }
                catch (Exception ex)
                {
                    // Si une exception est levée, affichez une alerte à l'utilisateur
                    MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);

                    // Fermez l'application
                    Application.Current.Shutdown();
                }
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }
    }

}
