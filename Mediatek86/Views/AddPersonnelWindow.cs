using System;
using System.Windows;
using Mediatek86.Models;
using Mediatek86.data;
namespace Mediatek86.Views
{
    public partial class AddPersonnelWindow : Window
    {
        public AddPersonnelWindow()
        {
            InitializeComponent();
            using (var db = new MyDbContext())
            {
                ServiceComboBox.ItemsSource = db.Service?.ToList();
            }
        }

        private void AjouterButton_Click(object sender, RoutedEventArgs e)
        {
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
