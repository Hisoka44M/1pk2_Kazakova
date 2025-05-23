using System.Collections.ObjectModel;
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
using Microsoft.Win32;
using System.IO;

namespace Task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> _products = new();

        public MainWindow()
        {
            InitializeComponent();
            productsListBox.ItemsSource = _products;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(productTextBox.Text))
            {
                _products.Add(productTextBox.Text.Trim());
                productTextBox.Clear();
            }
        }

        private void SaveList_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Сохранить список продуктов"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllLines(dialog.FileName, _products);
                MessageBox.Show("Список сохранен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}