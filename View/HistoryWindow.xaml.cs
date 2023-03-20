
using System.Windows.Controls;


namespace BMICalculator.View
{
    /// <summary>
    /// Interaction logic for HistoryWindow.xaml
    /// </summary>
    public partial class HistoryWindow : UserControl
    {
        public HistoryWindow()
        {
            InitializeComponent();
            DataContext = InputWindow.inputViewModel; // Fetched from static
        }
    }
}
