using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaUITheSeriesGTKMVVM.ViewModels.SplitViewPane;

public partial class TextPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isTextEnabled = true;
}
