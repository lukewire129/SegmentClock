using Avalonia.Controls;
using SegmentClock.ViewModels;

namespace SegmentClock;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = new MainViewModel();
    }
}