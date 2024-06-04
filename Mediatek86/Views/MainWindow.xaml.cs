using System.Windows;

namespace Mediatek86.Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // Créez une nouvelle instance de LoginWindow
            LoginWindow loginWindow = new LoginWindow();

            // Affichez la fenêtre de connexion
            if (loginWindow.ShowDialog() == true)
            {
                // Si l'utilisateur s'est connecté avec succès, affichez la fenêtre principale
                InitializeComponent();
                ListePersonnels listePersonnels = new ListePersonnels();
                MainFrame.Navigate(listePersonnels);

            }
            else
            {
                // Si l'utilisateur a annulé la connexion, fermez l'application
                Application.Current.Shutdown();
            }

        }
    }
}
