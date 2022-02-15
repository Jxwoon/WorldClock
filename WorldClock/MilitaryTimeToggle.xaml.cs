using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for MilitaryTimeToggle.xaml
    /// </summary>
    public partial class MilitaryTimeToggle : UserControl
    {
        private Thickness LeftSide = new Thickness(70, 0, 0, 0);
        Thickness RightSide = new Thickness(86, 0, 0, 0);
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(130, 190, 125));
        public bool UseMilitaryTime
        {
            get
            {
                return CheckboxTime.IsChecked ?? false;
            }
        }

        public bool Foo { get; set; } = false;

        public MilitaryTimeToggle()
        {
            InitializeComponent();
            //Back.Fill = Off;
            //UseMilitaryTime = false;
            //Dot.Margin = LeftSide;
        }

    //    public bool getToogle()
    //    {
    //        return UseMilitaryTime;
    //    }

    //    private void Dot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    //    {
    //        if (!UseMilitaryTime)
    //        {
    //            Back.Fill = On;
    //            UseMilitaryTime = true;
    //            Dot.Margin = RightSide;

    //        }
    //        else
    //        {

    //            Back.Fill = Off;
    //            UseMilitaryTime = false;
    //            Dot.Margin = LeftSide;

    //        }
    //    }

    //    private void Back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    //    {
    //        if (!UseMilitaryTime)
    //        {
    //            Back.Fill = On;
    //            UseMilitaryTime = true;
    //            Dot.Margin = RightSide;
    //        }
    //        else
    //        {
    //            Back.Fill = Off;
    //            UseMilitaryTime = false;
    //            Dot.Margin = LeftSide;
    //        }
    //    }
    }
}
