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

    }
}