using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using DrawingAppMVVM.ViewModels;

namespace DrawingAppMVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel(DrawingAttributes, InkCanvas);
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
