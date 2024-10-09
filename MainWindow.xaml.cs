using System.Windows;
using System.Windows.Controls;

namespace MultiEdit
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Style = (Style)Resources["ActiveTextStyle"];

            TextBox symmetricalTextBox = FindSymmetricalTextBox(textBox.Name);

            if (symmetricalTextBox != null)
            {
                symmetricalTextBox.Style = (Style)Resources["ActiveTextStyle"];
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.Style = (Style)Resources["TextStyle"];

            TextBox symmetricalTextBox = FindSymmetricalTextBox(textBox.Name);

            if (symmetricalTextBox != null)
            {
                symmetricalTextBox.Style = (Style)Resources["TextStyle"];
            }
        }

        private TextBox FindSymmetricalTextBox(string name)
        {
            switch (name)
            {
                case "TextBoxLeft1":
                    return TextBoxRight1;
                case "TextBoxLeft2":
                    return TextBoxRight2;
                case "TextBoxLeft3":
                    return TextBoxRight3;
                case "TextBoxRight1":
                    return TextBoxLeft1;
                case "TextBoxRight2":
                    return TextBoxLeft2;
                case "TextBoxRight3":
                    return TextBoxLeft3;
                default:
                    return null;
            }
        }
    }
}
