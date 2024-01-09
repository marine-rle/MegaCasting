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
            InitializeComponent();
            this.DataContext = new AddAnnounceViewModel();
        }

        private void AddAnnounceButton_Click(object sender, RoutedEventArgs e)
        {
            ((AddAnnounceViewModel)this.DataContext).Add();
            this.Close();
        }
    }
}
