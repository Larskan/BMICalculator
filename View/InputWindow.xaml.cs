using BMICalculator.Model;
using BMICalculator.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace BMICalculator.View
{
    /// <summary>
    /// Interaction logic for InputPage.xaml
    /// </summary>
    public partial class InputWindow : ContentControl
    {
        public static InputViewModel inputViewModel = new InputViewModel(); // Static enables usage by HistoryWindow
        public InputWindow()
        {
            InitializeComponent();
            DataContext = inputViewModel;
        }
    }
}
