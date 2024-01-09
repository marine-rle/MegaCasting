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
        public UpdateAnnounce(int identifierAnnounce)
        {
            InitializeComponent();
            this.DataContext = new UpdateAnnounceViewModel(identifierAnnounce);
        }

        private void UpdateAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            ((UpdateAnnounceViewModel)this.DataContext).Update();
            this.Close();
        }
    }
}
