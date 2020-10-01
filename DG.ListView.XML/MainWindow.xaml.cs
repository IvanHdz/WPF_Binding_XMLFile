using System.Windows;
using System.Windows.Controls;

namespace DG.ListView.XML
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSelected(object sender, SelectionChangedEventArgs e)
        {
            int x = lvwEmps.Items.Count;
            int y = lvwEmps.SelectedItems.Count;
        }
    }
}