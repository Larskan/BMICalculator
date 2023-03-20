
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace BMICalculator.Model
{
    public class BMICalculatorClass : INotifyPropertyChanged 
    {
        #region Private members

        private double height;
        private double weight;
        private double result;
        private ObservableCollection<double> listBMI = new ObservableCollection<double>();

        #endregion

        #region Constructor
        public BMICalculatorClass()
        {
        }
        #endregion

        #region Implemented by Interface
        
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Public properties

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                probertyIsChanged();
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                probertyIsChanged();
            }
        }

        public double Result
        {
            get 
            { 
                return result; 
            }
            set 
            {
                result = value;
                probertyIsChanged();
            }
        }

        private void probertyIsChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
        #endregion
    }
}
