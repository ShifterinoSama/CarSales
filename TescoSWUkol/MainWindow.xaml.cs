using System.Windows;
using System.Windows.Data;

namespace TescoSWUkol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataHandler dataHandler = new();
        private CarDataHandler carDataHandler = new();
        public MainWindow()
        {

            InitializeComponent();
            MyDataGrid.ItemsSource = carDataHandler.CarTableDatas;

        }

        private void OnLoadButtonClicked(object sender, RoutedEventArgs e)
        {
            carDataHandler.Cars = dataHandler.ReadAndSaveData(dataHandler.SelectFile());
            CollectionViewSource.GetDefaultView(carDataHandler.GetCarsSoldAtWeekend()).Refresh();
        }

    }
}
