using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace egzamin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        byte r = 255;
        byte g = 255;
        byte b = 255;
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
         * **********************************************
        nazwa funkcji: btnDwnl_Click
        opis funkcji: Odpowiada na kliknięcie przycisku, zmieniać canvasLabel
        parametry: sender - co próbuje wywołać funkcję
        e - argument potrzebny by zdarzenia działały poprawnie
        zwracany typ i opis: brak
        autor: 18
        ***********************************************
*/
        private void btnDwnl_Click(object sender, RoutedEventArgs e)
        {
            canvasLabel.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
            canvasLabel.Content = r + ", " + g + ", " + b;
        }

        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderR.Value == null) return;
            if (rVal == null) return;
            r = (byte)sliderR.Value;
            rVal.Content = r;
            canvas.Background = new SolidColorBrush(Color.FromRgb(r, g, b));

        }

        private void sliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderG.Value == null) return;
            if (gVal == null) return;
            g = (byte)sliderG.Value;
            gVal.Content = g;
            canvas.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        private void sliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sliderB.Value == null) return;
            if (bVal == null) return;
            b = (byte)sliderB.Value;
            bVal.Content = b;
            canvas.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }
    }
}