using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Personal_Organiser_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        string dateFormat = "dddd, dd MMMM yyyy";


        public MainWindow()
        {

            InitializeComponent();
            InitialiseClock();


        }


        //Clock init
        public void InitialiseClock()
        {
            DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }


  

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {

            dispatchLbl.Content = DateTime.Now.ToString(dateFormat);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewFileButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }


        private void LabelClicked(object sender, MouseButtonEventArgs e)
        {
            TestLabel.Content = "it worked!";
            TextWriterBox.Text = "Insert text to save...";
        }

        private void SaveLabelClicked(object sender, MouseButtonEventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text file (*.txt)|*.txt";

            if (save.ShowDialog() == true)
            {
                File.WriteAllText(save.FileName, TextWriterBox.Text);




            }

        }
        private void OpenLabelClicked(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == true)
            {
                TextWriterBox.Text = File.ReadAllText(open.FileName);
            }
        }


    }
}
