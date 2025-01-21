using System.Collections.ObjectModel;

namespace ContactManager
{
    public class ContactViewModel
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public ContactViewModel()
        {
            //Instantiate Contacts collection and populate with some sample data
            Contacts = new ObservableCollection<Contact>
        {
            new Contact { Name = "John Doe", Email = "john@example.com", Phone = "123-456-7890" },
            new Contact { Name = "Jane Smith", Email = "jane@example.com", Phone = "098-765-4321" }
        };
        }
    }
}
