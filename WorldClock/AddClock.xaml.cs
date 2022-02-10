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

namespace WorldClock
{
    /// <summary>
    /// Interaction logic for AddClock.xaml
    /// </summary>
    public partial class AddClock : UserControl
    {
        public AddClock()
        {
            InitializeComponent();
        }

        private void AddTime(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
              string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
              "MainWindow");

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button.Content = "Foo";
            //this.stackPanel1.Children.Add(button);
            MessageBox.Show(
              string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
              "MainWindow");
        }
    }
}
