using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaUITheSeriesGTKMVVM.ViewModels.SplitViewPane;

public partial class ButtonPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isButtonEnabled = true;
}
