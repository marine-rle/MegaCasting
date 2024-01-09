using MegaCasting.Class;
using MegaCasting.ViewModel;
using MegaCasting.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCasting
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Constructeur de la classe MainWindow
        public MainWindow()
        {
            InitializeComponent();
            // Initialisation du contexte de données avec une nouvelle instance de MainWindowViewModel
            this.DataContext = new MainWindowViewModel();
        }

        // Opérations liées aux utilisateurs

        // Gestion du clic sur le bouton d'informations utilisateur
        private void InfosUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'informations utilisateur en fonction de l'ID de l'utilisateur sélectionné
            InfoUser window = new InfoUser((((Grid)((Button)sender).Parent).DataContext as User).Id);
            window.ShowDialog();
        }


        // Gestion du clic sur le bouton de mise à jour utilisateur
        private void UpdateUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre de mise à jour utilisateur en fonction de l'ID de l'utilisateur sélectionné
            UpdateUser window = new UpdateUser((((Grid)((Button)sender).Parent).DataContext as User).Id);
            window.ShowDialog();

            // Actualisation des données dans la vue après la mise à jour
            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        // Gestion du clic sur le bouton de suppression utilisateur
        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupération de l'utilisateur à supprimer
            User? user = ((MainWindowViewModel)this.DataContext).SelectedUser = (((Grid)((Button)sender).Parent).DataContext as User);

            // Suppression de l'utilisateur sélectionné
            ((MainWindowViewModel)this.DataContext).RemoveUser();
        }


        // Gestion du clic sur le bouton d'ajout utilisateur
        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'ajout utilisateur
            AddUser window = new AddUser();
            window.ShowDialog();

            // Actualisation des données dans la vue après l'ajout
            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        // Opérations liées aux partenaires

        // Gestion du clic sur le bouton d'ajout partenaire
        private void AddPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'ajout partenaire
            AddPartner window = new AddPartner();
            window.ShowDialog();

            // Actualisation des données dans la vue après l'ajout
            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        // Gestion du clic sur le bouton de suppression partenaire
        private void DeletePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupération du partenaire à supprimer
            Partner? partner = ((MainWindowViewModel)this.DataContext).SelectedPartner = (((Grid)((Button)sender).Parent).DataContext as Partner);

            // Suppression du partenaire sélectionné
            ((MainWindowViewModel)this.DataContext).RemovePartner();
        }


        // Gestion du clic sur le bouton d'informations partenaire
        private void InfosPartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'informations partenaire en fonction de l'ID du partenaire sélectionné
            InfoPartner window = new InfoPartner((((Grid)((Button)sender).Parent).DataContext as Partner).ID);
            window.ShowDialog();
        }


        // Gestion du clic sur le bouton de mise à jour partenaire
        private void UpdatePartnerButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre de mise à jour partenaire en fonction de l'ID du partenaire sélectionné
            UpdatePartner window = new UpdatePartner((((Grid)((Button)sender).Parent).DataContext as Partner).ID);
            window.ShowDialog();

            // Actualisation des données dans la vue après la mise à jour
            ((MainWindowViewModel)this.DataContext).Refresh();
        }



        // Opérations liées aux annonces

        // Gestion du clic sur le bouton d'ajout d'annonce
        private void AddAnnonceButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'ajout d'annonce
            AddAnnounce window = new AddAnnounce();
            window.ShowDialog();

            // Actualisation des données dans la vue après l'ajout
            ((MainWindowViewModel)this.DataContext).Refresh();
        }


        // Gestion du clic sur le bouton de suppression d'annonce
        private void DeleteAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            // Récupération de l'annonce à supprimer
            Announce? announce = ((MainWindowViewModel)this.DataContext).SelectedAnnounce = (((Grid)((Button)sender).Parent).DataContext as Announce);

            // Suppression de l'annonce sélectionnée
            ((MainWindowViewModel)this.DataContext).RemoveAnnounce();
        }


        // Gestion du clic sur le bouton d'informations d'annonce
        private void InfosAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre d'informations d'annonce en fonction de l'ID de l'annonce sélectionnée
            InfoAnnounce window = new InfoAnnounce((((Grid)((Button)sender).Parent).DataContext as Announce).ID);
            window.ShowDialog();
        }


        // Gestion du clic sur le bouton de mise à jour d'annonce
        private void UpdateAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            // Création et affichage d'une fenêtre de mise à jour d'annonce en fonction de l'ID de l'annonce sélectionnée
            UpdateAnnounce window = new UpdateAnnounce((((Grid)((Button)sender).Parent).DataContext as Announce).ID);
            window.ShowDialog();

            // Actualisation des données dans la vue après la mise à jour
            ((MainWindowViewModel)this.DataContext).Refresh();
        }
    }
}
