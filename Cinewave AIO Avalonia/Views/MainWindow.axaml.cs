using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Cinewave_AIO_Avalonia.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Movies_Button_OnClick(object? sender, RoutedEventArgs e)
    {
        PART_WebView.Url = new Uri("https://jellyfin.cinewave.lol");
        PART_WebView.IsVisible = true;
    }
}