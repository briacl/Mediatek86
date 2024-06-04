using Mediatek86.Data;
using Mediatek86.Models;
using System.Windows;
using System.Windows.Controls;

namespace Mediatek86.Views
{
    /// <summary>
    /// Logique d'interaction pour ListePersonnels.xaml
    /// </summary>
    public partial class ListePersonnels : Page
    {
        /// <summary>
        /// Constructeur de la page ListePersonnels.
        /// </summary>
        public ListePersonnels()
        {
            InitializeComponent();
            poulateListePersonnels();
        }

        private void poulateListePersonnels()
        {
            using (var db = new MyDbContext())
            {
                var personnels = db.Personnel?.Include("Service").Include("Absences").ToList();
                myDataGrid.ItemsSource = personnels;
            }
        }

        /// <summary>
        /// Handler pour le bouton d'ajout de personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterPersonnel_Click(object sender, RoutedEventArgs e)
        {
            AddPersonnelWindow addPersonnelWindow = new AddPersonnelWindow();
            addPersonnelWindow.ShowDialog();
            poulateListePersonnels();

        }

        /// <summary>
        /// Handler pour le bouton de modification du personnel sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPersonnel_Click(object sender, RoutedEventArgs e)
        {
            Personnel? currentPersonnel = myDataGrid.SelectedItem as Personnel;
            if (currentPersonnel == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à modifier.");
                return;
            }
            EditPersonnelWindow editPersonnelWindow = new EditPersonnelWindow(currentPersonnel);
            editPersonnelWindow.ShowDialog();
            poulateListePersonnels();
        }

        /// <summary>
        /// Handler pour le bouton de suppression du personnel sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, RoutedEventArgs e)
        {
            Personnel? currentPersonnel = myDataGrid.SelectedItem as Personnel;
            if (currentPersonnel == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.");
                return;
            }
            // Demande de confirmation
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce personnel ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes) {
                using (var db = new MyDbContext())
                {
                    // On obtient une référence à l'objet à partir de la base de données
                    Personnel? personnelToDelete = db.Personnel?.Find(currentPersonnel?.IdPersonnel);
                    if (personnelToDelete == null)
                    {
                        MessageBox.Show("Personnel non trouvé !");
                        return;
                    }

                    // On marque l'objet pour la suppression
                    db.Personnel?.Remove(personnelToDelete);

                    // Effectuez la suppression
                    db.SaveChanges();
                }
                poulateListePersonnels();
            }

        }

        /// <summary>
        /// Handler pour le bouton de gestion des absences du personnel sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGererAbsences_Click(object sender, RoutedEventArgs e)
        {
            Personnel? currentPersonnel = myDataGrid.SelectedItem as Personnel;
            if (currentPersonnel == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel pour gérer ses absences.");
                return;
            }
            ListeAbsences listeAbsences = new ListeAbsences(currentPersonnel);
            NavigationService.Navigate(listeAbsences);

        }
    }
}
