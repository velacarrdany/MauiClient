using RestSharp;

namespace MauiClient
{
    public partial class MainPage : ContentPage
    {

        public const string url = "https://67db76a51fd9e43fe4749f9c.mockapi.io/api/v1/Auto";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Marca = txtMarca.Text;
            car.Modelo = txtModelo.Text;
            car.Precio = Convert.ToDouble(txtPrecio.Text);
            car.Lanzamiento = txtLanzamiento.Date.Value;

            RestClient client = new RestClient();
            RestRequest request = new RestRequest(url, Method.Post);
            request.AddBody(car);
            var res = await client.ExecutePostAsync(request);

            if (res.StatusCode == System.Net.HttpStatusCode.Created)
            {

                string opcion = await DisplayActionSheetAsync("Created", "Cancel", null, "Register another", "Return to menu");

                if (opcion == "Register another")
                {

                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtPrecio.Text = "";
                    txtLanzamiento.Date = DateTime.Now;

                }
                else if (opcion == "Return to menu")
                {
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlertAsync("Error", "Use couldn't be created", "OK");
                }
            }
        }
    }
}
