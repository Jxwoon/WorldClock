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
        private TimeZone localZone;
        private TimeZoneInfo selectedTimeZone;

        public Clock()
        {
            InitializeComponent();
            StartClock();
        }

        public Clock(TimeZoneInfo selectedTimeZone)
        {
            InitializeComponent();
            clockZone.Text = selectedTimeZone.StandardName;
            this.selectedTimeZone = selectedTimeZone;
            StartAddedClock(selectedTimeZone);

        }

        private void StartAddedClock(TimeZoneInfo sekectedTimeZone)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickeventNewClock;
            timer.Start();
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
            setTimeImage(DateTime.Now);


        }


        private void setClockZone()
        {
            this.localZone = TimeZone.CurrentTimeZone;
            clockZone.Text = localZone.StandardName;
        }

        // this clock removes itself in the wrap panel
        private void Delete_Clock(object sender, RoutedEventArgs e)
        {
            ((Panel)this.Parent).Children.Remove(this);
        }

        // sets the timer of the new clock added and calculate the relative time to the user's current time zone
        private void tickeventNewClock(object sender, EventArgs e)
        {
            TimeZoneInfo selectedTimeZone = GetSelectedTimeZoneInfo();
            DateTime dt = TimeZoneInfo.ConvertTime(DateTime.Now, selectedTimeZone);
            clockTime.Text = dt.ToString();
            setTimeImage(dt);

        }

        // Gets the new selected timezone information
        private TimeZoneInfo GetSelectedTimeZoneInfo()
        {
            return this.selectedTimeZone;
        }

        private void setTimeImage(DateTime dt)
        {
            TimeSpan time = dt.TimeOfDay;
            if(time > new TimeSpan (5, 0 ,0) && time < new TimeSpan(12, 0, 0))
            {
                timeImage.Source = new BitmapImage(new Uri("pack://application:,,,/WorldClock;component/Resources/morning.png"));
            } else if (time > new TimeSpan(12, 0, 0) && time < new TimeSpan(17, 0, 0))
            {
                timeImage.Source = new BitmapImage(new Uri("pack://application:,,,/WorldClock;component/Resources/afternoon.png"));
            } else if (time > new TimeSpan(17, 0, 0) && time < new TimeSpan(21, 0, 0))
            {
                timeImage.Source = new BitmapImage(new Uri("pack://application:,,,/WorldClock;component/Resources/evening.png"));
            } else
            {
                timeImage.Source = new BitmapImage(new Uri("pack://application:,,,/WorldClock;component/Resources/night.png"));
            }
        }

    }
}
