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
    /// Logique d'interaction pour AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        // Constructeur de la classe AddUser
        public AddUser()
        {
            // Initialisation des composants de l'interface utilisateur
            InitializeComponent();

            this.DataContext = new AddUserViewModel();
        }

        // Gestionnaire d'événement appelé lorsqu'on clique sur le bouton "AddUserButton"
        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Appel de la méthode "Add" du ViewModel associé pour ajouter un utilisateur
            ((AddUserViewModel)this.DataContext).Add();

            // Fermeture de la fenêtre actuelle
            this.Close();
        }
    }
}