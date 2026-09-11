using RestSharp;
using Newtonsoft.Json;

namespace MauiClient;

public partial class Index : ContentPage
{
	public const string url = "https://67db76a51fd9e43fe4749f9c.mockapi.io/api/v1/Auto";
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

        if(res.StatusCode == System.Net.HttpStatusCode.OK)
        {
            List<Car> cars = (List<Car>)JsonConvert.DeserializeObject(res.Content, typeof(List<Car>));

            collection.ItemsSource = cars;
        }
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}