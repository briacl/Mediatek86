using System.Data.Entity;
using System.Windows;
using Mediatek86.Data;
using Mediatek86.Models;

namespace Mediatek86.Views
{
    public partial class AddAbsenceWindow : Window
    {
        private Personnel personnel;

        /// <summary>
        /// Constructeur de la fenêtre d'ajout d'une absence.
        /// </summary>
        /// <param name="personnel">Le personnel concerné</param>
        public AddAbsenceWindow(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;

            // Remplir la combo avec les motifs de la base de données
            List<Motif>? services = GetMotifs();
            MotifComboBox.ItemsSource = services;

        }

        /// <summary>
        /// Handler pour le bouton d'ajout d'une absence.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            // On vérifie que tous les champs sont remplis
            if (DateDebutPicker.SelectedDate == null || DateFinPicker.SelectedDate == null || MotifComboBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            // On vérifie que les dates de début et de fin sont cohérentes
            if (DateDebutPicker.SelectedDate > DateFinPicker.SelectedDate)
            {
                MessageBox.Show("La date de début doit être antérieure à la date de fin.");
                return;
            }
            // Créer une nouvelle absence avec les données entrées
            Absence newAbsence = new Absence
            {
                IdPersonnel = personnel.IdPersonnel,
                DateDebut = DateDebutPicker.SelectedDate.Value,
                DateFin = DateFinPicker.SelectedDate.Value,
                IdMotif = ((Motif)MotifComboBox.SelectedItem).IdMotif
            };

            // Ajouter la nouvelle absence à la base de données
            AddAbsence(newAbsence);

            // Fermer la fenêtre
            this.Close();
        }

        /// <summary>
        /// Méthode pour récupérer la liste des motifs.
        /// </summary>
        /// <returns></returns>
        private List<Motif>? GetMotifs()
        {
            using (var db = new MyDbContext())
                {
                return db.Motif?.ToList();
                }
        }

        private void AddAbsence(Absence absence)
        {
            using (var db = new MyDbContext())
            {
                db.Absence?.Add(absence);
                db.SaveChanges();
            }

            MessageBox.Show("Absence ajoutée avec succès !");
        }
    }
}
