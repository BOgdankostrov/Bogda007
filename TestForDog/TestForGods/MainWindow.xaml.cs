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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestForGods
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            TestPage.Visibility = Visibility.Visible;
            Storyboard sb = this.FindResource("LowerOpacity") as Storyboard;
            Storyboard.SetTarget(sb, FirstPage);
            sb.Begin();
        }
    }
}
