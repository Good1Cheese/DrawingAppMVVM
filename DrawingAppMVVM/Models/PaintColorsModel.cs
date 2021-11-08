using System.Windows.Media;

namespace DrawingAppMVVM.Models
{
    public class PaintColorsModel
    {

        public PaintColorsModel()
        {
            AvailableColors = new SolidColorBrush[]
            {
                new SolidColorBrush(Colors.Red),
                new SolidColorBrush(Colors.Blue),
                new SolidColorBrush(Colors.Black)
            };
        }

        public SolidColorBrush SelectedColor { get; set; }
        public SolidColorBrush[] AvailableColors { get; set; }
    }
}
