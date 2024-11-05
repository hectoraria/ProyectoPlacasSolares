namespace ProyectoPlacasSolares.Views;

public partial class PaginaCita : ContentPage
{
	public PaginaCita()
	{
		InitializeComponent();
	}

        public void onClickMaps(object sender, EventArgs e)
    {   
        var location = new Location(1, 1);
        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };
        try
        {
            Map.Default.OpenAsync(location, options);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        }

    public void onClickFotos(object sender, EventArgs e)
    {
        MediaPicker.PickPhotoAsync();
    }
}