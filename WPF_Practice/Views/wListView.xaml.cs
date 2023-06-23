using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Practice.Model;

namespace WPF_Practice.Views
{
    /// <summary>
    /// Interaction logic for wListView.xaml
    /// </summary>
    public partial class wListView : Window
    {
        public wListView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lvPersons.ItemsSource = new List<Person>()
            {
                new Person{ FullName = "Amin"} ,
                new Person{ FullName = "Ali"} ,
                new Person{ FullName = "Mohammad"} ,
            };
        }

        private void ShowSelect(object sender, RoutedEventArgs e)
        {
            Person pr = (Person)lvPersons.SelectedItem;
            MessageBox.Show(pr.FullName.ToString());
        }
    }
}
