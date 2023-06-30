using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using WPF_Practice.Model;

namespace WPF_Practice.Views;

/// <summary>
/// Learning Responding To Change 
/// </summary>
public partial class wRespondingChange : Window
{
    ObservableCollection<Person> list = new();
    public wRespondingChange()
    {
        InitializeComponent();

        list.Add(new Person() { FullName = "Amin" });
        list.Add(new Person() { FullName = "Ali" });
        list.Add(new Person() { FullName = "Mohammad" });

        lbPersons.ItemsSource = list;
    }

    private void BtnAdd_Click(object sender, RoutedEventArgs e)
    {
        list.Add(new Person() { FullName = "کابر جدید" });
    }

    private void BtnEdit_Click(object sender, RoutedEventArgs e)
    {
        if (lbPersons.SelectedItem != null)
            if (lbPersons.SelectedItem is Person person)
                person.FullName = "ویرایش شده";
    }

    private void BtnDelete_Click(object sender, RoutedEventArgs e)
    {
        if (lbPersons.SelectedItem != null)
            if (lbPersons.SelectedItem is Person person)
                list.Remove(person);
    }
}
 