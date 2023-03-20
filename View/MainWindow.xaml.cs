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

namespace BMICalculator.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**
         * Sets the Content to InputWindow 
         */
        private void ShiftToCalculate(object sender, RoutedEventArgs e)
        {
            InputWindow inputWindow = new InputWindow();
            ContentController.Content = inputWindow;
        }

        /**
        * Sets the Content to InputWindow 
        */
        private void ShiftToHistory(object sender, RoutedEventArgs e)
        {
            HistoryWindow historyWindow = new HistoryWindow();
            ContentController.Content = historyWindow;
        }
    }
}
