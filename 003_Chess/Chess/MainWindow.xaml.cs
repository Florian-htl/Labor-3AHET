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

namespace Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitGame();
        }

        private void InitGame()
        {
            for (int row = 0; row < 8; row++)
            {

                for (int col = 0; col < 8; col++)
                {
                    Canvas rect = new Canvas();

                    if (col % 2 == row % 2)
                        rect.Background = Brushes.DarkGray;

                    else
                        rect.Background = Brushes.White;

                    this.SpielFeldVisualisierung.Children.Add(rect);
                }                  

            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Image image = new Image
            {
                Width = 40,
                Height = 40,
                Source = new BitmapImage(new Uri ("images/turmSchwarz.png", UriKind.Relative))
            };
            Canvas c =(Canvas)SpielFeldVisualisierung.Children[3];
            c.Children.Add(image);
            
        }
    }
}