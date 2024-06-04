using System.Windows;
using System.Windows.Navigation;

namespace Mediatek86.Views
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructeur de la fenêtre principale.
        /// Le constructeur n'initialise pas directement la fenêtre principale, mais commence par afficher la fenêtre de connexion.
        /// </summary>
        public MainWindow()
        {
            // Créez une nouvelle instance de LoginWindow
            LoginWindow loginWindow = new LoginWindow();

            // Cache les boutons de navigation
            NavigationWindow? navWindow = Window.GetWindow(this) as NavigationWindow;
            if (navWindow != null)
            {
                navWindow.ShowsNavigationUI = false;
            }
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
