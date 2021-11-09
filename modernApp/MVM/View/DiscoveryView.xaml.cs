using modernApp.MVM.ViewModels;
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

namespace modernApp.MVM.View
{
    /// <summary>
    /// Interaction logic for DiscoveryView.xaml
    /// </summary>
    public partial class DiscoveryView : UserControl
    {
        public DiscoveryView()
        {
            InitializeComponent();
        }

        public int Quantity
        {
            get { return (int)GetValue(quantityDependencyProperty); }
            set { SetValue(quantityDependencyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.
        // This enables animation, styling, binding, etc...
        public static readonly DependencyProperty quantityDependencyProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(DiscoveryView),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
    }
}
