using System.Windows;
using WPF_Practice.Views;

namespace WPF_Practice;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnCombo_Click(object sender, RoutedEventArgs e)
    {
        wComboBox view = new()
        {
            Owner = this,
            WindowStartupLocation = WindowStartupLocation.CenterOwner
        };

        view.ShowDialog();
    }

    private void BtnListBox_Click(object sender, RoutedEventArgs e)
    {
        wListBox view = new()
        {
            Owner = this,
            WindowStartupLocation = WindowStartupLocation.CenterOwner
        };

        view.ShowDialog();
    }

    private void BtnListView_Click(object sender, RoutedEventArgs e)
    {
        wListView view = new()
        {
            Owner = this,
            WindowStartupLocation = WindowStartupLocation.CenterOwner
        };

        view.ShowDialog();
    }
}
