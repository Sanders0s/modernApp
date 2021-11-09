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
    public partial class HomeView : UserControl
    {
        public ICommand LoadCommand
        {
            get { return (ICommand)GetValue(LoadCommandProperty); }
            set { SetValue(LoadCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for LoadCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LoadCommandProperty =
            DependencyProperty.Register("LoadCommand", typeof(ICommand), typeof(HomeView), new PropertyMetadata(null));

        public HomeView()
        {
            InitializeComponent();
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            LoadCommand?.Execute(null);
            if (LoadCommand != null)
            {
                LoadCommand.Execute(null);
            }
        }
    }
}
