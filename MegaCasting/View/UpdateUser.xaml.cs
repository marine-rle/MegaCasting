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
    /// Logique d'interaction pour UpdateUser.xaml
    /// </summary>
    public partial class UpdateUser : Window
    {
        // Constructeur de la classe UpdateUser prenant en paramètre l'identifiant de l'utilisateur
        public UpdateUser(int identifierUser)
        {
            // Initialisation des composants de la fenêtre
            InitializeComponent();
            this.DataContext = new UpdateUserViewModel(identifierUser);
        }

        // Evénement du clic sur le bouton "UpdateUserButton"
        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Appel de la méthode "Update" du ViewModel associé à la fenêtre
            ((UpdateUserViewModel)this.DataContext).Update();

            // Fermeture de la fenêtre
            this.Close();
        }
    }
}
