using RestSharp;
using Newtonsoft.Json;

namespace MauiClient;

public partial class Index : ContentPage
{
	public const string url = "https://67db76a51fd9e43fe4749f9c.mockapi.io/api/v1/Auto/";
	public Index()
	{
		InitializeComponent();
        Loaded += Index_Loaded;
	}

    private async void Index_Loaded(object? sender, EventArgs e)
    {
        loadTable();
    }
    
    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private async void btnDelete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        Grid grid = (Grid)button.Parent;
        Label lblId = (Label)grid.ElementAt(0);
        int Id = int.Parse(lblId.Text);

        RestClient client = new RestClient();
        RestRequest request = new RestRequest(url + Id, Method.Delete);
        var res = await client.ExecuteDeleteAsync(request);

        if(res.StatusCode == System.Net.HttpStatusCode.OK)
        {
            await DisplayAlertAsync("Information", "Car deleted", "OK");
        }
        else
        {
            await DisplayAlertAsync("Error", res.StatusCode + " " + res.ErrorMessage, "OK");
        }

        loadTable();
    }

    private async void loadTable()
    {
        RestClient client = new RestClient();
        RestRequest request = new RestRequest(url, Method.Get);
        var res = await client.ExecuteGetAsync(request);

        if (res.StatusCode == System.Net.HttpStatusCode.OK)
        {
            List<Car> cars = (List<Car>)JsonConvert.DeserializeObject(res.Content, typeof(List<Car>));

            collection.ItemsSource = cars;
        }
    }

    private void searchCar(int Id)
    {

    }

    private void btnEdit_Clicked(object sender, EventArgs e)
    {

    }

    private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}