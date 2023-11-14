using System.Security.Cryptography.X509Certificates;

namespace Contacts.Views;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();

        List<Contact> contacts = new List<Contact>()
        {
            new Contact { Name="Harry", Email = "iharry6857@gmail.com"},
            new Contact { Name="Garry", Email = "garry6@gmail.com"},
            new Contact { Name="Marry", Email = "marry7@gmail.com"},
            new Contact { Name="Sarry", Email = "sarry8@gmail.com"},
            new Contact { Name="Larry", Email = "larry9@gmail.com"},

        };
        //List<string> contacts = new List<string>()
        //{
        //    "Hardeep Singh",
        //    "Narinder Singh",
        //    "Akshit Kapoor",
        //    "Satvir Singh",
        //    "Nikhil Gautam"
        //};
            listContacts.ItemsSource = contacts;        
    }

    public class Contact 
    {
        public string Name { get; set; }
        public string Email { get; set; }
     
    }
}

	
