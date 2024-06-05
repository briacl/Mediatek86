using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Mediatek86.Data;
using Mediatek86.Models;

namespace Mediatek86.Views
{
    /// <summary>
    /// Classe ListeAbsences pour la gestion des absences des personnels.
    /// </summary>
    public partial class ListeAbsences : Page
    {
        private Personnel personnel;

        /// <summary>
        /// Constructeur de la page ListeAbsences.
        /// </summary>
        /// <param name="personnel">le personnel en cours de traitement</param>
        public ListeAbsences(Personnel personnel)
        {
            InitializeComponent();

            this.personnel = personnel;
            populateListAbsence(personnel);
        }

        /// <summary>
        /// Handler pour le bouton d'ajout d'une absence.
        /// Ouvre la fenêtre d'ajout d'une absence.
        /// Met à jour la liste des absences après ajout.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterAbsence_Click(object sender, RoutedEventArgs e)
        {
            AddAbsenceWindow addAbsenceWindow = new AddAbsenceWindow(personnel);
            addAbsenceWindow.ShowDialog();
            populateListAbsence(personnel);
        }

        /// <summary>
        /// Handler pour le bouton de modification d'une absence.
        /// Ouvre la fenêtre de modification d'une absence.
        /// Met à jour la liste des absences après modification.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierAbsence_Click(object sender, RoutedEventArgs e)
        {
            if (myDataGrid.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une absence à modifier.");
                return;
            }
            EditAbsenceWindow editAbsenceWindow = new EditAbsenceWindow((Absence)myDataGrid.SelectedItem);
            editAbsenceWindow.ShowDialog();
            populateListAbsence(personnel);
        }

        /// <summary>
        /// Handler pour le bouton de suppression d'une absence.
        /// Demande confirmation à l'utilisateur avant de supprimer l'absence.
        /// Met à jour la liste des absences après suppression.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbsence_Click(object sender, RoutedEventArgs e)
        {
            // On demande confirmation à l'utilisateur
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                using (var db = new MyDbContext())
                    {
                    Absence? selectedAbsence = myDataGrid.SelectedItem as Absence;
                    
                    if (selectedAbsence != null)
                    {
                        // On récupère l'absence sélectionnée
                        Absence? absenceToDelete = db.Absence?.Find([selectedAbsence?.IdPersonnel, selectedAbsence?.DateDebut]);
                        // On supprime l'absence de la base de données si elle existe
                        if (absenceToDelete != null)
                        {
                            db.Absence?.Remove(absenceToDelete);
                            db.SaveChanges();
                            // On rafraîchit la liste des absences
                            populateListAbsence(personnel);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handler pour le bouton de fermeture de la page de gestion des absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, RoutedEventArgs e)
        {
            // Changez la navigation pour mettre la page ListePersonnel
            NavigationService.Navigate(new ListePersonnels());
        }

        /// <summary>
        /// Alimente la liste des absences pour un personnel donné.
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns></returns>
        private void  populateListAbsence(Personnel personnel)
        {
            using (var db = new MyDbContext())
            {
                var absences = db.Absence?.Include("Motif").Where(a => a.IdPersonnel == personnel.IdPersonnel).ToList(); 
                myDataGrid.ItemsSource = absences;
            }
        }
    }
}
