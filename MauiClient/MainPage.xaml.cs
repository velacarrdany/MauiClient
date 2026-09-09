namespace MauiClient
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Brand = txtBrand.Text;
            car.Model = txtModel.Text;
            car.Price = Convert.ToDouble(txtPrice.Text);
            car.Release = txtRelease.Date.Value;
        }
    }
}
