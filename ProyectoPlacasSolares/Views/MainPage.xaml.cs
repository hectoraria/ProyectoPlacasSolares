namespace ProyectoPlacasSolares.Views;

    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        public void onClick(object sender, EventArgs e)
         {
        
                Navigation.PushAsync(new PaginaSesion());

        }

}



