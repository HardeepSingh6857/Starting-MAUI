namespace Contacts.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancell_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}