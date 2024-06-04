using Mediatek86.data;
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
        /// <param name="e"
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
        /// <param name="e"
        private void btnSupprimerPersonnel_Click(object sender, RoutedEventArgs e)
        {
            Personnel? currentPersonnel = myDataGrid.SelectedItem as Personnel;
            if (currentPersonnel == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel à supprimer.");
                return;
            }

        }

        /// <summary>
        /// Handler pour le bouton de gestion des absences du personnel sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"
        private void btnGererAbsences_Click(object sender, RoutedEventArgs e)
        {
            Personnel? currentPersonnel = myDataGrid.SelectedItem as Personnel;
            if (currentPersonnel == null)
            {
                MessageBox.Show("Veuillez sélectionner un personnel pour gérer ses absences.");
                return;
            }

        }
    }
}
