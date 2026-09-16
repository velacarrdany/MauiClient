using RestSharp;

namespace MauiClient
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = txtBrand.Text;
            car.Model = txtModel.Text;
            car.Price = Convert.ToDouble(txtPrice.Text);
            car.Release = txtRelease.Date.Value;

            RestClient client = new RestClient();
            RestRequest request = new RestRequest(url, Method.Post);
            request.AddBody(car);
            var res = await client.ExecutePostAsync(request);

            if (res.StatusCode == System.Net.HttpStatusCode.Created)
            {

                string opcion = await DisplayActionSheetAsync("Created", "Cancel", null, "Register another", "Return to menu");

                if (opcion == "Register another")
                {

                    txtBrand.Text = "";
                    txtModel.Text = "";
                    txtPrice.Text = "";
                    txtRelease.Date = DateTime.Now;

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
