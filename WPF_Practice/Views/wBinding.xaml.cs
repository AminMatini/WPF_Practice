using System.Windows;
using WPF_Practice.Model;

namespace WPF_Practice.Views;

/// <summary>
/// Interaction logic for wBinding.xaml
/// </summary>
public partial class wBinding : Window
{
    public wBinding()
    {
        InitializeComponent();

        DataContext = new Person() { FullName = "Amin Matini" };
    }
}
