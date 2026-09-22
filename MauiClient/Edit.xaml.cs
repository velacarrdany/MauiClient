namespace MauiClient;

public partial class Edit : ContentPage
{

    Car car;

	public Edit()
	{
		InitializeComponent();
	}

    public Edit(Car _car)
    {
        InitializeComponent();
        car = _car;
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {

    }
}