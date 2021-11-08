using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using DrawingAppMVVM.Models;

namespace DrawingAppMVVM.ViewModels
{
    public class MainViewModel
    {
        private DrawingAttributes _drawingAttributes;
        private InkCanvas _inkCanvas;

        public MainViewModel(DrawingAttributes drawingAttributes, InkCanvas inkCanvas)
        {
            _drawingAttributes = drawingAttributes;
            _inkCanvas = inkCanvas;

            ChangeBrushColor = new RelayCommand(obj => _drawingAttributes.Color = CanvasModel.SelectedColor.Color);
            ClearCanvas = new RelayCommand(obj => _inkCanvas.Strokes.Clear());

            ChangeBrushSize = new RelayCommand(
                obj => 
                {
                    _drawingAttributes.Height = CanvasModel.SelectedBrushSize;
                    _drawingAttributes.Width = CanvasModel.SelectedBrushSize;
                });
        }

        public CanvasModel CanvasModel { get; set; } = new();
        public ICommand ChangeBrushColor { get; set; }
        public ICommand ClearCanvas { get; set; }
        public ICommand ChangeBrushSize { get; set; }
    }
}
