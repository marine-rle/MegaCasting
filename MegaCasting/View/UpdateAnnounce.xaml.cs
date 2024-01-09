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
    /// Logique d'interaction pour UpdateAnnounce.xaml
    /// </summary>
    public partial class UpdateAnnounce : Window
    {
        // Constructeur de la classe UpdateAnnounce prenant en paramètre l'identifiant de l'annonce à mettre à jour
        public UpdateAnnounce(int identifierAnnounce)
        {
            // Initialisation des composants de l'interface utilisateur
            InitializeComponent();
            this.DataContext = new UpdateAnnounceViewModel(identifierAnnounce);
        }

        // Evénement appelé lors du clic sur le bouton de mise à jour d'une annonce
        private void UpdateAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            // Appel de la méthode Update de l'objet UpdateAnnounceViewModel
            ((UpdateAnnounceViewModel)this.DataContext).Update();

            // Fermeture de la fenêtre de mise à jour d'annonce
            this.Close();
        }
    }
}
