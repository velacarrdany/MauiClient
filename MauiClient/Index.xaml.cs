namespace MauiClient;

public partial class Index : ContentPage
{
	public Index()
	{
		InitializeComponent();
	}

	private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}