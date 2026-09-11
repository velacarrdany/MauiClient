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

    private async void Index_Loaded(object? sender, EventArgs e)
    {
        RestClient client = new RestClient();
        RestRequest request = new RestRequest(url, Method.Get);
        var res = await client.ExecuteGetAsync(request);

        List<Car> car = (List<Car>)JsonConvert.DeserializeObject(res.Content, typeof(List<Car>));
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}