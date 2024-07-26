using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.ObjectModel;
using AvaloniaUITheSeriesGTKMVVM.ViewModels.SplitViewPane ;

namespace AvaloniaUITheSeriesGTKMVVM.Views;


public partial class DataAcquisitionPageView : UserControl
{
    public DataAcquisitionPageView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}