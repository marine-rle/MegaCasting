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
    /// Logique d'interaction pour AddPartner.xaml
    /// </summary>
    public partial class AddPartner : Window
    {
        // Constructeur de la classe AddPartner
        public AddPartner()
        {
            // Initialisation des composants de l'interface utilisateur
            InitializeComponent();

            this.DataContext = new AddPartnerViewModel();
        }

        // Gestionnaire d'événement appelé lorsqu'on clique sur le bouton "AddPartnerButton"
        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Appel de la méthode Add() du ViewModel associé pour effectuer l'ajout
            ((AddPartnerViewModel)this.DataContext).Add();

            // Fermeture de la fenêtre actuelle
            this.Close();
        }
    }
}
