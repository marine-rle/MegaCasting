using MegaCasting.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MegaCasting.View
{
    /// <summary>
    /// Logique d'interaction pour AddAnnounce.xaml
    /// </summary>
    public partial class AddAnnounce : Window
    {
        public AddAnnounce()
        {
            InitializeComponent(); // Initialise les composants de l'interface utilisateur 
            this.DataContext = new AddAnnounceViewModel(); // Initialise le contexte de données avec une instance du ViewModel associé
        }

        // Gère le clic sur le bouton "AddAnnounceButton"
        private void AddAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            ((AddAnnounceViewModel)this.DataContext).Add(); // Appelle la méthode Add du ViewModel pour ajouter une annonce
            this.Close(); // Ferme la fenêtre actuelle
        }
    }
}
