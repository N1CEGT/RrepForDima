using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Karavann.Model;

namespace Karavann
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        

        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string ass = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ass));

        }

        private List<tovar> tovares;

        public List<tovar> Alltovars
        {
            get { return tovares; }
            set { tovares = value; OnPropertyChanged(); }
        }

        public MainWindow()
        {
            InitializeComponent();
            Alltovars = App.db.tovar.ToList();
        }
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Возникла ошибка:\n" + e.Exception.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
       

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SortByComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChangeCostButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProductsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ChangeCostButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {

        }

    }
}
