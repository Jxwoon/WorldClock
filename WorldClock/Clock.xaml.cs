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
using System.Windows.Threading;

namespace WorldClock
{
    /// <summary>
    /// Interaction logic for Clock.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
       
        public Clock()
        {
            InitializeComponent();
           
            StartClock();
            
        }
        private void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
            setClockZone();
        }

        private void tickevent(object sender, EventArgs e)
        {
            clockTime.Text = DateTime.Now.ToString();
        }

        private void setClockZone()
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;
            clockZone.Text = localZone.StandardName;
        }

        private void Delete_Clock(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }
    }
}
