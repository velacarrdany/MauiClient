using RestSharp;

namespace MauiClient;

public partial class Edit : ContentPage
{
    public const string url = "https://67db76a51fd9e43fe4749f9c.mockapi.io/api/v1/Auto";

    Car car;

	public Edit()
	{
		InitializeComponent();
	}

    public Edit(Car _car)
    {
        InitializeComponent();
        car = _car;
        Loaded += Edit_Loaded;
    }

    private void Edit_Loaded(object? sender, EventArgs e)
    {
        txtMarca.Text = car.Marca;
        txtModelo.Text = car.Modelo;
        txtPrecio.Text = car.Precio.ToString();
        txtLanzamiento.Date = car.Lanzamiento;
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        Car a = new Car();
        a.Marca = txtMarca.Text;
        a.Modelo = txtModelo.Text;
        a.Precio = int.Parse(txtPrecio.Text);
        a.Lanzamiento = txtLanzamiento.Date.Value;

        RestClient client = new RestClient();
        RestRequest request = new RestRequest(url + car.Id, Method.Put);

        request.AddBody(a);
        var res = client.ExecutePutAsync(request);
    }
}