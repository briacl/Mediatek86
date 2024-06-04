using System;
using System.Data.Entity;
using System.Windows;
using Mediatek86.Models;
using Mediatek86.Data;

namespace Mediatek86.Views
{
    public partial class EditPersonnelWindow : Window
    {
        private Personnel personnel;

        /// <summary>
        /// Constructeur de la fenêtre de modification d'un personnel.
        /// </summary>
        /// <param name="personnel"></param>
        public EditPersonnelWindow(Personnel personnel)
        {
            InitializeComponent();
            List<Service>? services;
            // On récupère la liste des services pour les afficher dans la ComboBox
            using (var db = new MyDbContext())
            {
                services = db.Service?.ToList() as List<Service>;
                ServiceComboBox.ItemsSource = db.Service?.ToList();
            }

            this.personnel = personnel;

            NomTextBox.Text = personnel.Nom;
            PrenomTextBox.Text = personnel.Prenom;
            TelTextBox.Text = personnel.Tel;
            MailTextBox.Text = personnel.Mail;

            // On sélectionne le service du personnel dans la ComboBox
            // Trouvez l'instance correspondante de Service dans la liste des services
            Service? service = services?.FirstOrDefault(s => s.IdService == personnel.Service?.IdService);
            // Assignez cette instance à ServiceComboBox.SelectedItem
            ServiceComboBox.SelectedItem = service;
        }

        /// <summary>
        /// Modification d'un personnel après confirmation par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifierButton_Click(object sender, RoutedEventArgs e)
        {
            // On vérifie que tous les champs sont remplis
            if (NomTextBox.Text == "" || PrenomTextBox.Text == "" || TelTextBox.Text == "" || MailTextBox.Text == "" || ServiceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            // Il faut afficher une MessageBox pour confirmer la modification
            MessageBoxResult result = MessageBox.Show("Voulez-vous vraiment modifier ce personnel ?", "Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            personnel.Nom = NomTextBox.Text;
            personnel.Prenom = PrenomTextBox.Text;
            personnel.Tel = TelTextBox.Text;
            personnel.Mail = MailTextBox.Text;
            if (ServiceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un service.");
                return;
            }else
                {
                personnel.IdService = ((Service)ServiceComboBox.SelectedItem).IdService;
            }

            // On met à jour le personnel dans la base de données
            using (var db = new MyDbContext())
            {
                // On récupére le Service de la base de données
                // cela doit être le Service correspondant à l'IdService de personnel
                Service? service = db.Service?.Find(personnel.IdService);
                // Assignez ce Service à personnel.Service
                personnel.Service = service;
                db.Entry(personnel).State = EntityState.Modified;
                db.SaveChanges();
            }

            MessageBox.Show("Personnel modifié avec succès !");
            Close();
        }
    }
}
