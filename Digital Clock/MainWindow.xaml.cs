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
using System.Timers;

namespace Digital_Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int i = 0;
        public MainWindow()
        {
            InitializeComponent();
             var timer =new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += onTime; 
            timer.Start();

        }
        private void timer_Main()
        {
            time_1.Text = DateTime.Now.ToString("HH:mm");
            time_2.Text = DateTime.Now.ToString("ss");
            date.Text = DateTime.Now.ToString("MMM dd yyyy");
            day.Text = DateTime.Now.ToString("dddd");
             
        }
        private void onTime(object sender,ElapsedEventArgs e)
        {
            i++;
            Console.WriteLine();
            lbl.Dispatcher.Invoke(() =>
            {
                timer_Main();
            });   
        }

      
    }
}
