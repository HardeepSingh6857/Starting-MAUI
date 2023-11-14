namespace Contacts.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void btnCancell_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}