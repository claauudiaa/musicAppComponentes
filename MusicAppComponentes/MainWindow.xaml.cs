using System.IO;
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

namespace MusicAppComponentes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string imgPath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString()}\\Images\\MusicIcon.png";
            Musicimg.Source = new BitmapImage(new Uri(imgPath));
        }

        private void Card_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}