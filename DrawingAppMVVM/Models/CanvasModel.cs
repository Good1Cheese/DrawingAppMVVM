using System.Windows.Media;

namespace DrawingAppMVVM.Models
{
    public class CanvasModel
    {
        public CanvasModel()
        {
            AvailableColors = new SolidColorBrush[]
            {
                new SolidColorBrush(Colors.Red),
                new SolidColorBrush(Colors.Blue),
                new SolidColorBrush(Colors.Black)
            };

            AvailableBrushSizes = new int[]
            {
                1,
                2,
                3,
                4,
                5
            };
        }

        public SolidColorBrush SelectedColor { get; set; }
        public SolidColorBrush[] AvailableColors { get; set; }
        public int SelectedBrushSize { get; set; }
        public int[] AvailableBrushSizes { get; set; }
    }
}
