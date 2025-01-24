using System.Collections.ObjectModel;
using System;
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

namespace ContactManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new ObservableCollection<Contact>();
            contactListView.ItemsSource = contacts;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newContact = new Contact
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            contacts.Add(newContact);


            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (contactListView.SelectedItem != null)
            {
                contacts.Remove((Contact)contactListView.SelectedItem); 
            }
        }
    }
}