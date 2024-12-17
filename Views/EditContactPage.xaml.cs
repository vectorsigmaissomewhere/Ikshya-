using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

// id is the name of the id and first one is the contactId
[QueryProperty(nameof(ContactId),"Id")] 

public partial class EditContactPage : ContentPage
{
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
	public string ContactId
	{
		set
		{
			contact = ContactRepository.GetContactById(int.Parse(value));
			lblName.Text = contact.Name;	

		}
	}
}