using BMICalculator.Model;
using BMICalculator.Tools;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Diagnostics;

namespace BMICalculator.ViewModel
{
    public class InputViewModel : Bindable
    {
        #region Private members

        private BMICalculatorClass _bmiCalculator;
        private ObservableCollection<double> _ListOfResults;

        #endregion

        #region Constructor
        public InputViewModel()
        {
            _ListOfResults = new ObservableCollection<double>();
            bmiCalculator = new BMICalculatorClass();

            CalculateCommand = new Command(Calculate);
        }

        #endregion

        #region Public Properties

        public BMICalculatorClass bmiCalculator
        {
            get 
            { 
                return _bmiCalculator; 
            }
            set 
            {
                _bmiCalculator = value; propertyIsChanged(); 
            }
        }

        public double Height // Fetch Height property found in BMICalculatorClass by bmiCalculator Instance
        {
            get { return _bmiCalculator.Height; }
            set { _bmiCalculator.Height = value; propertyIsChanged(); }
        }

        public double Weight // Fetch Weight property found in BMICalculatorClass by bmiCalculator Instance
        {
            get { return _bmiCalculator.Weight; }
            set { _bmiCalculator.Weight = value; propertyIsChanged(); }
        }

        public double Result // Fetch Result property found in BMICalculatorClass by bmiCalculator Instance
        {
            get { return _bmiCalculator.Result; }
            set { _bmiCalculator.Result = value; propertyIsChanged(); }
        }

        public ObservableCollection<double> ListOfResults
        {
            get 
            { 
                return _ListOfResults;
            }
            set
            {
                _ListOfResults = value;
            }
        }

        #endregion

        #region Commands

        public Command CalculateCommand // This enables the option to write a new Command in line 25 above
        {
            get; 
            set;
        }

        #endregion

        #region Public Methods

        /**
         * Method to calculate the BMI. The InputWindow.xaml file binds the two textboxes to "Weight" and "Height" found in public properties above.
         */
        public void Calculate(Object parameter)
        {
            try
            {
                Result = Math.Round(Weight / (Height * Height), 2);
                _ListOfResults.Add(Result); // Add to an observableCollection which is bound to the ListView found in HistoryWindow.xaml
                Debug.WriteLine("Result is: " + Result);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong or missing input in one of the fields");
            }
        }
        #endregion
    }
}
