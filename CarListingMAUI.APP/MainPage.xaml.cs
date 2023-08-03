using CarListingMAUI.APP.ViewModels;

namespace CarListingMAUI.APP
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(ShowCarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext=carListViewModel;
        }

       
    }
}