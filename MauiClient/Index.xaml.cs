using RestSharp;
using Newtonsoft.Json;

namespace MauiClient;

public partial class Index : ContentPage
{
	public const string url = "url";
	public Index()
	{
		InitializeComponent();
        Loaded += Index_Loaded;
	}

    private void Index_Loaded(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}