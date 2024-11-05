namespace ProyectoPlacasSolares.Views;

public partial class PaginaSesion : ContentPage
{
	public PaginaSesion()
	{
		InitializeComponent();
	}

    private void OnCitaTapped(object sender, EventArgs e)
    {

            Navigation.PushAsync(new PaginaCita()); 
        
    }
    
}