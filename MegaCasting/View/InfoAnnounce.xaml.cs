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
    /// Logique d'interaction pour InfoAnnounce.xaml
    /// </summary>
    public partial class InfoAnnounce : Window
    {
        public InfoAnnounce(int identifierAnnounce)
        {
            InitializeComponent();
            this.DataContext = new InfoAnnounceViewModel(identifierAnnounce);
        }
    }
}
