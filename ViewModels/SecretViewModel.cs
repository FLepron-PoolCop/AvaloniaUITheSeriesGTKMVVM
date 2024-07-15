using AvaloniaUITheSeriesGTKMVVM.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaUITheSeriesGTKMVVM.ViewModels;

public partial class SecretViewModel : ViewModelBase
{
    [ObservableProperty] private string _token;

    public SecretViewModel(AuthenticationResult authResult)
    {
        Token = authResult.Token;
    }
}
