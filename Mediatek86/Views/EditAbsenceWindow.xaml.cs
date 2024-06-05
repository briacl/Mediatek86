using System.Data.Entity;
using System.Windows;
using Mediatek86.Data;
using Mediatek86.Models;

namespace Mediatek86.Views
{
    public partial class EditAbsenceWindow : Window
    {
        private Absence absence;

        /// <summary>
        /// Constructeur de la fenêtre d'édition d'une absence.
        /// </summary>
        /// <param name="absence">L'absence à modifier</param>
        public EditAbsenceWindow(Absence absence)
        {
            InitializeComponent();
            this.absence = absence;

            // Remplir les champs avec les données de l'absence
            DateDebutPicker.SelectedDate = absence.DateDebut;
            DateFinPicker.SelectedDate = absence.DateFin;
            List<Motif>? services = GetMotifs();
            MotifComboBox.ItemsSource = services;

            // On positionne la combobox sur le motif de l'absence
            Motif? motif = services?.FirstOrDefault(s => s.IdMotif == absence.Motif?.IdMotif);
            MotifComboBox.SelectedItem = motif;
        }

        /// <summary>
        /// Handler pour le bouton de modification d'une absence.
        /// la fonction vériie que les dates de début et de fin sont cohérentes
        /// avant de mettre à jour l'absence dans la base de données.
        /// la fonction demande confirmation à l'utilisateur avant de modifier l'absence.
        /// la fonction affiche un message de confirmation avant de fermer la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierButton_Click(object sender, RoutedEventArgs e)
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

            // On vérifie que l'absence ne chevauche pas une autre absence
            Absence tempAbsence = new Absence
            {
                DateDebut = DateDebutPicker.SelectedDate.Value,
                DateFin = DateFinPicker.SelectedDate.Value,
                IdMotif = ((Motif)MotifComboBox.SelectedItem).IdMotif,
                IdPersonnel = absence.IdPersonnel
            };
            if (tempAbsence.Chevauche(absence.Personnel))
            {
                MessageBox.Show("L'absence chevauche une autre absence.");
                return;
            }
            if (absence.DateDebut != DateDebutPicker.SelectedDate.Value)
            {
                // TODO: La date de début ne peut pas (encore) être modifiée
                MessageBox.Show("La date de début ne peut pas être modifiée. Veuillez supprimer cette absence et créer une nouvelle.");
                return;
            }

            // Mettre à jour l'absence avec les nouvelles données
            // absence.DateDebut = DateDebutPicker.SelectedDate.Value;
            absence.DateFin = DateFinPicker.SelectedDate.Value;
            absence.Motif = (Motif)MotifComboBox.SelectedItem;

            // On demande confirmation à l'utilisateur
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment modifier cette absence ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            // Mettre à jour l'absence dans la base de données
            UpdateAbsence(absence);

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

        /// <summary>
        /// Méthode pour mettre à jour une absence dans la base de données.
        /// <see cref="DbContext.SaveChanges"/>
        /// </summary>
        /// <param name="absence">L'absence à mettre à jour</param>
        private void UpdateAbsence(Absence absence)
        {

            // On met à jour l'absence' dans la base de données
            using (var db = new MyDbContext())
            {
                // On récupére le Motif de la base de données
                // cela doit être le Motif correspondant à l'IdMotif de absence
                absence.IdMotif = ((Motif)MotifComboBox.SelectedItem).IdMotif;
                Motif? motif = db.Motif?.Find(absence.IdMotif);
                // Assignez ce Motif à absence.Motif
                absence.Motif = motif;
                db.Entry(absence).State = EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show("Absence modifiée avec succès !");
            Close();
        }
    }
}
