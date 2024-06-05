using System;
using System.Windows;
using Mediatek86.Models;
using Mediatek86.Data;
namespace Mediatek86.Views
{
    /// <summary>
    /// Classe AddPersonnelWindow pour l'ajout d'un personnel.
    /// </summary>
    public partial class AddPersonnelWindow : Window
    {
        /// <summary>
        /// Constructeur de la fenêtre d'ajout d'un personnel.
        /// </summary>
        public AddPersonnelWindow()
        {
            InitializeComponent();
            using (var db = new MyDbContext())
            {
                ServiceComboBox.ItemsSource = db.Service?.ToList();
            }
        }

        /// <summary>
        /// Ajout d'un personnel après confirmation par l'utilisateur
        /// la fonction vérifie que tous les champs sont remplis
        /// <see cref="System.Data.Entity.DbContext.SaveChanges"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
            // On vérifie que tous les champs sont remplis
            if (NomTextBox.Text == "" || PrenomTextBox.Text == "" || TelTextBox.Text == "" || MailTextBox.Text == "" || ServiceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            Service? selectedService = ServiceComboBox.SelectedItem as Service;
            var personnel = new Personnel
            {
                Nom = NomTextBox.Text,
                Prenom = PrenomTextBox.Text,
                Tel = TelTextBox.Text,
                Mail = MailTextBox.Text,
                IdService = selectedService?.IdService ?? 0
                
            };

            using (var db = new MyDbContext())
            {
                db.Personnel?.Add(personnel);
                db.SaveChanges();
            }

            MessageBox.Show("Personnel ajouté avec succès !");
            Close();
        }
    }
}
