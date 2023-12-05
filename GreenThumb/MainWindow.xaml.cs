using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PlantWindow plantWindow = new PlantWindow();
            plantWindow.Show();
            Close();
        }
    }
}