using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListingMAUI.APP.ViewModels.Base
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string _title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        bool _isLoading;

        public bool IsNotLoading=>!_isLoading;

    }
}
