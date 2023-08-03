using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListingMAUI.APP.Models;
using CarListingMAUI.APP.Services;
using CarListingMAUI.APP.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace CarListingMAUI.APP.ViewModels
{
    public partial class ShowCarListViewModel : BaseViewModel
    {
        private readonly CarService CarService;
        public ObservableCollection<Car> Cars { get; set; } = new();

        public ShowCarListViewModel(CarService carService)
        {
            Title = "List Of Cars";
            CarService = carService;
        }
        [RelayCommand]
        async Task ShowCars()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Cars.Any()) Cars.Clear();
                var cars = CarService.GetAllCars();
                foreach (var car in cars)
                {
                    Cars.Add(car);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("something Went wrong !! Please Try Again");
                await Shell.Current.DisplayAlert("Error", "Faield to Retrive List of Cars !!", "Ok");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
