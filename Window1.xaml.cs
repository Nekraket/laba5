using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GraphicEditor
{
    public partial class MainWindow : Window
    {
        private double brushSize = 5;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColorBrush_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorBrush.SelectedIndex == 0)
            {
                DrawingAttributes.Color = Colors.Black;
            }
            if (ColorBrush.SelectedIndex == 1)
            {
                DrawingAttributes.Color = Colors.Red;
            }
            if (ColorBrush.SelectedIndex == 2)
            {
                DrawingAttributes.Color = Colors.Green;
            }
            if (ColorBrush.SelectedIndex == 3)
            {
                DrawingAttributes.Color = Colors.Blue;
            }
        }

        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            brushSize = e.NewValue;
            if (DrawingAttributes != null)
            {
                DrawingAttributes.Height = brushSize;
                DrawingAttributes.Width = brushSize;
            }
        }

        private void SetDrawingMode(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (Canvas != null)
            {
                if (DrawRadioButton.IsChecked == true)
                {
                    Canvas.EditingMode = InkCanvasEditingMode.Ink;
                }
                else if (EditRadioButton.IsChecked == true)
                {
                    Canvas.EditingMode = InkCanvasEditingMode.Select;
                }
                else if (EraseRadioButton.IsChecked == true)
                {
                    Canvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                }
            }

        }
    }
}