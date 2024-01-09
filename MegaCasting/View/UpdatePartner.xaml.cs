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
    /// Logique d'interaction pour UpdatePartner.xaml
    /// </summary>
    public partial class UpdatePartner : Window
    {
        // Constructeur de la fenêtre, prenant l'identifiant du partenaire en paramètre
        public UpdatePartner(int identifierPartner)
        {
            // Initialisation des composants de la fenêtre
            InitializeComponent();
            this.DataContext = new UpdatePartnerViewModel(identifierPartner);
        }

        // Evénement appelé lorsqu'on clique sur le bouton de mise à jour
        private void UpdatePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Appel de la méthode Update du ViewModel pour effectuer la mise à jour
            ((UpdatePartnerViewModel)this.DataContext).Update();

            // Fermeture de la fenêtre après la mise à jour
            this.Close();
        }
    }
}
